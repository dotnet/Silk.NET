using System.Diagnostics;

namespace Silk.NET.Core;

/// <summary>
/// Attribute used by the SilkTouch bindings generator to store information about identified name affixes.
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
    /// <summary>
    /// Creates a new NameAffix attribute.
    /// </summary>
    public NameAffixAttribute(string type, string affix, int order, int priority)
    {
        Type = type;
        Affix = affix;
        Order = order;
        Priority = priority;
    }

    /// <summary>
    /// The type of affix. Either "Prefix" or "Suffix".
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// The affix of the identifier.
    /// </summary>
    public string Affix { get; }

    /// <summary>
    /// The order with which the affix is applied.
    /// <para/>
    /// Negative means the affix is not reapplied after trimming.
    /// Higher means the affix is applied first.
    /// <para/>
    /// Affixes with the same order have ties broken using the order they are declared on the identifier.
    /// First declared are applied first.
    /// </summary>
    public int Order { get; }

    /// <summary>
    /// The priority with which the affix is used
    /// to create alternative names in case of conflicts.
    /// <para/>
    /// Negative means the affix is required.
    /// Non-negative means the affix is optional.
    /// Higher means the names created using the affix is tried first.
    /// <para/>
    /// Affixes with the same priority are applied together as a group.
    /// </summary>
    public int Priority { get; }
}
