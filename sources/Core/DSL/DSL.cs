using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// Contains the "Silk.NET Domain-Specific Language". This is added as a <c>global using static</c> to consuming
/// packages to ensure access to features that make working with Silk.NET interop types easier.
/// </summary>
public static class DSL
{
    /// <summary>
    /// Represents a null pointer. Use this in comparisons &amp; assignment to Silk.NET pointer types.
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static NullPtr nullptr
    {
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        get => new();
    }
}
