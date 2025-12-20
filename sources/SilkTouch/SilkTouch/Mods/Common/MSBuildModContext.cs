// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharpier;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using EndOfLine = CSharpier.EndOfLine;

namespace Silk.NET.SilkTouch.Mods;

internal class MSBuildModContext(
    MSBuildModContextProvider parent,
    IConfigurationSection cfg,
    ILogger logger
) : IModContext
{
    private Project? _srcProject,
        _testProject;

    private SilkTouchConfiguration? _cfg = cfg.Get<SilkTouchConfiguration>();
    public string JobKey { get; } = cfg.Key;
    public string ConfigurationDirectory { get; init; } = Environment.CurrentDirectory;

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
        if (_cfg?.Solution is null)
        {
            throw new InvalidOperationException("No solution provided in configuration.");
        }

        var solution = await parent.OpenSolutionAsync(
            Path.GetFullPath(_cfg.Solution, ConfigurationDirectory)
        );

        if (_cfg?.SourceProject is null)
        {
            throw new InvalidOperationException("No source project provided in configuration.");
        }

        // First locate the source project
        var projectFile = Path.GetFullPath(_cfg.SourceProject, ConfigurationDirectory);
        _srcProject = solution
            .Projects.Where(x => x.FilePath is not null)
            .FirstOrDefault(x =>
                Path.GetFullPath(x.FilePath!, ConfigurationDirectory) == projectFile
            );
        if (_srcProject is null)
        {
            throw new InvalidOperationException("Failed to locate source project.");
        }

        // Wipe the slate clean. The generator should only be able to see generated code.
        // TODO maybe one day we'll lift this restriction? I couldn't think of a reason not to have it, but there's also not many to have it.
        SourceProject = _srcProject.RemoveDocuments([.. _srcProject.DocumentIds]);
        solution = _srcProject.Solution;
        if (_cfg.TestProject is not null)
        {
            var testProjectFile = Path.GetFullPath(_cfg.TestProject, ConfigurationDirectory);
            _testProject = solution
                .Projects.Where(x => x.FilePath is not null)
                .FirstOrDefault(x =>
                    Path.GetFullPath(x.FilePath!, ConfigurationDirectory) == testProjectFile
                );
            TestProject = _testProject?.RemoveDocuments([.. _testProject.DocumentIds]);
            solution = _testProject?.Solution ?? solution;
        }
    }

    private string ObtainCacheKey()
    {
        // Obtain a cache key for the job, should the mods want to cache any artifacts.
        var cacheKey = string.Join(',', cfg.AsEnumerable().OrderBy(x => x.Key));
        logger.LogDebug("Cache key for job (before hashing): {}", cacheKey);
        return Convert.ToHexString(XxHash64.Hash(Encoding.UTF8.GetBytes(cacheKey)));
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
        var defaultLicenseHeaderTrivia = _cfg?.DefaultLicenseHeader is null
            ? null
            : (await File.ReadAllLinesAsync(_cfg.DefaultLicenseHeader))
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
        var result = await CodeFormatter.FormatAsync(
            root.NormalizeWhitespace().SyntaxTree,
            _opts,
            ct
        );
        return !result.CompilationErrors.Any()
            ? result.Code
            : root.NormalizeWhitespace(eol: "\n").ToFullString();
    }
}
