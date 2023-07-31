using System.Diagnostics;

namespace Silk.NET.Core;

/// <summary>Defines the vtbl index of a method as it was in the native signature.</summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
public sealed class VtblIndexAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref="VtblIndexAttribute" /> class.</summary>
    /// <param name="index">The vtbl index of a method as it was in the native signature.</param>
    public VtblIndexAttribute(uint index) => Index = index;

    /// <summary>Gets the vtbl index of a method as it was in the native signature.</summary>
    public uint Index { get; }
}
