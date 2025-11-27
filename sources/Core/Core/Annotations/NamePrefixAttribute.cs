namespace Silk.NET.Core;

/// <summary>
/// Stores the suffix of the identifier that this attribute is placed on.
/// </summary>
[AttributeUsage(
    AttributeTargets.Struct
    | AttributeTargets.Enum
    | AttributeTargets.Property
    | AttributeTargets.Field
    | AttributeTargets.Method
    | AttributeTargets.Parameter
    | AttributeTargets.ReturnValue,
    AllowMultiple = false,
    Inherited = true
)]
public sealed class NamePrefixAttribute : Attribute
{
    /// <param name="suffix">The suffix of the identifier.</param>
    /// <param name="priority">The priority with which the suffix is applied. Higher means the suffix is applied first.</param>
    public NamePrefixAttribute(string suffix, int priority = 0)
    {
        Suffix = suffix;
        Priority = priority;
    }

    /// <summary>The suffix of the identifier.</summary>
    public string Suffix { get; }

    /// <summary>The priority with which the suffix is applied. Higher means the suffix is applied first.</summary>
    public int Priority { get; }
}