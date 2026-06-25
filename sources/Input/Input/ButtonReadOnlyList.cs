using System.Collections;
using System.Runtime.CompilerServices;

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
    internal readonly IReadOnlyList<Button<T>> List;

    /// <summary>
    /// A constructor for an input list that takes in:
    /// </summary>
    /// <param name="buttonList">A list of buttons that will be indexed</param>
    public ButtonReadOnlyList(IReadOnlyList<Button<T>> buttonList)
    {
        List = buttonList;
    }

    /// <summary>
    /// Gets the state for the button with the given name.
    /// </summary>
    /// <param name="name">The button name.</param>
    public Button<T> this[T name]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => List[name.Index()];
    }
    
    /// <inheritdoc />
    /// <remarks>Useful when used with pre-cached index calculations for hot paths</remarks>
    public Button<T> this[int index] => List[index];

    /// <inheritdoc />
    public IEnumerator<Button<T>> GetEnumerator() => List.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => List.Count;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal IReadOnlyList<Button<T>> CreateListCopy() => List.ToArray();
}
