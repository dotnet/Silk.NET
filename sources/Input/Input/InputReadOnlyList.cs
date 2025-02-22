namespace Silk.NET.Input;

/// <summary>
/// An opaque implementation of <see cref="IReadOnlyList{T}"/> that is optimised for storing a <c>Silk.NET.Input</c>
/// type specified by <typeparamref name="T"/> using the most memory-efficient mechanism available.
/// </summary>
/// <typeparam name="T">The <c>Silk.NET.Input</c> type to store.</typeparam>
public struct InputReadOnlyList<T> : IReadOnlyList<T>
{
    /// <summary>
    /// Creates an <see cref="InputReadOnlyList{T}"/> from a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="other">The list to copy.</param>
    public InputReadOnlyList(IReadOnlyList<T> other);
}