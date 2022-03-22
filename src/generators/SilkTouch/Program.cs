using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ClangSharp.Interop;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Silk.NET.SilkTouch.Configuration;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    internal class Program
    {
        public static bool NoEnvironmentEmulation { get; internal set; }
        static async Task<int> Main(string[] args)
        {
            if (args.Length > 0 && args[0].ToLower() == "clangsharp")
            {
                return ClangSharpHandoff.RunClangSharp(args);
            }

            
            using var host = new HostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureHostConfiguration(config =>
            {
                config.AddEnvironmentVariables(prefix: "DOTNET_");
                if (args is { Length: > 0 })
                {
                    config.AddCommandLine(args);
                }
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                IHostEnvironment env = hostingContext.HostingEnvironment;
                bool reloadOnChange = hostingContext.Configuration.GetValue("hostBuilder:reloadConfigOnChange", defaultValue: true);

                // possible confusion: "Config" may be taken from the command line, despite them being configured below
                // this is because here we take the configuration value from host configuration, which is defined above
                // and is configured to ALSO be configured from command line.
                var configPath = hostingContext.Configuration.GetValue("Config", defaultValue: "silktouch.json");
                config.AddJsonFile(configPath, optional: true, reloadOnChange: reloadOnChange);

                config.AddEnvironmentVariables("SilkTouch_");

                if (args is { Length: > 0 })
                {
                    config.AddCommandLine(args);
                }
            })
            .ConfigureLogging((hostingContext, logging) =>
            {
                bool isWindows = OperatingSystem.IsWindows();

                // IMPORTANT: This needs to be added *before* configuration is loaded, this lets
                // the defaults be overridden by the configuration.
                if (isWindows)
                {
                    // Default the EventLogLoggerProvider to warning or above
                    logging.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Warning);
                }

                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                if (!OperatingSystem.IsBrowser())
                {
                    logging.AddConsole();
                }
                logging.AddDebug();
                logging.AddEventSourceLogger();

                if (isWindows)
                {
                    // Add the EventLogLoggerProvider on windows machines
                    logging.AddEventLog();
                }

                logging.Configure(options =>
                {
                    options.ActivityTrackingOptions =
                        ActivityTrackingOptions.SpanId |
                        ActivityTrackingOptions.TraceId |
                        ActivityTrackingOptions.ParentId;
                });

            })
            .UseDefaultServiceProvider((context, options) =>
            {
                bool isDevelopment = context.HostingEnvironment.IsDevelopment();
                options.ValidateScopes = isDevelopment;
                options.ValidateOnBuild = isDevelopment;
            })
            .ConfigureServices(ConfigureServices)
            .Build();
            
            await host.StartAsync();
            var configuration = host.Services.GetRequiredService<IConfiguration>();
            var logger = host.Services.GetRequiredService<ILoggerFactory>().CreateLogger("Main");

            FileInfo? project = null;
            if (configuration["Project"] is not null)
            {
                var f = new FileInfo(configuration["Project"]);
                if (f.Exists)
                {
                    project = f;
                    logger.LogInformation("Using project from configuration");
                }
            }   
            
            if (project is null)
            {
                var slnOrProjInCwd = ResolveProjectOrSolutionInCwd();
                if (slnOrProjInCwd is not null)
                {
                    project = slnOrProjInCwd;
                    logger.LogInformation("Using locally resolved project");
                }
            }

            if (project is null)
            {
                // ReSharper disable once LogMessageIsSentenceProblem
                logger.LogCritical("Could not find a project or solution to work on. Either provide one using configuration.");
                return -1;
            }

            var result = await RunSilkTouchAsync(host.Services, project, configuration.GetValue<bool>("NoEnvironmentEmulation", false));

            await host.StopAsync();

            return result;
        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services
                .Configure<GlobalConfiguration>(context.Configuration.GetSection(GlobalConfiguration.Section))
                .Configure<EmitterConfiguration>(context.Configuration.GetSection(EmitterConfiguration.Section))
                .Configure<OverloaderConfiguration>(context.Configuration.GetSection(OverloaderConfiguration.Section))
                .Configure<ScraperConfiguration>(context.Configuration.GetSection(ScraperConfiguration.Section))
                .Configure<ProjectConfiguration>(context.Configuration.GetSection(ProjectConfiguration.Section));
        }

        private static async Task<int> RunSilkTouchAsync(IServiceProvider services, FileInfo project, bool noEnvironmentEmulation)
        {
            NoEnvironmentEmulation = noEnvironmentEmulation;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger("RunSilkTouchAsync");
            logger.LogInformation
            (
                "Silk.NET SilkTouch - " +
                "v{Version} - " +
                "Copyright (c) .NET Foundation and Contributors",
                typeof(Program).Assembly.GetName().Version?.ToString(3)
            );

            var sw = Stopwatch.StartNew();

            // Select MSBuild
            if (!VisualStudioResolver.TryGetVisualStudioInfo(out var instance))
            {
                logger.LogCritical("Failed to get MSBuild info");
                return 4;
            }

            // Create Workspace
            using var workspace = MSBuildWorkspace.Create();
            using var projectOrSolutionReader = project.OpenText();
            string? line;
            var isSolution = false;
            while ((line = await projectOrSolutionReader.ReadLineAsync()) is not null)
            {
                if (line.Trim().StartsWith("VisualStudioVersion"))
                {
                    // good indicator it's a solution file
                    isSolution = true;
                    break;
                }

                if (line.Contains("<Project"))
                {
                    // good indicator it's a project file
                    break;
                }
            }

            workspace.SkipUnrecognizedProjects = true;
            workspace.LoadMetadataForReferencedProjects = true;
            var workspaceLogger = loggerFactory.CreateLogger("MSBuildWorkspace");
            workspace.WorkspaceFailed += (s, e) => LogWorkspaceFailure(workspaceLogger, s, e);

            // Load the workspace and handoff to the generators
            if (isSolution)
            {
                var sln = await workspace.OpenSolutionAsync(project.FullName);
                // ReSharper disable once AccessToDisposedClosure
                await Task.WhenAll(sln.Projects.Select(x => GeneratorHandoff.HandleProjectAsync(services, x)));
            }
            else
            {
                await GeneratorHandoff.HandleProjectAsync
                (
                    services,
                    await workspace.OpenProjectAsync(project.FullName)
                );
            }

            logger.LogInformation("{Status} after {Seconds} seconds", GeneratorHandoff.ExitCode == 0 ? "Finished" : "Failed",
                sw.Elapsed.TotalSeconds);

            return GeneratorHandoff.ExitCode;
        }

        private static void LogWorkspaceFailure(ILogger logger, object? s, WorkspaceDiagnosticEventArgs e)
        {
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (e.Diagnostic.Kind)
            {
                case WorkspaceDiagnosticKind.Failure:
                {
                    logger.LogError("{Message}", e.Diagnostic.Message);
                    break;
                }
                case WorkspaceDiagnosticKind.Warning:
                {
                    logger.LogWarning("{Message}", e.Diagnostic.Message);
                    break;
                }
            }
        }

        private static FileInfo? ResolveProjectOrSolutionInCwd()
        {
            var slnOrProj = Directory.GetFiles(Environment.CurrentDirectory, "*.sln")
                .Concat(Directory.GetFiles(Environment.CurrentDirectory, "*.csproj"));
            string? candidateFile = null;
            foreach (var theFile in slnOrProj)
            {
                if (candidateFile is null)
                {
                    candidateFile = theFile;
                }
                else
                {
                    // multiple files detected! we can't safely decide which one to use...
                    return null;
                }
            }

            if (candidateFile is null)
            {
                return null;
            }

            return new(candidateFile);
        }
    }
}
