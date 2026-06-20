using System.Collections;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Represents a list that has exactly two elements.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public readonly struct DualReadOnlyList<T> : IReadOnlyList<T>
{
    /// <summary>
    /// Represents a list that has exactly two elements.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>

    public DualReadOnlyList(Func<T> left, Func<T> right)
    {
        _left = left;
        _right = right;
    }

    /// <summary>
    /// The first/leftmost element.
    /// </summary>
    public T Left
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _left();
    }

    /// <summary>
    /// The second/rightmost element.
    /// </summary>
    public T Right
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _right();
    }


    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        yield return _left();
        yield return _right();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => 2;

    /// <inheritdoc />
    public T this[int index] =>
        index switch
        {
            0 => _left(),
            1 => _right(),
            _ => throw new IndexOutOfRangeException(),
        };


    private readonly Func<T> _left;
    private readonly Func<T> _right;
}
