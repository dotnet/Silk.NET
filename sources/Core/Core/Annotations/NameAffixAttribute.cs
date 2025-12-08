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
    public NameAffixAttribute(string type, string affix, int order, int discriminatorPriority)
    {
        Type = type;
        Affix = affix;
        Order = order;
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
    /// The order with which the affix is applied.
    /// <para/>
    /// Negative means the affix is not reapplied after trimming.
    /// Higher means the affix is applied first.
    /// <para/>
    /// Affixes with the same order have ties broken using the order they are declared on the identifier.
    /// First declared are applied first.
    /// </summary>
    /// <remarks>
    /// SilkTouch mods setting this property should use either -1, 0, or a value specified through the mod's configuration.
    /// This is to reduce the hardcoding of values and to make the mods more applicable to different sets of bindings.
    /// </remarks>
    public int Order { get; }

    /// <summary>
    /// The priority with which the affix is used
    /// to create secondary names in case of conflicts.
    /// <para/>
    /// Negative means the affix is required, but won't be used to create secondaries.
    /// Non-negative means the affix is optional, but will be used to create secondaries.
    /// Higher means the names created using the affix is tried first.
    /// <para/>
    /// Affixes with the same priority are applied together as a group.
    /// </summary>
    /// <remarks>
    /// SilkTouch mods setting this property should use either -1, 0, or a value specified through the mod's configuration.
    /// This is to reduce the hardcoding of values and to make the mods more applicable to different sets of bindings.
    /// </remarks>
    public int DiscriminatorPriority { get; }
}
