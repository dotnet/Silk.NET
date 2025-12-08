using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Resolves standard includes using VS setup interoperability and the VS developer command prompt to retrieve the MSVC
/// and Windows SDK paths.
/// </summary>
public class WindowsStdIncludeResolver : IStdIncludeResolver
{
    private readonly ILogger<WindowsStdIncludeResolver> _logger;
    private volatile IEnumerable<string>? _stds;

    /// <summary>
    /// Creates an instance of the include resolver with the given logger.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public WindowsStdIncludeResolver(ILogger<WindowsStdIncludeResolver> logger) => _logger = logger;

    /// <inheritdoc />
    public virtual IEnumerable<string> GetStandardIncludes()
    {
        if (_stds is not null)
        {
            return _stds;
        }

        if (VisualStudioResolver.TryGetVisualStudioInfo(out var info))
        {
            _logger.LogInformation(
                "Successfully resolved VS to {path}",
                info.InstallationBaseFolder
            );
            return _stds = info.MsvcToolsIncludes.Concat(info.UcrtIncludes).Select(x => $"-I{x}");
        }

        _logger.LogWarning("Failed to resolve VS, but OS is Windows!");
        return [];
    }
}
