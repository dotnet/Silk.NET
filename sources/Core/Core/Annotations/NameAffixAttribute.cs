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
    public NameAffixAttribute(string type, string affix, int priority, int discriminatorPriority)
    {
        Type = type;
        Affix = affix;
        Priority = priority;
        DiscriminatorPriority = discriminatorPriority;
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
    /// The priority with which the affix is applied.
    /// Higher means the affix is applied first.
    /// <para/>
    /// Negative means the affix is not reapplied after trimming.
    /// Ideally all affixes of the same type have different priorities.
    /// <para/>
    /// Affixes with the same priority have ties broken using the order they are declared on the identifier.
    /// First declared have higher priority.
    /// </summary>
    public int Priority { get; }

    /// <summary>
    /// The priority with which the affix is used
    /// to create alternative names in case of conflicts.
    /// <para/>
    /// Higher means the names created using the affix is tried first.
    /// Negative means the affix is not used for creating alternative names.
    /// <para/>
    /// Affixes with the same priority are applied together as a group and are combined using the order they are declared on the identifier.
    /// First declared are applied first within the group.
    /// </summary>
    public int DiscriminatorPriority { get; }
}
