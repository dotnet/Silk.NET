using System.Collections;

namespace Silk.NET.Input;

/// <summary>
/// Represents a list that has exactly two elements.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public readonly struct DualReadOnlyList<T> : IReadOnlyList<T>
{
    /// <summary>
    /// The first/leftmost element.
    /// </summary>
    public readonly T Left;

    /// <summary>
    /// The second/rightmost element.
    /// </summary>
    public readonly T Right;

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
    public T this[int index] => index switch {
        0 => Left,
        1 => Right,
        _ => throw new IndexOutOfRangeException()
    };
}