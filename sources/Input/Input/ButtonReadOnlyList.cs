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
public struct ButtonReadOnlyList<T> : IReadOnlyList<Button<T>>
    where T : unmanaged, Enum
{
    private InputReadOnlyList<Button<T>> _list;

    internal ButtonReadOnlyList(InputReadOnlyList<Button<T>> list) => _list = list;

    /// <summary>
    /// Creates an <see cref="ButtonReadOnlyList{T}"/> from a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="other">The list to copy.</param>
    public ButtonReadOnlyList(IReadOnlyList<Button<T>> other) =>
        InputMarshal.Clone(other).List.AsButtonList();

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
    public Button<T> this[int index] => _list[index];
}
