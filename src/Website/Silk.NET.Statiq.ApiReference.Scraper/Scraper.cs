// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Logging;
using Ultz.Extensions.Logging;

namespace Silk.NET.Statiq.ApiReference.Scraper;

internal class Scraper
{
    public static bool Failed { get; set; }
    public static async Task<int> RunAsync(FileInfo project, FileInfo output, LogMode logging, DirectoryInfo intermediateOutput)
    {
        // Configure the logger
        var loggerProvider = new UltzLoggerProvider();
        loggerProvider.LogLevels.Clear();

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
        
        MSBuildLocator.RegisterInstance
        (
            MSBuildLocator.QueryVisualStudioInstances()
                .OrderBy(x => x.DiscoveryType)
                .ThenByDescending(x => x.Version)
                .First()
        );
        
        Log.Information($"Chosen MSBuild: {Environment.GetEnvironmentVariable("MSBUILD_EXE_PATH")}");
        
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
        
            if (line.Trim().Contains("<Project"))
            {
                // good indicator it's a project file
                break;
            }
        }
        
        // workspace.SkipUnrecognizedProjects = true;
        // workspace.LoadMetadataForReferencedProjects = true;
        workspace.WorkspaceFailed += LogWorkspaceFailure;

        // Load the workspace and handoff to the scraper
        Log.Debug($"Using intermediate output directory \"{intermediateOutput.FullName}\"");
        var scraper = new CSharpScraper(intermediateOutput);
        if (isSolution)
        {
            var sln = await workspace.OpenSolutionAsync(project.FullName, new ProgressLogger());
            await Parallel.ForEachAsync
            (
                sln.Projects,
                async (slnProject, _) => await scraper.HandleProjectAsync(workspace, slnProject)
            );
        }
        else
        {
            await scraper.HandleProjectAsync
            (
                workspace,
                await workspace.OpenProjectAsync(project.FullName, new ProgressLogger())
            );
        }

        using var writer = output.Create();
        // TODO

        return Failed ? -1 : 0;
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
}
