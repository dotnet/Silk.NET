using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
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
        public static string[] Args { get; internal set; }

        static async Task<int> Main(string[] args)
        {
            Args = args;
            if (args.Length > 0 && args[0].ToLower() == "clangsharp")
            {
                return ClangSharpHandoff.RunClangSharp(args);
            }

            Console.WriteLine
            (
                "Silk.NET SilkTouch - " +
                $"v{typeof(Program).Assembly.GetName().Version?.ToString(3)} - " +
                "Copyright (c) .NET Foundation and Contributors"
            );

            var slnOrProjInCwd = ResolveProjectOrSolutionInCwd();
            var rootCommand = new RootCommand
            {
                slnOrProjInCwd is null ? new Option<FileInfo>
                (
                    new[] { "--project", "-p" },
                    "The input solution or project file to generate for."
                ) : new
                (
                    new[] { "--project", "-p" },
                    () => slnOrProjInCwd, // add a default value factory if we've found an individual project or solution
                    "The input solution or project file to generate for."
                ),
                new Option<LogMode>
                (
                    new[] {"--logging", "-l"},
                    () => LogMode.Standard,
                    "The debug logging verbosity."
                )
            };

            rootCommand.Handler = CommandHandler.Create<FileInfo, LogMode>(RunSilkTouchAsync);
            return await rootCommand.InvokeAsync(args);
        }

        private static async Task<int> RunSilkTouchAsync(FileInfo projectOrSolution, LogMode logMode)
        {
            if (logMode != LogMode.Silent)
            {
                Console.WriteLine
                (
                    "Silk.NET SilkTouch - " +
                    $"v{typeof(Program).Assembly.GetName().Version?.ToString(3)} - " +
                    "Copyright (c) .NET Foundation and Contributors"
                );
            }

            var sw = new Stopwatch();

            // Configure the logger
            var loggerProvider = new UltzLoggerProvider();
            loggerProvider.LogLevels.Clear();
            
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (logMode)
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
                    break;
                }
                case LogMode.Verbose:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Trace);
                    break;
                }
                case LogMode.VVerbose:
                {
                    loggerProvider.LogLevels.Add(LogLevel.Debug);
                    break;
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
            using var projectOrSolutionReader = projectOrSolution.OpenText();
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
                var sln = await workspace.OpenSolutionAsync(projectOrSolution.FullName);
                await Parallel.ForEachAsync(sln.Projects, GeneratorHandoff.HandleProjectAsync);
            }
            else
            {
                await GeneratorHandoff.HandleProjectAsync
                (
                    await workspace.OpenProjectAsync(projectOrSolution.FullName),
                    CancellationToken.None
                );
            }

            sw.Stop();
            Log.Information($"Concluded after {sw.Elapsed.TotalSeconds} seconds.");
            return GeneratorHandoff.ExitCode;
        }

        private static void LogWorkspaceFailure(object? sender, WorkspaceDiagnosticEventArgs e)
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
