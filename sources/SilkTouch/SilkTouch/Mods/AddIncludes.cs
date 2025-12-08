using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will add standard include directories and any other user-provided include paths to a response file that
/// doesn't already have them (i.e. that doesn't depend on the exact location/version of said standard includes)
/// </summary>
/// <param name="stdResolver">The standard include resolver.</param>
/// <param name="inputResolver">The user path input resolver.</param>
/// <param name="options">The mod configuration options snapshot.</param>
[ModConfiguration<Configuration>]
public class AddIncludes(
    IStdIncludeResolver stdResolver,
    IInputResolver inputResolver,
    IOptionsSnapshot<AddIncludes.Configuration> options
) : IMod, IResponseFileMod
{
    /// <summary>
    /// The mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Don't add standard includes.
        /// </summary>
        public bool SuppressStdIncludes { get; init; }

        /// <summary>
        /// Keep missing include directories.
        /// </summary>
        public bool KeepMissingIncludes { get; init; }

        /// <summary>
        /// Remove the include directories matching the contained globs.
        /// </summary>
        public string[]? RemoveMatchingIncludes { get; init; }

        /// <summary>
        /// Directories to add before the other defined include directories.
        /// </summary>
        public string[]? PriorityIncludes { get; init; }

        /// <summary>
        /// Directories to add after the other defined include directories.
        /// </summary>
        public string[]? AdditionalIncludes { get; init; }
    }

    /// <inheritdoc />
    public async Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        var cfg = options.Get(key);
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            var cmdLineArgs = rsp.ClangCommandLineArgs.ToList();

            cmdLineArgs.InsertRange(0, cfg.PriorityIncludes?.Select(x => $"--include-directory={x}") ?? []);
            cmdLineArgs.AddRange(cfg.AdditionalIncludes?.Select(x => $"--include-directory={x}") ?? []);

            if (!cfg.SuppressStdIncludes)
            {
                cmdLineArgs.AddRange(stdResolver.GetStandardIncludes());
            }

            var matcher = new Matcher();
            matcher.AddIncludePatterns(cfg.RemoveMatchingIncludes?.Where(x => x[0] != '!') ?? []);
            matcher.AddExcludePatterns(cfg.RemoveMatchingIncludes?.Where(x => x[0] == '!') ?? []);
            for (var j = 0; j < cmdLineArgs.Count; j++)
            {
                string? path = null;
                var arg = cmdLineArgs[j];
                if (arg is "--include-directory" or "-I")
                {
                    for (var k = j; k < cmdLineArgs.Count; k++)
                    {
                        if (cmdLineArgs[k][0] == '-')
                        {
                            break;
                        }

                        path = await inputResolver.ResolvePath(cmdLineArgs[k]);
                        j++;
                    }
                }
                else if (arg.StartsWith("--include-directory"))
                {
                    path = await inputResolver.ResolvePath(
                        arg["--include-directory".Length..].TrimStart('=')
                    );
                }
                else if (arg.StartsWith("-I"))
                {
                    path = await inputResolver.ResolvePath(arg["-I".Length..].TrimStart('='));
                }

                if (path is null)
                {
                    continue;
                }

                path = Path.GetFullPath(path, rsp.FileDirectory);
                if (
                    (!Directory.Exists(path) && !cfg.KeepMissingIncludes)
                    || (
                        cfg.RemoveMatchingIncludes is { Length: > 0 }
                        && matcher.Match(path).HasMatches
                    )
                )
                {
                    cmdLineArgs.RemoveAt(j--);
                }
            }

            rsps[i] = rsp with { ClangCommandLineArgs = cmdLineArgs.ToArray() };
        }

        return rsps;
    }

    /// <inheritdoc />
    public Task ExecuteAsync(IModContext ctx, CancellationToken ct = default) => Task.CompletedTask;
}
