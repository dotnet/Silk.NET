using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Silk.NET.SilkTouch.Workspace;

/// <summary>
/// Default implementation of <see cref="IWorkspaceSolutionProvider"/>.
/// </summary>
public class WorkspaceSolutionProvider
    : IWorkspaceSolutionProvider,
        IDisposable,
        IProgress<ProjectLoadProgress>
{
    private readonly Microsoft.Build.Framework.ILogger _msBuildLogger;
    private readonly ILogger<WorkspaceSolutionProvider> _logger;
    private readonly IOptionsSnapshot<SilkTouchConfiguration> _config;

    // Because we need to use async for populating this dictionary, we can't use ConcurrentDictionary here.
    private readonly Dictionary<
        string,
        (MSBuildWorkspace Workspace, Solution Solution, SemaphoreSlim WriteSemaphore)
    > _workspace = new();
    private readonly SemaphoreSlim _workspaceSemaphore = new(1, 1);

    /// <summary>
    /// Creates a solution provider with the given logger and config.
    /// </summary>
    /// <param name="logger">Logger.</param>
    /// <param name="config">Config.</param>
    /// <param name="msBuildLogger">MSBuild logger.</param>
    public WorkspaceSolutionProvider(
        ILogger<WorkspaceSolutionProvider> logger,
        IOptionsSnapshot<SilkTouchConfiguration> config,
        Microsoft.Build.Framework.ILogger msBuildLogger
    ) => (_logger, _config, _msBuildLogger) = (logger, config, msBuildLogger);

    /// <inheritdoc />
    public async Task<bool> ApplyChangesAsync(
        string key,
        Func<MSBuildWorkspace, Solution, Task<Solution>> applyChanges
    )
    {
        var fullPath = Path.GetFullPath(_config.Get(key).Solution).Replace('\\', '/').TrimEnd('/');
        await _workspaceSemaphore.WaitAsync();
        if (!_workspace.TryGetValue(fullPath, out var entry))
        {
            var workspace = MSBuildWorkspace.Create();
            var solution = await workspace.OpenSolutionAsync(fullPath, _msBuildLogger, this);
            entry = _workspace[fullPath] = (workspace, solution, new SemaphoreSlim(1, 1));
        }
        _workspaceSemaphore.Release();
        await entry.WriteSemaphore.WaitAsync();
        entry.Solution = await applyChanges(entry.Workspace, entry.Solution);
        var ret = entry.Workspace.TryApplyChanges(entry.Solution);
        if (ret)
        {
            _workspace[fullPath] = entry;
        }
        entry.WriteSemaphore.Release();
        return ret;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        foreach (var (_, (ws, _, _)) in _workspace)
        {
            ws.Dispose();
        }
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc />
    public void Report(ProjectLoadProgress value) =>
        _logger.LogDebug(
            "{0}: {1}({2}) - elapsed {3}",
            value.Operation,
            value.FilePath,
            value.TargetFramework,
            value.ElapsedTime
        );
}
