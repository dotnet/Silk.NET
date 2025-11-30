using System.Diagnostics;

namespace Silk.NET.Core;

/// <summary>
/// Stores the affix of the identifier that this attribute is placed on.
/// </summary>
[AttributeUsage(
    AttributeTargets.Class
    | AttributeTargets.Struct
    | AttributeTargets.Enum
    | AttributeTargets.Property
    | AttributeTargets.Field
    | AttributeTargets.Method
    | AttributeTargets.Parameter
    | AttributeTargets.Delegate,
    AllowMultiple = true,
    Inherited = true
)]
[Conditional("DEBUG")]
public sealed class NameAffixAttribute : Attribute
{
    /// <param name="type">The type of affix. Either "Prefix" or "Suffix".</param>
    /// <param name="affix">The affix of the identifier.</param>
    /// <param name="priority">The priority with which the affix is applied. Higher means the affix is applied first.</param>
    public NameAffixAttribute(string type, string affix, int priority)
    {
        Affix = affix;
        Priority = priority;
    }

    /// <summary>The affix of the identifier.</summary>
    public string Affix { get; }

    /// <summary>The priority with which the affix is applied. Higher means the affix is applied first.</summary>
    public int Priority { get; }
}
