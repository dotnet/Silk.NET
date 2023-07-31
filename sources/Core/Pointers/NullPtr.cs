using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// A dummy type for representing a null pointer.
/// </summary>
/// <remarks>
/// It is recommended to use this as part of the Silk.NET DSL i.e. <see cref="DSL.nullptr"/>.
/// </remarks>
public readonly record struct NullPtr
{
    /// <summary>
    /// Operator to account for <see cref="DSL.nullptr"/> being used instead of <c>null</c>.
    /// </summary>
    /// <param name="_">The null pointer.</param>
    /// <returns>A null void pointer.</returns>
    [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
    public static unsafe implicit operator void*(NullPtr _) => null;
}
