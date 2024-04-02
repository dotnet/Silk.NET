namespace Silk.NET.Core;

/// <summary>
/// An attribute used to indicate that a symbol is a transformed variant of another symbol.
/// </summary>
/// <remarks>
/// This attribute is primarily used as an intrinsic in the Silk.NET SilkTouch generator pipeline. This includes:
/// <list type="bullet">
/// <item>
/// <term>Indicating mods should ignore an annotated type.</term>
/// <description>
/// An example of this is when a type is generated using the typical PascalCase nomenclature and should not flow through
/// the <c>PrettifyNames</c> automated prefix detection pipeline. Note that the typical behaviour of the mod, namely
/// trimming an identified prefix and converting to PascalCose if not already, will still occur. Mods should ignore or
/// otherwise specially treat types that are annotated with this attribute except in extreme circumstances.
/// </description>
/// </item>
/// <item>
/// <term>Indicating mods should not ignore an annotated method.</term>
/// <description>
/// Generally mods are optimistic about whether their modifications can be applied to types, whereas this can't be said
/// for methods and other members of types, especially when they have bodies. If a method has a body and a mod is unable
/// to recognise the origin of said body, then the mod quite often ignores it. This attribute prevents that, for example
/// in this leads the <c>AddVTables</c> mod to recognise a method with a body as a V-Table candidate whereas usually
/// these are pessimised. Mods should avoid pessimising methods or other members that are annotated with this attribute.
/// </description>
/// </item>
/// </list>
/// Generally, this attribute indicates special recognition is required and that normal behaviour should not occur for
/// the annotated symbol in the generator pipeline except in special circumstances i.e. the annotated symbol &quot;goes
/// against the norm&quot;.
/// </remarks>
/// <param name="isTransformed">
/// Whether the attribute applies. By default, a transformation attribute on a parent automatically cascades to its
/// members, but this parameter being set to false can be used to prevent that.
/// </param>
[AttributeUsage(
    AttributeTargets.Class
        | AttributeTargets.Constructor
        | AttributeTargets.Enum
        | AttributeTargets.Event
        | AttributeTargets.Field
        | AttributeTargets.Interface
        | AttributeTargets.Method
        | AttributeTargets.Property
        | AttributeTargets.Struct,
    AllowMultiple = true,
    Inherited = false
)]
public class TransformedAttribute(bool isTransformed = true) : Attribute
{
    /// <summary>
    /// Whether the attribute applies.
    /// </summary>
    public bool IsTransformed { get; } = isTransformed;
}
