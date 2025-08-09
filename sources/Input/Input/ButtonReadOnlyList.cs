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
public readonly record struct ButtonReadOnlyList<T> : IReadOnlyList<Button<T>>
    where T : unmanaged, Enum
{
    private readonly Func<int, int> _indexMap;
    private readonly IReadOnlyList<Button<T>> _list;

    /// <summary>
    /// A constructor for an input list that takes in:
    /// </summary>
    /// <param name="buttonList">A list of buttons that will be indexed</param>
    /// <param name="indexMap">A pre-built mapping function, if required,
    /// used for iterating through the button list in order, regardless of the backend's internal button order.</param>
    public ButtonReadOnlyList(IReadOnlyList<Button<T>> buttonList, Func<int, int>? indexMap = null)
    {
        _list = buttonList;
        _indexMap = indexMap ?? (i => i);
    }

    /// <summary>
    /// Gets the state for the button with the given name.
    /// </summary>
    /// <param name="name">The button name.</param>
    public Button<T> this[T name] => _list[EnumInfo<T>.ValueIndexOf(name)];

    /// <inheritdoc />
    public IEnumerator<Button<T>> GetEnumerator() => _list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => _list.Count;

    /// <inheritdoc />
    public Button<T> this[int index] => _list[_indexMap(index)];
}
