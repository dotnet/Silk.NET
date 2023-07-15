using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Logging;

namespace SilkTouchX.Clang;

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
    public override IEnumerable<string> GetStandardIncludes()
    {
        foreach (var inc in base.GetStandardIncludes())
        {
            yield return inc;
        }

        var sdkPath = GetXCodeSdkPath();
        _logger.LogTrace("Using SDK {sdk} as base", sdkPath);
        var p1 = Path.Combine(sdkPath, "usr/include");
        _logger.LogTrace("Suggesting additional path {path}", p1);
        yield return p1;
        var p2 = Path.Combine(sdkPath, "usr/local/include");
        _logger.LogTrace("Suggesting additional path {path}", p2);
        yield return p2;
    }

    private string GetXCodeSdkPath()
    {
        string? sdk = null; // TODO XCODE!!!!!!
        _logger.LogTrace("Resolving XCode SDK using SDK {sdk}", sdk);
        var process = new Process();
        process.StartInfo = new ProcessStartInfo
            ("xcrun", "--show-sdk-path" + (sdk is null ? "" : $" --sdk {sdk}"))
            {
                RedirectStandardOutput = true
            };
        process.Start();
        process.WaitForExit();
        var output = process.StandardOutput.ReadToEnd();
        _logger.LogTrace("Got Response from xcrun: {response} {length}", output.ReplaceLineEndings("\\n"), output.Length);
        var lines = output.Split('\n');
        var path = lines.Length > 0 ? lines[0] : null;
        if (string.IsNullOrWhiteSpace(path))
        {
            try
            {
                _logger.LogTrace
                (
                    "Available CommandLineTools SDKs appear to be: {versions}",
                    string.Join(", ", Directory.EnumerateDirectories("/Library/Developer/CommandLineTools/SDKs/"))
                );
                _logger.LogTrace
                (
                    "Available XCode SDK versions appear to be: {versions}",
                    string.Join
                    (
                        ", ",
                        Directory.EnumerateDirectories
                            ("/Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/")
                    )
                );
            } catch { /* */ }
            throw new InvalidOperationException("xcrun didn't return correct lines to stdout.");
        }
        _logger.LogInformation("Resolved XCode SDK to {path}", path);
        return path;
    }
}
