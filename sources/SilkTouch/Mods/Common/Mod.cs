using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SilkTouchX.Clang;
using SilkTouchX.Naming;

namespace SilkTouchX.Mods;

/// <summary>
/// Represents an <see cref="IMod"/> with common functionality.
/// </summary>
public class Mod : IMod
{
    /// <summary>
    /// Gets the common namespace determined from the default namespaces within the response file.
    /// </summary>
    public string? CommonNamespace { get; private set; }

    /// <summary>
    /// Determines where to locate the given "fully qualified file name" i.e. a file name for a type prefixed with its
    /// namespace e.g. Silk.NET.Core.SomeType`1.gen.cs. The extension is removed so that we don't mistake it as part of
    /// the namespace.
    /// </summary>
    /// <param name="fullyQualified">
    /// The fully qualified file name without the extension e.g. Silk.NET.Core.SomeType`1
    /// </param>
    /// <param name="extension">The file extension e.g. .gen.cs</param>
    /// <returns>The path within the sources directory to place this file.</returns>
    public string PathForFullyQualified(string fullyQualified, string extension = ".gen.cs")
    {
        if (!fullyQualified.Contains('.') || CommonNamespace is null or { Length: 0 })
        {
            return fullyQualified + extension;
        }

        return fullyQualified.StartsWith(CommonNamespace)
            ? fullyQualified[CommonNamespace.Length..].Trim('.').Replace('.', '/') + extension
            : fullyQualified + extension;
    }

    /// <inheritdoc />
    public virtual Task BeforeJobAsync(string key, SilkTouchConfiguration config) =>
        Task.CompletedTask;

    /// <inheritdoc />
    public virtual Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        CommonNamespace = NameUtils.FindCommonPrefix(
            rsps.Select(rsp => rsp.GeneratorConfiguration.DefaultNamespace).ToList(),
            true,
            int.MaxValue,
            true
        );
        return Task.FromResult(rsps);
    }

    /// <inheritdoc />
    public virtual Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax) =>
        Task.FromResult(syntax);

    /// <inheritdoc />
    public virtual Task<GeneratorWorkspace> BeforeOutputAsync(
        string key,
        GeneratorWorkspace workspace
    ) => Task.FromResult(workspace);

    /// <inheritdoc />
    public virtual Task AfterJobAsync(string key) => Task.CompletedTask;
}
