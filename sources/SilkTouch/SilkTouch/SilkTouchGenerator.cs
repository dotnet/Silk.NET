// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Autofac;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
public class SilkTouchGenerator : IDisposable
{
    private readonly ILifetimeScope container;

    private readonly string _jobKey;
    private SilkTouchConfiguration _jobConfig;
    private readonly ILogger<SilkTouchGenerator> _logger;
    private readonly IInputResolver _inputResolver;

    /// <summary>
    /// Gets the loaded mods for this generator instance.
    /// </summary>
    public IReadOnlyList<IMod> Mods { get; }

    /// <summary>
    /// The main entry-point class for SilkTouch.
    /// </summary>
    /// <param name="jobKey"></param>
    /// <param name="jobConfig"></param> // TODO
    /// <param name="parentContainer"></param>
    /// <param name="build"></param>
    public SilkTouchGenerator(
        string jobKey,
        SilkTouchConfiguration jobConfig,
        ILifetimeScope parentContainer,
        Action<ContainerBuilder> build
    )
    {
        _logger = parentContainer.Resolve<ILogger<SilkTouchGenerator>>();
        _inputResolver = parentContainer.Resolve<IInputResolver>();

        // TODO: Maybe have each mod provide a Register(ILifetimeScope container, Mod.Configuration configuration) method
        container = parentContainer.BeginLifetimeScope(build);

        _jobKey = jobKey;
        _jobConfig = jobConfig;
        Mods = container.Resolve<IMod[]>();
    }

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    public async Task RunAsync(CancellationToken ct = default)
    {
        var sw = Stopwatch.StartNew();

        // Resolve any relative paths in the job configuration.
        _jobConfig = await _inputResolver.Resolve(_jobConfig);

        // Prepare the context
        var context = new MSBuildModContext(_jobKey, _jobConfig, _logger);

        // Just in case a mod gets naughty and tries to modify at the initialization stage.
        var srcProj = context.SourceProject;
        var testProj = context.TestProject;

        // Initialize the mods
        foreach (var mod in Mods)
        {
            _logger.LogDebug("Using mod {0} for {1}", mod.GetType().Name, _jobKey);
            await mod.InitializeAsync(context, ct);
            if (context.SourceProject != srcProj || context.TestProject != testProj)
            {
                throw new InvalidOperationException(
                    $"{mod.GetType().Name} illegally generated code at the initialization stage."
                );
            }
        }

        foreach (var mod in Mods)
        {
            _logger.LogInformation("Executing {} for {}...", mod.GetType().Name, _jobKey);
            await mod.ExecuteAsync(context, ct);
        }

        // Manually dispose so that we don't do this when generation fails (await using is too clever).
        await context.DisposeAsync();

        // Output the generated bindings
        _logger.LogInformation(
            "Bindings generation for {} completed in {} seconds.",
            _jobKey,
            sw.Elapsed.TotalSeconds
        );
    }

    // TODO: Why is this here?
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
        var ret = GetLongestCommonPrefix(
            s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray()
        );
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }

    public void Dispose() => container.Dispose();
}
