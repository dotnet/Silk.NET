using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace SilkTouchX.Clang;

/// <summary>
/// Resolver for the C standard include paths on UNIX-like systems. On UNIX this is remarkably simple, it's just
/// /usr/include and /usr/include/local.
/// </summary>
public class UnixStdIncludeResolver : IStdIncludeResolver
{
    /// <inheritdoc />
    public virtual IEnumerable<string> GetStandardIncludes()
    {
        yield return "/usr/include";
        yield return "/usr/local/include";
    }
}
