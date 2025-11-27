namespace Silk.NET.Core;

/// <summary>
/// Stores the prefix of the identifier that this attribute is placed on.
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
public sealed class NameSuffixAttribute : Attribute
{
    /// <param name="prefix">The prefix of the identifier.</param>
    /// <param name="priority">The priority with which the prefix is applied. Higher means the prefix is applied first.</param>
    public NameSuffixAttribute(string prefix, int priority)
    {
        Prefix = prefix;
        Priority = priority;
    }

    /// <summary>The prefix of the identifier.</summary>
    public string Prefix { get; }

    /// <summary>The priority with which the prefix is applied. Higher means the prefix is applied first.</summary>
    public int Priority { get; }
}
