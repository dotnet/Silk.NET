// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Diagnostics;
using System.IO.Hashing;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpier.Core;
using CSharpier.Core.CSharp;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using EndOfLine = CSharpier.Core.EndOfLine;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Silk.NET.SilkTouch.Mods;

internal class MSBuildModContext(string jobKey, SilkTouchConfiguration jobConfig, ILogger logger)
    : IModContext,
        IProgress<ProjectLoadProgress>,
        Microsoft.Build.Framework.ILogger
{
    private Project? _srcProject,
        _testProject;

    public string JobKey => jobKey;

    public string WorkingDirectory { get; init; } = Environment.CurrentDirectory;

    /// <inheritdoc />
    public LoggerVerbosity Verbosity { get; set; } = LoggerVerbosity.Detailed;

    /// <inheritdoc />
    public string? Parameters { get; set; } = string.Empty;

    public Project? SourceProject
    {
        get => _srcProject;
        set => Assign(ref _srcProject, ref _testProject, value, nameof(TestProject));
    }

    public Project? TestProject
    {
        get => _testProject;
        set => Assign(ref _testProject, ref _srcProject, value, nameof(SourceProject));
    }

    private static void Assign(
        ref Project? thisProject,
        ref Project? otherProject,
        Project? value,
        string otherProjectMemberName,
        [CallerMemberName] string? thisProjectMemberName = null
    )
    {
        if (thisProject is null)
        {
            if (value is null)
            {
                return;
            }

            throw new InvalidOperationException(
                $"Can't set {thisProjectMemberName} if it did not exist at time of context creation."
            );
        }

        thisProject = value ?? throw new ArgumentNullException(nameof(value));
        if (otherProject is not null)
        {
            otherProject =
                thisProject.Solution.GetProject(otherProject.Id)
                ?? throw new ArgumentException(
                    $"New {thisProjectMemberName} solution does not contain {otherProjectMemberName}.",
                    nameof(value)
                );
        }
    }

    public async Task InitializeAsync()
    {
        var solutionPath = Path.GetFullPath(jobConfig.Solution, WorkingDirectory);
        logger.LogInformation("Opening solution at {}...", solutionPath);
        var solution = await MSBuildWorkspace.Create().OpenSolutionAsync(solutionPath, this, this);

        if (jobConfig.SourceProject is null)
        {
            throw new InvalidOperationException("No source project provided in configuration.");
        }

        // First locate the source project
        var projectFile = Path.GetFullPath(jobConfig.SourceProject, WorkingDirectory);
        _srcProject = solution
            .Projects.Where(x => x.FilePath is not null)
            .FirstOrDefault(x => Path.GetFullPath(x.FilePath!, WorkingDirectory) == projectFile);
        if (_srcProject is null)
        {
            throw new InvalidOperationException("Failed to locate source project.");
        }

        // Wipe the slate clean. The generator should only be able to see generated code.
        // TODO maybe one day we'll lift this restriction? I couldn't think of a reason not to have it, but there's also not many to have it.
        SourceProject = _srcProject.RemoveDocuments([.. _srcProject.DocumentIds]);
        solution = _srcProject.Solution;
        if (jobConfig.TestProject is not null)
        {
            var testProjectFile = Path.GetFullPath(jobConfig.TestProject, WorkingDirectory);
            _testProject = solution
                .Projects.Where(x => x.FilePath is not null)
                .FirstOrDefault(x =>
                    Path.GetFullPath(x.FilePath!, WorkingDirectory) == testProjectFile
                );
            TestProject = _testProject?.RemoveDocuments([.. _testProject.DocumentIds]);
            solution = _testProject?.Solution ?? solution;
        }
    }

    public async ValueTask DisposeAsync()
    {
        IEnumerable<string>? existingFiles = null;
        if (Path.GetDirectoryName(_srcProject?.FilePath) is not { Length: > 0 } srcDir)
        {
            return;
        }

        existingFiles = Directory.GetFiles(srcDir, "*.gen.cs", SearchOption.AllDirectories);
        var testDir = Path.GetDirectoryName(_testProject?.FilePath);
        if (testDir is { Length: > 0 })
        {
            existingFiles = existingFiles.Concat(
                Directory.GetFiles(testDir, "*.gen.cs", SearchOption.AllDirectories)
            );
        }

        existingFiles = existingFiles.Select(x => x.Replace('\\', '/'));
        var pool = ArrayPool<byte>.Create();
        var existingFileSet = new HashSet<string>(existingFiles);
        var existingFileGate = 0;
        var sw = Stopwatch.StartNew();
        logger.LogInformation("Writing {} to disk...", JobKey);
        var defaultLicenseHeaderTrivia = jobConfig.DefaultLicenseHeader is null
            ? null
            : (await File.ReadAllLinesAsync(jobConfig.DefaultLicenseHeader))
                .Where(x => x.Length == 0 || x.StartsWith("//"))
                .Select(x => Comment(x.Trim()))
                .ToArray();
        await Parallel.ForEachAsync(
            [.. SourceProject?.Documents ?? [], .. TestProject?.Documents ?? []],
            async (doc, ct) =>
            {
                if (
                    doc.FilePath is null
                    || await doc.GetSyntaxRootAsync(ct) is not { } root
                    || Path.GetDirectoryName(doc.FilePath) is not { Length: > 0 } fileDir
                    || (
                        Path.GetRelativePath(srcDir, doc.FilePath).StartsWith("..")
                        && (
                            testDir is null
                            || Path.GetRelativePath(testDir, doc.FilePath).StartsWith("..")
                        )
                    )
                )
                {
                    logger.LogWarning(
                        "Invalid document \"{}\" ({}) generated, please check the syntax root and file path.",
                        doc.Name,
                        doc.Id
                    );
                    return;
                }

                Directory.CreateDirectory(fileDir);
                await DiffWriteAsync(doc.FilePath, root, pool, defaultLicenseHeaderTrivia, ct);
                while (Interlocked.CompareExchange(ref existingFileGate, 1, 0) != 0)
                {
                    // look ma I made a BreakneckLock
                }

                existingFileSet.Remove(doc.FilePath.Replace('\\', '/'));
                existingFileGate = 0;
            }
        );

        // Delete any stray .gen.cs files.
        foreach (var existing in existingFileSet)
        {
            File.Delete(existing);
            logger.LogDebug("Deleted {}", existing);
        }
        logger.LogInformation("Wrote {} to disk in {} seconds.", JobKey, sw.Elapsed.TotalSeconds);
    }

    private async Task DiffWriteAsync(
        string fname,
        SyntaxNode node,
        ArrayPool<byte> pool,
        SyntaxTrivia[]? defaultLicenseHeaderTrivia = null,
        CancellationToken ct = default
    )
    {
        // SilkTouch thrashes write IO which is slower than just reading and hashing in most cases.
        // It also results in IDE thinking there are changes for unchanged files which also thrashes IO.
        // For this and a slew of other reasons, essentially in 2.X BuildTools was changed to only touch the disk if we
        // actually needed to, which this is the 3.0 equivalent of. This is improved beyond BuildTools as this uses XXH3
        // instead of SHA, which should be faster.
        byte[]? hashBuffer = null;
        Task? existingTask = null;
        if (File.Exists(fname))
        {
            hashBuffer = pool.Rent(16);

            // Fire off the slow existing file hashing as a background task.
            existingTask = File.Exists(fname)
                ? Task.Run(
                    async () =>
                        XxHash3.Hash(
                            await File.ReadAllBytesAsync(fname, ct),
                            hashBuffer.AsSpan()[..8]
                        ),
                    ct
                )
                : Task.CompletedTask;
        }

        // Add a license header to files that don't have one
        if (defaultLicenseHeaderTrivia is not null)
        {
            var shouldAddHeader =
                !node.GetLeadingTrivia().Any(x => x.Kind() is SyntaxKind.SingleLineCommentTrivia)
                || !(
                    node.ChildNodes()
                        .FirstOrDefault()
                        ?.GetLeadingTrivia()
                        .Any(x => x.Kind() is SyntaxKind.SingleLineCommentTrivia)
                ).GetValueOrDefault();
            if (shouldAddHeader)
            {
                node = node.WithLeadingTrivia(
                    defaultLicenseHeaderTrivia.Concat(node.GetLeadingTrivia())
                );
            }
        }

        // Convert our syntax node to a UTF-8 byte array using CSharpier
        var outputString = await ToNormalisedStringAsync(node, ct);
        var byteCount = Encoding.UTF8.GetByteCount(outputString);
        var outputArray = pool.Rent(byteCount);
        Encoding.UTF8.GetBytes(outputString, outputArray);
        if (hashBuffer is not null)
        {
            // Compute the hash of our proposed output
            XxHash3.Hash(outputArray.AsSpan()[..byteCount], hashBuffer.AsSpan()[8..16]);
            await existingTask!; // <-- make sure the background task has finished
        }

        // Output if the hashes differ
        if (
            hashBuffer is null
            || !hashBuffer[..8].AsSpan().SequenceEqual(hashBuffer.AsSpan()[8..16])
        )
        {
            await using var fs = File.Open(fname, FileMode.Create);
            await fs.WriteAsync(outputArray.AsMemory()[..byteCount], ct);
            await fs.FlushAsync(ct);
            logger.LogDebug("Wrote {}", fname);
        }
        else
        {
            logger.LogDebug("{} is up-to-date", fname);
        }

        // No memory leaks here!
        if (hashBuffer is not null)
        {
            pool.Return(hashBuffer);
        }

        pool.Return(outputArray);
    }

    private static readonly CodeFormatterOptions _opts = new() { EndOfLine = EndOfLine.LF };

    /// <summary>
    /// Prettifies the given syntax tree using <see cref="CSharpier"/> if possible, otherwise uses Roslyn to normalize
    /// the whitespace.
    /// </summary>
    /// <param name="root">The root of the syntax tree.</param>
    /// <param name="ct">A cancellation token.</param>
    /// <returns>An asynchronous task returning the string.</returns>
    private static async Task<string> ToNormalisedStringAsync(
        SyntaxNode root,
        CancellationToken ct = default
    )
    {
        var normalizedRoot = root.NormalizeWhitespace();
        var result = await CSharpFormatter.FormatAsync(normalizedRoot.SyntaxTree, _opts, ct);
        return !result.ErrorDiagnostics.Any() ? result.Code : normalizedRoot.ToFullString();
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
}
