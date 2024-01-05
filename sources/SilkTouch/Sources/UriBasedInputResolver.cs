using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// Uses a URI scheme to allow for a path to resolve to the matching <see cref="IInputSource"/>, if any. If a path
/// can't be parsed as a URI, it's left as is.
/// </summary>
/// <param name="sources">The sources resolvable from URIs.</param>
public class UriBasedInputResolver(IEnumerable<IInputSource> sources) : IInputResolver
{
    /// <inheritdoc />
    public async Task<string?> TryResolvePath(string path)
    {
        foreach (var source in sources)
        {
            // cop out to ensure we're not parsing the URI twice
            if (
                path.Length > source.Scheme.Length
                && path[..source.Scheme.Length].Equals(
                    source.Scheme,
                    StringComparison.CurrentCultureIgnoreCase
                )
                && path[source.Scheme.Length] == ':'
            )
            {
                return await source.TryResolvePath(path);
            }
        }

        return path;
    }
}
