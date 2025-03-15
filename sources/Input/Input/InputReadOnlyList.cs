using System.Collections;

namespace Silk.NET.Input;

/// <summary>
/// An opaque implementation of <see cref="IReadOnlyList{T}"/> that is optimised for storing a <c>Silk.NET.Input</c>
/// type specified by <typeparamref name="T"/> using the most memory-efficient mechanism available.
/// </summary>
/// <typeparam name="T">The <c>Silk.NET.Input</c> type to store.</typeparam>
public readonly struct InputReadOnlyList<T> : IReadOnlyList<T>
{
    internal object Data { get; }

    internal InputReadOnlyList(object data) => Data = data;

    /// <summary>
    /// Creates an <see cref="InputReadOnlyList{T}"/> from a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="other">The list to copy.</param>
    public InputReadOnlyList(IReadOnlyList<T> other) => this = InputMarshal.Clone(other).List;

    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator() => InputMarshal.EnumerateList(this);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => InputMarshal.GetListCount(this);

    /// <inheritdoc />
    public T this[int index] => InputMarshal.ElementAt(this, index);
}
