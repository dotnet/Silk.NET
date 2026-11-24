// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// Resolves a path in a SilkTouch configuration to its canonical path on the host file system. This allows for multiple
/// <see cref="IInputSource"/>s with varying behaviour e.g. a NuGet resolver that resolves paths starting with nuget://
/// </summary>
public interface IInputResolver
{
    /// <summary>
    /// Resolves the input path to its canonical host file system path, returning null if resolution failed.
    /// </summary>
    /// <param name="path">The path input.</param>
    /// <returns>The resolved path asynchronously.</returns>
    public Task<string?> TryResolvePath(string path);

    /// <summary>
    /// Resolves the input path to its canonical host file system path, returning the original path if resolution failed.
    /// </summary>
    /// <param name="path">The path input.</param>
    /// <returns>The resolved path asynchronously.</returns>
    public async Task<string> ResolvePathAsync(string path) =>
        (await TryResolvePath(path))?.Replace('\\', '/') ?? path;

    /// <summary>
    /// Resolves all of the paths referenced in the given response file in place.
    /// </summary>
    /// <param name="rsps">The response files.</param>
    /// <returns>An asynchronous task.</returns>
    public async Task ResolveInPlaceAsync(IList<ResponseFile> rsps)
    {
        // Resolve any foreign paths
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            var files = rsp.Files.ToArray();
            for (var j = 0; j < files.Length; j++)
            {
                files[j] = await ResolvePathAsync(files[j]);
            }

            for (var j = 0; j < rsp.ClangCommandLineArgs.Length; j++)
            {
                var arg = rsp.ClangCommandLineArgs[j];
                if (arg is "--include-directory" or "-I")
                {
                    for (var k = j; k < rsp.ClangCommandLineArgs.Length; k++)
                    {
                        if (rsp.ClangCommandLineArgs[k][0] == '-')
                        {
                            break;
                        }
                        rsp.ClangCommandLineArgs[k] = await ResolvePathAsync(
                            rsp.ClangCommandLineArgs[k]
                        );
                        j++;
                    }
                }
                else if (arg.StartsWith("--include-directory"))
                {
                    rsp.ClangCommandLineArgs[j] =
                        "--include-directory="
                        + await ResolvePathAsync(
                            arg["--include-directory".Length..].TrimStart('=')
                        );
                }
                else if (arg.StartsWith("-I"))
                {
                    rsp.ClangCommandLineArgs[j] =
                        "-I" + await ResolvePathAsync(arg["-I".Length..].TrimStart('='));
                }
            }

            var traversals = rsp.GeneratorConfiguration.TraversalNames.ToArray();
            for (var j = 0; j < traversals.Length; j++)
            {
                traversals[j] = await ResolvePathAsync(traversals[j]);
            }

            rsps[i] = rsp with
            {
                Files = files,
                FileDirectory =
                    (await TryResolvePath(rsp.FileDirectory))?.Replace('\\', '/')
                    ?? rsp.FileDirectory,
                ClangCommandLineArgs = rsp.ClangCommandLineArgs,
                GeneratorConfiguration = rsp.GeneratorConfiguration.ToWrapper() with
                {
                    OutputLocation = await ResolvePathAsync(
                        rsp.GeneratorConfiguration.OutputLocation
                    ),
                    TraversalNames = traversals,
                    TestOutputLocation = await ResolvePathAsync(
                        rsp.GeneratorConfiguration.TestOutputLocation
                    ),
                },
            };
        }
    }

    /// <summary>
    /// Resolves the paths in the given array in-place.
    /// </summary>
    /// <param name="files">The paths to resolve.</param>
    public async Task ResolveInPlaceAsync(IList<string> files)
    {
        for (var i = 0; i < files.Count; i++)
        {
            files[i] = await ResolvePathAsync(files[i]);
        }
    }

    /// <summary>
    /// Resolves all paths referenced in the given configuration.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <returns>The configuration with all paths resolved.</returns>
    public async Task<ClangScraper.Configuration> ResolveAsync(ClangScraper.Configuration config)
    {
        await ResolveInPlaceAsync(config.ClangSharpResponseFiles);
        foreach (var (k, v) in config.ManualOverrides ?? [])
        {
            config.ManualOverrides![k] = await ResolvePathAsync(v);
        }

        return config with
        {
            InputSourceRoot = config.InputSourceRoot is null
                ? null
                : await ResolvePathAsync(config.InputSourceRoot),
            InputTestRoot = config.InputTestRoot is null
                ? null
                : await ResolvePathAsync(config.InputTestRoot),
        };
    }

    /// <summary>
    /// Resolves all paths referenced in the given job configuration.
    /// </summary>
    /// <param name="config">The job config.</param>
    /// <returns>The job config with all paths resolved.</returns>
    public async Task<SilkTouchConfiguration> ResolveAsync(SilkTouchConfiguration config) =>
        config with
        {
            SourceProject = await ResolvePathAsync(config.SourceProject),
            TestProject = config.TestProject is null
                ? null
                : await ResolvePathAsync(config.TestProject),
        };
}
