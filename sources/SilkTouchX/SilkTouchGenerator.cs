using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using SilkTouchX.Clang;
using SilkTouchX.Mods;
using SilkTouchX.Workspace;
using Diagnostic = ClangSharp.Diagnostic;

namespace SilkTouchX;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
public class SilkTouchGenerator
{
    private readonly IReadOnlyList<IMod> _mods;
    private readonly ClangScraper _scraper;
    private readonly ResponseFileHandler _rspHandler;
    private readonly ILogger<SilkTouchGenerator> _logger;
    private readonly IWorkspaceSolutionProvider _workspaceProvider;

    /// <summary>
    /// Creates an instance with the given underlying scraper, response file handler, and logger.
    /// </summary>
    /// <param name="scraper">The scraper.</param>
    /// <param name="rspHandler">The response file handler.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="mods">The mods to use.</param>
    /// <param name="workspaceProvider">The MSBuild workspace/solution provider.</param>
    public SilkTouchGenerator(ClangScraper scraper,
        ResponseFileHandler rspHandler,
        ILogger<SilkTouchGenerator> logger,
        IEnumerable<IMod> mods,
        IWorkspaceSolutionProvider workspaceProvider)
        => (_scraper, _rspHandler, _logger, _mods, _workspaceProvider) =
            (scraper, rspHandler, logger, mods.ToArray(), workspaceProvider);

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="job">The configuration.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    /// <returns>The generated bindings' syntax trees.</returns>
    public async Task<GeneratedSyntax> GenerateSyntaxAsync(string key,
        SilkTouchConfiguration job,
        CancellationToken ct = default)
    {
        // Prepare the mods
        foreach (var mod in _mods)
        {
            _logger.LogDebug("Using mod {0} for {1}", mod.GetType().Name, key);
            await mod.BeforeJobAsync(key, job);
        }

        // Read the response files
        var rsps = job.ClangSharpResponseFiles.SelectMany(file =>
                _rspHandler.ReadResponseFiles(file, job.ClangSharpResponseFiles))
            .ToList();

        // Figure out what the common root is so we can aggregate the file paths without collisions
        var srcRoot = job.InputSourceRoot ?? GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.OutputLocation));
        var testRoot = job.InputTestRoot ??
                       GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.TestOutputLocation));
        srcRoot = Path.GetFullPath(srcRoot);
        testRoot = Path.GetFullPath(testRoot);

        // Mod the response files
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in _mods)
        {
            rsps = await mod.BeforeScrapeAsync(key, rsps);
        }

        // Run the scraper over the response files
        var aggregatedBindings = new ConcurrentDictionary<string, Stream>();
        var aggregatedDiagnostics = new ConcurrentBag<Diagnostic>();
        await Parallel.ForEachAsync(rsps, ct, async (rsp, innerCt) => await Task.Run(() => {
            var rawBindings = _scraper.ScrapeRawBindings(rsp);
            foreach (var (k, v) in rawBindings.Files)
            {
                string relativeKey;
                if (k.StartsWith("sources/"))
                {
                    relativeKey =
                        Path.Combine(
                            "sources",
                            Path.GetRelativePath(srcRoot, rsp.GeneratorConfiguration.OutputLocation),
                            k[8..]);
                }
                else if (k.StartsWith("tests/"))
                {
                    relativeKey =
                        Path.Combine(
                            "tests",
                            Path.GetRelativePath(testRoot, rsp.GeneratorConfiguration.TestOutputLocation),
                            k[6..]);
                }
                else
                {
                    throw new InvalidOperationException("Bad scraper output keys.");
                }

                relativeKey = relativeKey.Replace('\\', '/').TrimEnd('/');
                if (!aggregatedBindings.TryAdd(relativeKey, v))
                {
                    _logger.LogError("Failed to add {0} - are the response file outputs conflicting?", relativeKey);
                }
                else
                {
                    _logger.LogTrace("ClangSharp generated {0}", relativeKey);
                }
            }

            foreach (var diag in rawBindings.Diagnostics)
            {
                aggregatedDiagnostics.Add(diag);
            }
        }, innerCt));

        // Read the bindings as syntax trees
        var syntaxTrees = aggregatedBindings.ToDictionary(kvp => kvp.Key,
            kvp => CSharpSyntaxTree.ParseText(SourceText.From(kvp.Value)).GetRoot());
        aggregatedBindings.Clear(); // GC ASAP
        var bindings = new GeneratedSyntax(syntaxTrees, aggregatedDiagnostics.ToList());

        // Mod the bindings
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in _mods)
        {
            bindings = await mod.AfterScrapeAsync(key, bindings);
        }

        // Output the generated bindings
        return bindings;
    }

    /// <summary>
    /// Generates bindings and stores them in memory-mapped file streams.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="job">The generation configuration.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    /// <returns>The generated bindings as memory-mapped streams.</returns>
    public async Task<GeneratedBindings> GenerateBindingsAsync(string key,
        SilkTouchConfiguration job,
        CancellationToken ct = default)
    {
        var result = await GenerateSyntaxAsync(key, job, ct);
        return new GeneratedBindings(result.Files.ToDictionary(x => x.Key, x => {
            // Create a temporary stream - this will be copied into a mmap later to ensure that we don't eat RAM
            using var ms = new MemoryStream();
            using var sw = new StreamWriter(ms);
            x.Value.NormalizeWhitespace(eol: "\n").WriteTo(sw);
            sw.Flush();
            ms.Seek(0, SeekOrigin.Begin);

            // Create a memory-mapped file
            var mmf = MemoryMappedFile.CreateNew(null, ms.Length);
            using var stream = mmf.CreateViewStream();
            ms.CopyTo(stream);
            stream.Flush();

            // Return a read-only stream to ensure noone tries to write to it directly
            return (Stream)mmf.CreateViewStream(0, ms.Length, MemoryMappedFileAccess.Read);
        }), result.Diagnostics);
    }

    /// <summary>
    /// Generates bindings and outputs them in accordance to the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="job">The generation configuration.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    public async Task<IReadOnlyList<Diagnostic>> OutputBindingsAsync(string key,
        SilkTouchConfiguration job,
        CancellationToken ct = default)
    {
        // Generate syntax
        var result = await GenerateSyntaxAsync(key, job, ct);

        // Add syntax to workspace & apply mods
        (string, string)? srcCsprojContents = null;
        (string, string)? tstCsprojContents = null;
        (string, string)? srcDeps = null;
        (string, string)? tstDeps = null;
        var applied = await _workspaceProvider.ApplyChangesAsync(key, async (workspace, sln) => {
            // Try and find the project for the source output
            var (_, tmpSrcProj, srcFiles) =
                await FindAndPrepareProjectAsync(sln, job.OutputSourceRoot, "sources/", result, null, ct);
            // Try and find the project for the test output
            var (srcProj, tstProj, tstFiles) =
                await FindAndPrepareProjectAsync(sln, job.OutputTestRoot, "tests/", result, tmpSrcProj, ct);
            // Run mods
            // ReSharper disable NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            var genWorkspace = new GeneratorWorkspace(workspace, srcProj, tstProj, srcFiles ?? Array.Empty<string>(),
                tstFiles ?? Array.Empty<string>());
            // ReSharper restore NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var mod in _mods)
            {
                genWorkspace = await mod.BeforeOutputAsync(key, genWorkspace);
            }

            // Update the file lists post-modding
            if (genWorkspace is { SourceProject: not null } && srcFiles is not null)
            {
                srcFiles = RecreateFileList(srcProj!, genWorkspace.SourceProject, srcFiles);
                srcProj = genWorkspace.SourceProject;
                if (srcProj.FilePath is not null)
                {
                    srcCsprojContents = (srcProj.FilePath, await File.ReadAllTextAsync(srcProj.FilePath, ct));
                }
            }
            if (genWorkspace is { TestProject: not null } && tstFiles is not null)
            {
                tstFiles = RecreateFileList(tstProj!, genWorkspace.TestProject, tstFiles);
                tstProj = genWorkspace.TestProject;
                if (tstProj.FilePath is not null)
                {
                    tstCsprojContents = (tstProj.FilePath, await File.ReadAllTextAsync(tstProj.FilePath, ct));
                }
            }

            // ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (srcProj is not null && tstProj is not null && srcProj.Solution != tstProj.Solution)
            {
                throw new InvalidOperationException(
                    "After modding, the source and test projects come from different solutions!");
            }
            // ReSharper restore ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (srcFiles?.Count > 0)
            {
                srcDeps = (Path.Combine(job.OutputSourceRoot!, ".silktouch.d"),
                    DepsFile.Create(Enumerable.Empty<string>(), srcFiles));
            }
            if (tstFiles?.Count > 0)
            {
                tstDeps = (Path.Combine(job.OutputTestRoot!, ".silktouch.d"),
                    DepsFile.Create(Enumerable.Empty<string>(), tstFiles));
            }
            return srcProj?.Solution ?? tstProj?.Solution ?? sln;
        });

        if (applied)
        {
            _logger.LogInformation("{0} processed successfully", key);
            // HACK: Restore the original csproj contents. https://github.com/dotnet/roslyn/issues/36781
            if (srcCsprojContents is not null)
            {
                await File.WriteAllTextAsync(srcCsprojContents.Value.Item1, srcCsprojContents.Value.Item2, ct);
            }
            if (tstCsprojContents is not null)
            {
                await File.WriteAllTextAsync(tstCsprojContents.Value.Item1, tstCsprojContents.Value.Item2, ct);
            }
            if (srcDeps is not null)
            {
                await File.WriteAllTextAsync(srcDeps.Value.Item1, srcDeps.Value.Item2, ct);
            }
            if (tstDeps is not null)
            {
                await File.WriteAllTextAsync(tstDeps.Value.Item1, tstDeps.Value.Item2, ct);
            }
        }
        else
        {
            _logger.LogError("Failed to apply changes to workspace for {0}!", key);
            // TODO diag?
        }

        return result.Diagnostics;
    }

    private async Task<(Project?, Project?, IReadOnlyList<string>)> FindAndPrepareProjectAsync(Solution sln,
        string? srcRoot,
        string label,
        GeneratedSyntax syntax,
        Project? ogSrcProj = null,
        CancellationToken ct = default,
        [CallerArgumentExpression(nameof(srcRoot))]
        string property = "")
    {
        if (string.IsNullOrWhiteSpace(srcRoot))
        {
            _logger.LogWarning("Not outputting {0} files due to {1} being omitted.", label.TrimEnd('/'), property);
            return (ogSrcProj, null, Array.Empty<string>());
        }

        // Try and find the project for the source output
        var srcProj = sln.Projects.Where(x => x.FilePath is not null).FirstOrDefault(x =>
            Path.GetDirectoryName(Path.GetFullPath(x.FilePath!))?.Replace('\\', '/').TrimEnd('/') ==
            Path.GetFullPath(srcRoot).Replace('\\', '/').TrimEnd('/'));
        if (srcProj is null)
        {
            _logger.LogWarning(
                "Couldn't find project in solution matching {0} output directory, not outputting {1}.",
                label.TrimEnd('/'), label);
            return (ogSrcProj, null, Array.Empty<string>());
        }

        // Remove the old generated files if applicable
        var file = Path.Combine(srcRoot, ".silktouch.d");
        if (File.Exists(file))
        {
            var (_, oldFiles) = DepsFile.Parse(await File.ReadAllTextAsync(file, ct));
            oldFiles = oldFiles.Select(x => Path.GetFullPath(x, srcRoot)
                    .Replace('\\', '/'))
                .ToArray();
            srcProj = srcProj.RemoveDocuments(srcProj.Documents
                .Where(x => {
                    if (x.FilePath is null)
                    {
                        return false;
                    }

                    var fx = Path.GetFullPath(x.FilePath, srcRoot)
                        .Replace('\\', '/');
                    return !fx.StartsWith("../") && oldFiles.Contains(fx);
                })
                .Select(x => x.Id)
                .ToImmutableArray());
        }

        // Add new files
        var files = new List<string>();
        foreach (var (path, syntaxNode) in syntax.Files)
        {
            if (!path.StartsWith(label))
            {
                continue;
            }

            var trimmedPath = path[label.Length..];
            var doc = srcProj.AddDocument(trimmedPath, syntaxNode);
            files.Add(trimmedPath);
            srcProj = doc.Project;
        }

        var newSrcProj = ogSrcProj is null ? null : srcProj.Solution.Projects.First(x => x.Id == ogSrcProj.Id);
        return (newSrcProj, srcProj, files.ToArray());
    }

    private IReadOnlyList<string> RecreateFileList(Project originalProject,
        Project newProject,
        IReadOnlyList<string> oldFileList)
    {
        // TODO might need to do more work here, feels too easy...
        var baseFiles = originalProject.Documents.Where(x => !oldFileList.Contains(x.Name)).Select(x => x.Name).ToHashSet();
        var newFiles = newProject.Documents.Where(x => !baseFiles.Contains(x.Name));
        return newFiles.Select(x => x.Name).ToArray();
    }

    internal static string GetLongestCommonPrefix(string[] s)
    {
        var k = s[0].Length;
        for (var i = 1; i < s.Length; i++)
        {
            k = Math.Min(k, s[i].Length);
            for (var j = 0; j < k; j++)
            {
                if (s[i][j] == s[0][j])
                {
                    continue;
                }

                k = j;
                break;
            }
        }
        return s[0][..k];
    }

    internal static string GetLongestCommonPath(IEnumerable<string> s)
    {
        var ret = GetLongestCommonPrefix(s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray());
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }
}
