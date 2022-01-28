using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp.Interop;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Ultz.Extensions.Logging;

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

            var slnOrProjInCwd = ResolveProjectOrSolutionInCwd();
            var rootCommand = new RootCommand
            {
                slnOrProjInCwd is null
                    ? new Option<FileInfo>
                    (
                        new[] { "--project", "-p" },
                        "The input solution or project file to generate for."
                    )
                    {
                        IsRequired = true
                    }
                    : new
                    (
                        new[] { "--project", "-p" },
                        () => slnOrProjInCwd, // add a default value factory if we've found an individual project or solution
                        "The input solution or project file to generate for."
                    ),
                new Option<LogMode>
                (
                    new[] { "--logging", "-l" },
                    () => Debugger.IsAttached ? LogMode.VVerbose : LogMode.Standard,
                    "The debug logging verbosity."
                ),
                new Option<bool>
                (
                    new[] { "--no-environment-emulation", "-E" },
                    () => false,
                    "Disables environment emulation for subagents i.e. does not run subagents in a Visual Studio " +
                    "Developer Command Prompt. Disabling this is useful if your Visual Studio instance does not have " +
                    $"clang {typeof(clang).Assembly.GetName().Version?.Major} installed."
                )
            };
            
            rootCommand.Handler = CommandHandler.Create<FileInfo, LogMode, bool>(RunSilkTouchAsync);
            return await rootCommand.InvokeAsync(args);
        }

        private static async Task<int> RunSilkTouchAsync(FileInfo project, LogMode logging, bool noEnvironmentEmulation)
        {
            NoEnvironmentEmulation = noEnvironmentEmulation;
            if (logging != LogMode.Silent)
            {
                Console.WriteLine
                (
                    "Silk.NET SilkTouch - " +
                    $"v{typeof(Program).Assembly.GetName().Version?.ToString(3)} - " +
                    "Copyright (c) .NET Foundation and Contributors"
                );
            }

            // Configure the logger
            var loggerProvider = new UltzLoggerProvider();
            loggerProvider.LogLevels.Clear();

            var sw = Stopwatch.StartNew();

            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (logging)
            {
                case LogMode.Silent:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Error);
                    loggerProvider.LogLevels.Add(LogLevel.Critical);
                    break;
                }
                case LogMode.Standard:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Information);
                    loggerProvider.LogLevels.Add(LogLevel.Warning);
                    goto case LogMode.Silent;
                }
                case LogMode.Verbose:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Trace);
                    goto case LogMode.Standard;
                }
                case LogMode.VVerbose:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Debug);
                    goto case LogMode.Verbose;
                }
            }

            Log.LoggerProvider = loggerProvider;

            // Select MSBuild
            if (!VisualStudioResolver.TryGetMSBuildInfo(out var instance))
            {
                Log.Error("Failed to get MSBuild info.");
                return 4;
            }

            MSBuildLocator.RegisterInstance(instance);

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
            workspace.WorkspaceFailed += LogWorkspaceFailure;

            // Load the workspace and handoff to the generators
            if (isSolution)
            {
                var sln = await workspace.OpenSolutionAsync(project.FullName);
                await Parallel.ForEachAsync(sln.Projects, (x, _) => GeneratorHandoff.HandleProjectAsync(workspace, x));
            }
            else
            {
                await GeneratorHandoff.HandleProjectAsync
                (
                    workspace,
                    await workspace.OpenProjectAsync(project.FullName)
                );
            }

            Log.Information
            (
                GeneratorHandoff.ExitCode == 0
                    ? $"Finished after {sw.Elapsed.TotalSeconds} seconds."
                    : $"Failed after {sw.Elapsed.TotalSeconds} seconds."
            );

            return GeneratorHandoff.ExitCode;
        }

        private static void LogWorkspaceFailure(object? s, WorkspaceDiagnosticEventArgs e)
        {
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (e.Diagnostic.Kind)
            {
                case WorkspaceDiagnosticKind.Failure:
                {
                    Log<MSBuildWorkspace>.Logger.LogError(e.Diagnostic.Message);
                    break;
                }
                case WorkspaceDiagnosticKind.Warning:
                {
                    Log<MSBuildWorkspace>.Logger.LogWarning(e.Diagnostic.Message);
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
