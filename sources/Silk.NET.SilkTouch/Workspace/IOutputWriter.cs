using System.Threading;
using System.Threading.Tasks;
using SilkTouchX.Clang;

namespace SilkTouchX.Workspace;

/// <summary>
/// Represents a mechanism by which generated syntax is ingested, optionally modded further using output writer specific
/// mods (e.g. mods that enact MSBuild workspace-level modifications), and then output.
/// </summary>
public interface IOutputWriter
{
    /// <summary>
    /// Outputs the given generated bindings (as syntax) for the given job (and its associated configuration key).
    /// </summary>
    /// <param name="key">The job configuration key.</param>
    /// <param name="job">The job configuration values.</param>
    /// <param name="syntax">The generated bindings as syntax.</param>
    /// <param name="ct">An optional cancellation token.</param>
    /// <returns>An asynchronous task.</returns>
    Task OutputAsync(
        string key,
        SilkTouchConfiguration job,
        GeneratedSyntax syntax,
        CancellationToken ct = default
    );
}
