using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace SilkTouchX.Workspace;

/// <summary>
/// Represents a type that can open an <see cref="MSBuildWorkspace"/> and <see cref="Solution"/>s within it, and
/// synchronise modifications to loaded solutions.
/// </summary>
/// <remarks>
/// <see cref="MSBuildWorkspace.TryApplyChanges(Solution)"/> returns <c>false</c> if a <see cref="Solution"/> retrieved
/// from that <see cref="MSBuildWorkspace"/> has been modified since the <see cref="Solution"/> object was created,
/// meaning that changes to <see cref="Solution"/>s need to be externally synchronised. Implementations of this type
/// shall provide that synchronisation.
/// </remarks>
public interface IWorkspaceSolutionProvider
{
    /// <summary>
    /// Invokes the given lambda using a workspace and solution loaded using the given configuration key, and applies
    /// changes using the returned modified solution.
    /// </summary>
    /// <param name="key">The configuration key.</param>
    /// <param name="applyChanges">The lambda that will execute the changes and return the modified solution.</param>
    /// <returns>The result of <see cref="MSBuildWorkspace.TryApplyChanges(Solution)"/>.</returns>
    Task<bool> ApplyChangesAsync(
        string key,
        Func<MSBuildWorkspace, Solution, Task<Solution>> applyChanges
    );
}
