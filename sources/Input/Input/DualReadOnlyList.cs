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

    public DualReadOnlyList(Func<T> getLeft, Func<T> getRight)
    {
        _getLeft = getLeft;
        _getRight = getRight;
    }

    /// <summary>
    /// The first/leftmost element.
    /// </summary>
    public T Left
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _getLeft();
    }

    /// <summary>
    /// The second/rightmost element.
    /// </summary>
    public T Right
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _getRight();
    }


    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator()
    {
        yield return _getLeft();
        yield return _getRight();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => 2;

    /// <inheritdoc />
    public T this[int index] =>
        index switch
        {
            0 => _getLeft(),
            1 => _getRight(),
            _ => throw new IndexOutOfRangeException(),
        };


    private readonly Func<T> _getLeft;
    private readonly Func<T> _getRight;
}
