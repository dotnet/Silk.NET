using System.Collections;

namespace Silk.NET.Input;

/// <summary>
/// An implementation of <see cref="IReadOnlyList{T}"/> providing utility APIs for getting a <see cref="Button{T}"/>
/// given a button name <typeparamref name="T"/>, that is optimised for storing <see cref="Button{T}"/>s with the
/// given button name type <typeparamref name="T"/> using the most memory-efficient mechanism available.
/// </summary>
/// <typeparam name="T">
/// The button type (e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc).
/// </typeparam>
public readonly struct ButtonReadOnlyList<T> : IReadOnlyList<Button<T>>
    where T : unmanaged, Enum
{
    private readonly int _count;
    private readonly Func<T, int> _getIndexFunc;
    private readonly Func<int, int> _indexMap;

    public ButtonReadOnlyList(InputReadOnlyList<Button<JoystickButton>> getIndexFunc)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets the state for the button with the given name.
    /// </summary>
    /// <param name="name">The button name.</param>
    public Button<T> this[T name] => _list[_getIndexFunc(name)];

    /// <inheritdoc />
    public IEnumerator<Button<T>> GetEnumerator() => _list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => _list.Count;

    /// <inheritdoc />
    public Button<T> this[int index] => _list[_indexMap(index)];
}
