using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp;
using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will add standard include directories to a response file that doesn't already have them (i.e. that
/// doesn't depend on the exact location/version of said standard includes)
/// </summary>
public class AddStdIncludes : IMod
{
    private IStdIncludeResolver _resolver;

    /// <summary>
    /// Creates a standard include mod with the given resolver.
    /// </summary>
    /// <param name="resolver">The resolver.</param>
    public AddStdIncludes(IStdIncludeResolver resolver) => _resolver = resolver;

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            rsps[i] = rsp with
            {
                ClangCommandLineArgs = rsp.ClangCommandLineArgs
                    .Concat(_resolver.GetStandardIncludes().Select(x => $"--include-directory={x}"))
                    .ToArray()
            };
        }

        return Task.FromResult(rsps);
    }
}
