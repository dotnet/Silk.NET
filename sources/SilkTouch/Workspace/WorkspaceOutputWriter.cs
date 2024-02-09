using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Workspace;

/// <summary>
/// An <see cref="IOutputWriter"/> that uses an MSBuild workspace to output the files.
/// </summary>
/// <remarks>
/// This currently has the unfortunate issue wherein Roslyn's workspaces integration requires adding a file-specific
/// ItemGroup entry and often adds duplicates that messes with some tooling. Therefore, it is no longer the default.
/// This does mean that workspace-specific mods aren't available unless this output writer is used.
/// </remarks>
public class WorkspaceOutputWriter : IOutputWriter
{
    private IWorkspaceSolutionProvider _workspaceProvider;
    private ILogger<WorkspaceOutputWriter> _logger;
    private IEnumerable<IMod> _mods;

    /// <summary>
    /// Creates a <see cref="WorkspaceOutputWriter"/> with the given logger and workspace provider.
    /// </summary>
    /// <param name="logger">The logger.</param>
    /// <param name="slnProvider">The workspace/solution provider.</param>
    /// <param name="mods">The mods (for workspace-level mods).</param>
    public WorkspaceOutputWriter(
        ILogger<WorkspaceOutputWriter> logger,
        IWorkspaceSolutionProvider slnProvider,
        IEnumerable<IMod> mods
    ) => (_logger, _workspaceProvider, _mods) = (logger, slnProvider, mods);

    /// <inheritdoc />
    public async Task OutputAsync(
        string key,
        SilkTouchConfiguration job,
        GeneratedSyntax syntax,
        CancellationToken ct = default
    )
    {
        (string, string)? srcDeps = null;
        (string, string)? tstDeps = null;
        _logger.LogInformation("Loading workspace for {0}'s solution ({1})...", key, job.Solution);
        var applied = await _workspaceProvider.ApplyChangesAsync(
            key,
            async (workspace, sln) =>
            {
                // Try and find the project for the source output
                var (_, tmpSrcProj, srcFiles) = await FindAndPrepareProjectAsync(
                    sln,
                    job.OutputSourceRoot,
                    "sources/",
                    syntax,
                    null,
                    ct
                );
                // Try and find the project for the test output
                var (srcProj, tstProj, tstFiles) = await FindAndPrepareProjectAsync(
                    sln,
                    job.OutputTestRoot,
                    "tests/",
                    syntax,
                    tmpSrcProj,
                    ct
                );
                // Run mods
                // ReSharper disable NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
                var genWorkspace = new GeneratorWorkspace(
                    workspace,
                    srcProj,
                    tstProj,
                    srcFiles ?? Array.Empty<string>(),
                    tstFiles ?? Array.Empty<string>()
                );
                // ReSharper restore NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var mod in _mods)
                {
                    _logger.LogInformation(
                        "Applying {0} mod to workspace for {1}...",
                        mod.GetType().Name,
                        key
                    );
                    genWorkspace = await mod.BeforeOutputAsync(key, genWorkspace);
                }

                // Update the file lists post-modding
                if (genWorkspace is { SourceProject: not null } && srcFiles is not null)
                {
                    srcFiles = RecreateFileList(srcProj!, genWorkspace.SourceProject, srcFiles);
                    srcProj = genWorkspace.SourceProject;
                    if (srcProj.FilePath is not null)
                    {
                        //srcCsprojContents = (srcProj.FilePath, await File.ReadAllTextAsync(srcProj.FilePath, ct));
                    }
                }
                if (genWorkspace is { TestProject: not null } && tstFiles is not null)
                {
                    tstFiles = RecreateFileList(tstProj!, genWorkspace.TestProject, tstFiles);
                    tstProj = genWorkspace.TestProject;
                    if (tstProj.FilePath is not null)
                    {
                        //tstCsprojContents = (tstProj.FilePath, await File.ReadAllTextAsync(tstProj.FilePath, ct));
                    }
                }

                // ReSharper disable ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
                if (
                    srcProj is not null
                    && tstProj is not null
                    && srcProj.Solution != tstProj.Solution
                )
                {
                    throw new InvalidOperationException(
                        "After modding, the source and test projects come from different solutions!"
                    );
                }
                // ReSharper restore ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
                if (srcFiles?.Count > 0)
                {
                    srcDeps = (
                        Path.Combine(job.OutputSourceRoot!, ".silktouch.d"),
                        DepsFile.Create(Enumerable.Empty<string>(), srcFiles)
                    );
                }
                if (tstFiles?.Count > 0)
                {
                    tstDeps = (
                        Path.Combine(job.OutputTestRoot!, ".silktouch.d"),
                        DepsFile.Create(Enumerable.Empty<string>(), tstFiles)
                    );
                }
                _logger.LogInformation(
                    "Applying changes to workspace for {0}, please wait...",
                    key
                );
                return srcProj?.Solution ?? tstProj?.Solution ?? sln;
            }
        );

        if (applied)
        {
            _logger.LogInformation("{0} processed successfully", key);
            // // HACK: Restore the original csproj contents. https://github.com/dotnet/roslyn/issues/36781
            // if (srcCsprojContents is not null)
            // {
            //     await File.WriteAllTextAsync(srcCsprojContents.Value.Item1, srcCsprojContents.Value.Item2, ct);
            // }
            // if (tstCsprojContents is not null)
            // {
            //     await File.WriteAllTextAsync(tstCsprojContents.Value.Item1, tstCsprojContents.Value.Item2, ct);
            // }
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
    }

    private async Task<(Project?, Project?, IReadOnlyList<string>)> FindAndPrepareProjectAsync(
        Solution sln,
        string? srcRoot,
        string label,
        GeneratedSyntax syntax,
        Project? ogSrcProj = null,
        CancellationToken ct = default,
        [CallerArgumentExpression(nameof(srcRoot))] string property = ""
    )
    {
        if (string.IsNullOrWhiteSpace(srcRoot))
        {
            _logger.LogWarning(
                "Not outputting {0} files due to {1} being omitted.",
                label.TrimEnd('/'),
                property
            );
            return (ogSrcProj, null, Array.Empty<string>());
        }

        srcRoot = Path.GetFullPath(srcRoot);

        // Try and find the project for the source output
        var srcProj = sln
            .Projects.Where(x => x.FilePath is not null)
            .FirstOrDefault(x =>
                Path.GetDirectoryName(Path.GetFullPath(x.FilePath!))
                    ?.Replace('\\', '/')
                    .TrimEnd('/') == Path.GetFullPath(srcRoot).Replace('\\', '/').TrimEnd('/')
            );
        if (srcProj is null)
        {
            _logger.LogWarning(
                "Couldn't find project in solution matching {0} output directory, not outputting {1}.",
                label.TrimEnd('/'),
                label
            );
            return (ogSrcProj, null, Array.Empty<string>());
        }

        // Remove the old generated files if applicable
        var file = Path.Combine(srcRoot, ".silktouch.d");
        if (File.Exists(file))
        {
            _logger.LogTrace("Removing old documents per .silktouch.d...");
            var (_, oldFiles) = DepsFile.Parse(await File.ReadAllTextAsync(file, ct));
            oldFiles = oldFiles
                .Select(x => Path.GetFullPath(x, srcRoot).Replace('\\', '/'))
                .ToArray();
            srcProj = srcProj.RemoveDocuments(
                srcProj
                    .Documents.Where(x =>
                    {
                        if (x.FilePath is null)
                        {
                            return false;
                        }

                        var fx = Path.GetFullPath(x.FilePath, srcRoot).Replace('\\', '/');
                        return !fx.StartsWith("../") && oldFiles.Contains(fx);
                    })
                    .Select(x => x.Id)
                    .ToImmutableArray()
            );
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
            _logger.LogTrace("Adding {}...", trimmedPath);
            var doc = srcProj.AddDocument(trimmedPath, await syntaxNode.ToNormalisedString(ct));
            files.Add(trimmedPath);
            srcProj = doc.Project;
        }

        var newSrcProj = ogSrcProj is null
            ? null
            : srcProj.Solution.Projects.First(x => x.Id == ogSrcProj.Id);
        return (newSrcProj, srcProj, files.ToArray());
    }

    private IReadOnlyList<string> RecreateFileList(
        Project originalProject,
        Project newProject,
        IReadOnlyList<string> oldFileList
    )
    {
        // TODO might need to do more work here, feels too easy...
        var baseFiles = originalProject
            .Documents.Where(x => !oldFileList.Contains(x.Name))
            .Select(x => x.Name)
            .ToHashSet();
        var newFiles = newProject.Documents.Where(x => !baseFiles.Contains(x.Name));
        return newFiles.Select(x => x.Name).ToArray();
    }
}
