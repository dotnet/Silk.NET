using System.Collections;

namespace Silk.NET.Input;

/// <summary>
/// Represents a list that has exactly two elements.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public readonly struct DualReadOnlyList<T>(T left, T right) : IReadOnlyList<T>
{
    /// <summary>
    /// Creates a copy of the given list.
    /// </summary>
    /// <param name="other">The list.</param>
    public DualReadOnlyList(DualReadOnlyList<T> other)
        : this(other.Left, other.Right) { }

    /// <summary>
    /// The first/leftmost element.
    /// </summary>
    public readonly T Left = left;

    /// <summary>
    /// The second/rightmost element.
    /// </summary>
    public readonly T Right = right;

    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        yield return Left;
        yield return Right;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => 2;

    /// <inheritdoc />
    public T this[int index] =>
        index switch
        {
            0 => Left,
            1 => Right,
            _ => throw new IndexOutOfRangeException(),
        };
}
