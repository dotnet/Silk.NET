// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A <see cref="IModContextProvider"/> that uses an MSBuild workspace and writes the modified files to disk (without
/// project modifications) upon disposal of the returned contexts.
/// </summary>
public class MSBuildModContextProvider(ILogger<MSBuildModContextProvider> logger)
    : IModContextProvider,
        IProgress<ProjectLoadProgress>,
        Microsoft.Build.Framework.ILogger
{
    private readonly ConcurrentDictionary<string, Task<Solution>> _solutions = [];

    internal Task<Solution> OpenSolutionAsync(string file) =>
        _solutions.GetOrAdd(
            file,
            async x =>
            {
                logger.LogInformation("Opening solution at {}...", x);
                return await MSBuildWorkspace.Create().OpenSolutionAsync(x, this, this);
            }
        );

    /// <inheritdoc />
    public async Task<IModContext> GetContextAsync(
        string key,
        IConfigurationSection cfg,
        CancellationToken ct = default
    )
    {
        var ret = new MSBuildModContext(this, cfg, logger);
        await ret.InitializeAsync();
        return ret;
    }

    /// <inheritdoc />
    public void Report(ProjectLoadProgress value) =>
        logger.LogDebug(
            "{0}: {1}({2}) - elapsed {3}",
            value.Operation,
            value.FilePath,
            value.TargetFramework,
            value.ElapsedTime
        );

    private IEventSource? _eventSource;

    /// <inheritdoc />
    public void Initialize(IEventSource eventSource)
    {
        if (_eventSource is not null)
        {
            throw new InvalidOperationException("Already initialised.");
        }

        _eventSource = eventSource;
        _eventSource.BuildStarted += EventSourceOnBuildStarted;
        _eventSource.AnyEventRaised += EventSourceOnAnyEventRaised;
        _eventSource.BuildFinished += EventSourceOnBuildFinished;
        _eventSource.ErrorRaised += EventSourceOnErrorRaised;
        _eventSource.MessageRaised += EventSourceOnMessageRaised;
        _eventSource.ProjectFinished += EventSourceOnProjectFinished;
        _eventSource.ProjectStarted += EventSourceOnProjectStarted;
        _eventSource.TargetFinished += EventSourceOnTargetFinished;
        _eventSource.TargetStarted += EventSourceOnTargetStarted;
        _eventSource.TaskFinished += EventSourceOnTaskFinished;
        _eventSource.TaskStarted += EventSourceOnTaskStarted;
        _eventSource.WarningRaised += EventSourceOnWarningRaised;
        _eventSource.CustomEventRaised += EventSourceOnCustomEventRaised;
        _eventSource.StatusEventRaised += EventSourceOnStatusEventRaised;
    }

    private void EventSourceOnStatusEventRaised(object sender, BuildStatusEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} raised status event: {2} ({3})",
            e.Timestamp,
            e.SenderName,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnCustomEventRaised(object sender, CustomBuildEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} raised custom event: {2} ({3})",
            e.Timestamp,
            e.SenderName,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnWarningRaised(object sender, BuildWarningEventArgs e) =>
        logger.LogWarning(
            "{0}:{1}:{2} : warning {3}: {4} ({5})",
            e.File,
            e.LineNumber,
            e.ColumnNumber,
            e.Code,
            e.Message,
            e.ProjectFile
        );

    private void EventSourceOnTaskStarted(object sender, TaskStartedEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} started task {2} from {3}, message: {4} ({5})",
            e.Timestamp,
            e.SenderName,
            e.TaskName,
            e.TaskFile,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnTaskFinished(object sender, TaskFinishedEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} finished task {2} from {3}, message: {4} ({5})",
            e.Timestamp,
            e.SenderName,
            e.TaskName,
            e.TaskFile,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnTargetStarted(object sender, TargetStartedEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} started target {2} from {3}, message: {4} ({5})",
            e.Timestamp,
            e.SenderName,
            e.TargetName,
            e.TargetFile,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnTargetFinished(object sender, TargetFinishedEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} finished target {2} from {3}, message: {4} ({5})",
            e.Timestamp,
            e.SenderName,
            e.TargetName,
            e.TargetFile,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnProjectStarted(object sender, ProjectStartedEventArgs e) =>
        logger.LogTrace("MSBuild started processing project {0}: {1}", e.ProjectFile, e.Message);

    private void EventSourceOnProjectFinished(object sender, ProjectFinishedEventArgs e) =>
        logger.LogTrace("MSBuild finished processing project {0}: {1}", e.ProjectFile, e.Message);

    private void EventSourceOnMessageRaised(object sender, BuildMessageEventArgs e) =>
        logger.LogTrace(
            "{0}:{1}:{2} : message {3}: {4} ({5})",
            e.File,
            e.LineNumber,
            e.ColumnNumber,
            e.Code,
            e.Message,
            e.ProjectFile
        );

    private void EventSourceOnErrorRaised(object sender, BuildErrorEventArgs e) =>
        logger.LogError(
            "{0}:{1}:{2} : error {3}: {4} ({5})",
            e.File,
            e.LineNumber,
            e.ColumnNumber,
            e.Code,
            e.Message,
            e.ProjectFile
        );

    private void EventSourceOnBuildFinished(object sender, BuildFinishedEventArgs e)
        // was going to be a LogDebug/LogError but it seems this happens in some cases anyway?
        =>
        logger.LogDebug(
            e.Succeeded ? "MSBuild completed successfully" : "MSBuild failed (might be okay?)"
        );

    private void EventSourceOnAnyEventRaised(object sender, BuildEventArgs e) =>
        logger.LogTrace(
            "At {0} {1} raised event: {2} ({3})",
            e.Timestamp,
            e.SenderName,
            e.Message,
            e.HelpKeyword
        );

    private void EventSourceOnBuildStarted(object sender, BuildStartedEventArgs e) =>
        logger.LogDebug("MSBuild started.");

    /// <inheritdoc />
    public void Shutdown()
    {
        if (_eventSource is null)
        {
            return;
        }

        _eventSource.BuildStarted -= EventSourceOnBuildStarted;
        _eventSource.AnyEventRaised -= EventSourceOnAnyEventRaised;
        _eventSource.BuildFinished -= EventSourceOnBuildFinished;
        _eventSource.ErrorRaised -= EventSourceOnErrorRaised;
        _eventSource.MessageRaised -= EventSourceOnMessageRaised;
        _eventSource.ProjectFinished -= EventSourceOnProjectFinished;
        _eventSource.ProjectStarted -= EventSourceOnProjectStarted;
        _eventSource.TargetFinished -= EventSourceOnTargetFinished;
        _eventSource.TargetStarted -= EventSourceOnTargetStarted;
        _eventSource.TaskFinished -= EventSourceOnTaskFinished;
        _eventSource.TaskStarted -= EventSourceOnTaskStarted;
        _eventSource.WarningRaised -= EventSourceOnWarningRaised;
        _eventSource.CustomEventRaised -= EventSourceOnCustomEventRaised;
        _eventSource.StatusEventRaised -= EventSourceOnStatusEventRaised;
        _eventSource = null;
    }

    /// <inheritdoc />
    public LoggerVerbosity Verbosity { get; set; } = LoggerVerbosity.Detailed;

    /// <inheritdoc />
    public string? Parameters { get; set; } = string.Empty;
}
