using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A macOS standard include resolver.
/// </summary>
public class MacOSStdIncludeResolver : UnixStdIncludeResolver
{
    private readonly ILogger<MacOSStdIncludeResolver> _logger;

    /// <summary>
    /// Creates this include resolver with the given logger.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public MacOSStdIncludeResolver(ILogger<MacOSStdIncludeResolver> logger) => _logger = logger;

    /// <inheritdoc />
    protected override IEnumerable<string> CoreGetStandardIncludes()
    {
        foreach (var inc in base.CoreGetStandardIncludes())
        {
            yield return inc;
        }

        var sdkPath = GetXCodeSdkPath();
        _logger.LogTrace("Using SDK {sdk} as base", sdkPath); // TODO iOS profile?
        yield return $"-isysroot{sdkPath}";
        var p1 = Path.Combine(sdkPath, "usr/include");
        _logger.LogTrace("Suggesting additional path {path}", p1);
        yield return $"-isystem{p1}";
        var p2 = Path.Combine(sdkPath, "usr/local/include");
        _logger.LogTrace("Suggesting additional path {path}", p2);
        yield return $"-isystem{p2}";
        var maybeToolchain = Path.Combine(
            sdkPath,
            "../../../../../Toolchains/XcodeDefault.xctoolchain/usr/lib/clang"
        );
        var toolchainClangDir = new DirectoryInfo(maybeToolchain);
        _logger.LogTrace("Assuming default toolchain of {}", toolchainClangDir.FullName);
        if (
            toolchainClangDir.Exists
            && toolchainClangDir
                .GetDirectories()
                .Select(x => (x, Version.TryParse(x.Name, out var v) ? v : null))
                .Where(x => x.Item2 is not null)
                .OrderByDescending(x => x.Item2)
                .FirstOrDefault()
                is { x: { } dir }
        )
        {
            var p3 = Path.Join(dir.FullName, "include");
            _logger.LogTrace("Suggesting additional path {path}", p3);
            yield return $"-isystem{p3}";
        }
    }

    private string GetXCodeSdkPath()
    {
        string? sdk = null; // TODO XCODE!!!!!!
        _logger.LogTrace("Resolving XCode SDK using SDK {sdk}", sdk);
        var process = new Process();
        process.StartInfo = new ProcessStartInfo(
            "xcrun",
            "--show-sdk-path" + (sdk is null ? "" : $" --sdk {sdk}")
        )
        {
            RedirectStandardOutput = true
        };
        process.Start();
        process.WaitForExit();
        var output = process.StandardOutput.ReadToEnd();
        _logger.LogTrace(
            "Got Response from xcrun: {response} {length}",
            output.ReplaceLineEndings("\\n"),
            output.Length
        );
        var lines = output.Split('\n');
        var path = lines.Length > 0 ? lines[0] : null;
        if (string.IsNullOrWhiteSpace(path))
        {
            try
            {
                _logger.LogTrace(
                    "Available CommandLineTools SDKs appear to be: {versions}",
                    string.Join(
                        ", ",
                        Directory.EnumerateDirectories("/Library/Developer/CommandLineTools/SDKs/")
                    )
                );
                _logger.LogTrace(
                    "Available XCode SDK versions appear to be: {versions}",
                    string.Join(
                        ", ",
                        Directory.EnumerateDirectories(
                            "/Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/"
                        )
                    )
                );
            }
            catch
            { /* */
            }
            throw new InvalidOperationException("xcrun didn't return correct lines to stdout.");
        }
        _logger.LogInformation("Resolved XCode SDK to {path}", path);
        return path;
    }
}
