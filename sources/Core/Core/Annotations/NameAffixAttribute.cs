using System.Diagnostics;

namespace Silk.NET.Core;

/// <summary>
/// Attribute used by the SilkTouch bindings generator to store information about identified name affixes.
/// </summary>
[AttributeUsage(
    AttributeTargets.Class
        | AttributeTargets.Delegate
        | AttributeTargets.Enum
        | AttributeTargets.Field
        | AttributeTargets.Method
        | AttributeTargets.Parameter
        | AttributeTargets.Property
        | AttributeTargets.Struct,
    AllowMultiple = true,
    Inherited = true
)]
[Conditional("DEBUG")]
public sealed class NameAffixAttribute : Attribute
{
    /// <summary>
    /// Creates a new NameAffix attribute.
    /// </summary>
    public NameAffixAttribute(string type, string category, string affix)
    {
        Type = type;
        Category = category;
        Affix = affix;
    }

    /// <summary>
    /// The type of affix. Either "Prefix" or "Suffix".
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// The category of the affix.
    /// </summary>
    /// <remarks>
    /// This is used to identify which name affix configuration is used to process this affix.
    /// </remarks>
    public string Category { get; }

    /// <summary>
    /// The affix of the identifier.
    /// </summary>
    public string Affix { get; }
}
