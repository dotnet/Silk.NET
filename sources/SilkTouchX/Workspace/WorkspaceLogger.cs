using System;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;

namespace SilkTouchX.Workspace;

/// <summary>
/// Forwards MSBuild logs to MS.Extensions.Logging.
/// </summary>
public class WorkspaceLogger : Microsoft.Build.Framework.ILogger
{
    private readonly ILogger<WorkspaceLogger> _logger;
    private IEventSource? _eventSource;

    /// <summary>
    /// Creates an MSBuild logger using the given MS logger.
    /// </summary>
    /// <param name="logger">Underlying logger.</param>
    public WorkspaceLogger(ILogger<WorkspaceLogger> logger) => _logger = logger;

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
        _logger.LogTrace(
            "At {0} {1} raised status event: {2} ({3})", e.Timestamp, e.SenderName, e.Message,
            e.HelpKeyword);

    private void EventSourceOnCustomEventRaised(object sender, CustomBuildEventArgs e) =>
        _logger.LogTrace("At {0} {1} raised custom event: {2} ({3})", e.Timestamp, e.SenderName, e.Message,
            e.HelpKeyword);

    private void EventSourceOnWarningRaised(object sender, BuildWarningEventArgs e) =>
        _logger.LogWarning(
            "{0}:{1}:{2} : warning {3}: {4} ({5})", e.File, e.LineNumber, e.ColumnNumber, e.Code, e.Message,
            e.ProjectFile);

    private void EventSourceOnTaskStarted(object sender, TaskStartedEventArgs e) =>
        _logger.LogTrace(
            "At {0} {1} started task {2} from {3}, message: {4} ({5})", e.Timestamp, e.SenderName, e.TaskName,
            e.TaskFile, e.Message,
            e.HelpKeyword);

    private void EventSourceOnTaskFinished(object sender, TaskFinishedEventArgs e) =>
        _logger.LogTrace(
            "At {0} {1} finished task {2} from {3}, message: {4} ({5})", e.Timestamp, e.SenderName, e.TaskName,
            e.TaskFile, e.Message,
            e.HelpKeyword);

    private void EventSourceOnTargetStarted(object sender, TargetStartedEventArgs e) =>
        _logger.LogTrace(
            "At {0} {1} started target {2} from {3}, message: {4} ({5})", e.Timestamp, e.SenderName, e.TargetName,
            e.TargetFile, e.Message,
            e.HelpKeyword);

    private void EventSourceOnTargetFinished(object sender, TargetFinishedEventArgs e) =>
        _logger.LogTrace(
            "At {0} {1} finished target {2} from {3}, message: {4} ({5})", e.Timestamp, e.SenderName, e.TargetName,
            e.TargetFile, e.Message,
            e.HelpKeyword);

    private void EventSourceOnProjectStarted(object sender, ProjectStartedEventArgs e) =>
        _logger.LogTrace("MSBuild started processing project {0}: {1}", e.ProjectFile, e.Message);

    private void EventSourceOnProjectFinished(object sender, ProjectFinishedEventArgs e) =>
        _logger.LogTrace("MSBuild finished processing project {0}: {1}", e.ProjectFile, e.Message);

    private void EventSourceOnMessageRaised(object sender, BuildMessageEventArgs e) =>
        _logger.LogTrace(
            "{0}:{1}:{2} : message {3}: {4} ({5})", e.File, e.LineNumber, e.ColumnNumber, e.Code, e.Message,
            e.ProjectFile);

    private void EventSourceOnErrorRaised(object sender, BuildErrorEventArgs e) =>
        _logger.LogError(
            "{0}:{1}:{2} : error {3}: {4} ({5})", e.File, e.LineNumber, e.ColumnNumber, e.Code, e.Message,
            e.ProjectFile);

    private void EventSourceOnBuildFinished(object sender, BuildFinishedEventArgs e)
        // was going to be a LogDebug/LogError but it seems this happens in some cases anyway?
        => _logger.LogDebug(e.Succeeded ? "MSBuild completed successfully" : "MSBuild failed (might be okay?)");

    private void EventSourceOnAnyEventRaised(object sender, BuildEventArgs e) =>
        _logger.LogTrace(
            "At {0} {1} raised event: {2} ({3})", e.Timestamp, e.SenderName, e.Message,
            e.HelpKeyword);

    private void EventSourceOnBuildStarted(object sender, BuildStartedEventArgs e) =>
        _logger.LogDebug("MSBuild started.");

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
    public string Parameters { get; set; } = string.Empty;
}
