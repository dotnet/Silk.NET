namespace Silk.NET.Core;

/// <summary>
/// Denotes the associated interface containing this class' native APIs. If this is used on an interface, it is expected
/// that <paramref name="type"/> is the attributed type. This can also be used on <c>struct</c>
/// </summary>
/// <param name="type">The interface type representing this class' API.</param>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class NativeMemberContainerAttribute(Type type) : Attribute
{
    /// <summary>
    /// The interface type.
    /// </summary>
    public Type Type { get; } = type;

    /// <summary>
    /// This is the static interface.
    /// </summary>
    public bool Static { get; init; }
}
