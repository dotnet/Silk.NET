// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Contains utilities for creating and manipulating <see cref="InputReadOnlyList{T}"/>s. This is a very unsafe set of
/// APIs that are extremely prone to misuse, and therefore is not recommended to be consumed by anyone other than input
/// backends.
/// </summary>
/// <remarks>
/// This class is ABI/API stable, but new APIs that obsolete the old ones may be added at any time as more efficient
/// implementations are discovered.
/// </remarks>
// NOTE: Not experimental so that we don't eliminate the prospects of third-party implementations.
public static class InputMarshal
{
    /// <summary>
    /// A wrapper class denoting ownership of a <see cref="InputReadOnlyList{T}"/>. This is used to attempt to stop
    /// misuse of these methods, but of course it's fairly trivial to work around this for a user determined to do
    /// terrible things.
    /// </summary>
    /// <typeparam name="T">The list element type.</typeparam>
    public struct ListOwner<T>
    {
        internal ListOwner(InputReadOnlyList<T> list) => List = list;

        /// <summary>
        /// Gets the list owned by this owner.
        /// </summary>
        public InputReadOnlyList<T> List { get; }
    }

    internal class ButtonList<T>(uint[] binary, Dictionary<T, Button<T>>? other)
        : IReadOnlyList<Button<T>>
        where T : unmanaged, Enum
    {
        private Dictionary<T, Button<T>>? _other = other;

        public ButtonList()
            : this(new uint[(GetButtonListCount<T>() + 32 - 1) / 32], null) { }

        public ButtonList<T> Clone() =>
            new([.. binary], _other is null ? null : new Dictionary<T, Button<T>>(_other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
        public IEnumerator<Button<T>> GetEnumerator() =>
            typeof(T) == typeof(KeyName) ? GetKeyNameEnumerator() : GetButtonEnumerator();

        private IEnumerator<Button<T>> GetKeyNameEnumerator()
        {
            var idx = 0;
            var bit = 0;
            // To determine the gaps, run the GetButtonCount unit test. The equality check is the LHS from the output +
            // 1, and the assignment is the RHS - 1. Example output below:
            // 0 (Unknown), 4 (A)
            // 129 (VolumeDown), 133 (KeypadComma)
            // 164 (ExtendSelect), 176 (Keypad00)
            // 221 (KeypadHexadecimal), 224 (ControlLeft)
            // 231 (SuperRight), 257 (Mode)
            // 286 (ApplicationBookmarks), 501 (SoftLeft)
            for (var cur = (int)KeyName.A; cur <= (int)KeyName.EndCall; cur++)
            {
                switch (cur)
                {
                    case (int)KeyName.VolumeDown + 1:
                        cur = (int)KeyName.KeypadComma - 1;
                        continue;
                    case (int)KeyName.ExtendSelect + 1:
                        cur = (int)KeyName.Keypad00 - 1;
                        continue;
                    case (int)KeyName.KeypadHexadecimal + 1:
                        cur = (int)KeyName.ControlLeft - 1;
                        continue;
                    case (int)KeyName.SuperRight + 1:
                        cur = (int)KeyName.Mode - 1;
                        continue;
                    case (int)KeyName.ApplicationBookmarks + 1:
                        cur = (int)KeyName.SoftLeft - 1;
                        continue;
                }

                var ret = ElementAt((T)(object)(KeyName)cur, idx, bit);
                (idx, bit) = BitIterate(idx, bit);
                yield return ret;
            }
        }

        private IEnumerator<Button<T>> GetButtonEnumerator()
        {
            var max = GetButtonListCount<T>();
            int idx = 0,
                bit = 0;
            for (var i = 1; i <= max; i++)
            {
                var ret = ElementAt(SilkMarshal.ConstCast<int, T>(i), idx, bit);
                (idx, bit) = BitIterate(idx, bit);
                yield return ret;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Button<T> ElementAt(T name, int idx, int bit)
        {
            var ret = new Button<T>(name, false, 0);
            var isBinaryDown = BitOperations.PopCount(binary[idx] & (1U << (7 - bit))) > 0;
            if (isBinaryDown)
            {
                ret = ret with { IsDown = true, Pressure = 1 };
            }
            else
            {
                _other?.TryGetValue(name, out ret);
            }

            return ret;
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        private static (int, int) BitIterate(int idx, int bit) =>
            ++bit == 32 ? (++idx, 0) : (idx, bit);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => GetButtonListCount<T>();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        internal static T IndexName(int index)
        {
            var name = index;
            if (typeof(T) == typeof(KeyName))
            {
                // To determine the gaps, run the GetButtonCount unit test. The condition is to check whether name
                // is greater than the LHS, and if so add the RHS less the LHS less 1. Example output:
                // 0 (Unknown), 4 (A)
                // 129 (VolumeDown), 133 (KeypadComma)
                // 164 (ExtendSelect), 176 (Keypad00)
                // 221 (KeypadHexadecimal), 224 (ControlLeft)
                // 231 (SuperRight), 257 (Mode)
                // 286 (ApplicationBookmarks), 501 (SoftLeft)
                name += 4;
                if (name > 129)
                {
                    name += 133 - 129 - 1;
                }

                if (name > 164)
                {
                    name += 176 - 164 - 1;
                }

                if (name > 221)
                {
                    name += 224 - 221 - 1;
                }

                if (name > 231)
                {
                    name += 257 - 231 - 1;
                }

                if (name > 286)
                {
                    name += 501 - 286 - 1;
                }
            }
            else
            {
                // To account for Unknown = 0.
                name++;
            }

            return SilkMarshal.ConstCast<int, T>(name);
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        internal static int NameIndex(T name)
        {
            var index = SilkMarshal.ConstCast<T, int>(name);
            if (typeof(T) == typeof(KeyName))
            {
                // To determine the gaps, run the GetButtonCount unit test. The condition is to check whether name
                // is greater than the LHS, and if so subtract the RHS less the LHS less 1. Note that the conditions
                // should be in reverse order i.e. from the last output line to the first output line. Example output:
                // 0 (Unknown), 4 (A)
                // 129 (VolumeDown), 133 (KeypadComma)
                // 164 (ExtendSelect), 176 (Keypad00)
                // 221 (KeypadHexadecimal), 224 (ControlLeft)
                // 231 (SuperRight), 257 (Mode)
                // 286 (ApplicationBookmarks), 501 (SoftLeft)
                if (index > 286)
                {
                    index -= 501 - 286 - 1;
                }

                if (index > 231)
                {
                    index -= 257 - 231 - 1;
                }

                if (index > 221)
                {
                    index -= 224 - 221 - 1;
                }

                if (index > 164)
                {
                    index -= 176 - 164 - 1;
                }

                if (index > 129)
                {
                    index -= 133 - 129 - 1;
                }
                index -= 4;
            }
            else
            {
                // To account for Unknown = 0.
                index--;
            }

            return index;
        }

        public Button<T> this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ArgumentOutOfRangeException.ThrowIfNegative(index);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(index, Count);
                return ElementAt(
                    IndexName(index),
                    Math.DivRem(index, 32, out var remainder),
                    remainder
                );
            }
        }

        public Button<T> this[T name]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                var index = NameIndex(name);
                if (index >= 0 && index < GetButtonListCount<T>())
                {
                    return ElementAt(name, Math.DivRem(index, 32, out var remainder), remainder);
                }

                Throw();
                return default;
                [StackTraceHidden]
                static void Throw() => throw new ArgumentOutOfRangeException(nameof(name));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(Button<T> btn, bool isBinary)
        {
            if (btn.IsDown && isBinary)
            {
                binary[Math.DivRem(NameIndex(btn.Name), 32, out var bit)] |= 1U << (7 - bit);
                _other?.Remove(btn.Name);
            }
            else
            {
                binary[Math.DivRem(NameIndex(btn.Name), 32, out var bit)] &= ~(1U << (7 - bit));
            }

            if (!isBinary)
            {
                (_other ??= [])[btn.Name] = btn;
            }
        }
    }

    /// <summary>
    /// Gets the <see cref="IReadOnlyCollection{T}.Count"/> reported by <see cref="InputReadOnlyList{T}"/>s created with
    /// <see cref="CreateList{T}"/> for the given <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The button name type.</typeparam>
    /// <returns>
    /// The number of buttons that will be in a button list created with <see cref="CreateList{T}"/>, or <c>-1</c> if
    /// <typeparamref name="T"/> is not a supported button name type.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetButtonListCount<T>()
    {
        if (typeof(T) == typeof(JoystickButton))
        {
            return EnumInfo<JoystickButton>.UniqueValues.Count;
        }

        if (typeof(T) == typeof(PointerButton))
        {
            return EnumInfo<PointerButton>.UniqueValues.Count;
        }

        if (typeof(T) == typeof(KeyName))
        {
            // To determine the ranges, run the GetButtonCount unit test. The RHS of the subtraction statements below
            // are the RHS of the line output, and the LHS is the LHS of the following line in its output. There is a
            // final addition that is the number of preceding additions to account for the boundary values. Example
            // output from that test:
            // 0 (Unknown), 4 (A)
            // 129 (VolumeDown), 133 (KeypadComma)
            // 164 (ExtendSelect), 176 (Keypad00)
            // 221 (KeypadHexadecimal), 224 (ControlLeft)
            // 231 (SuperRight), 257 (Mode)
            // 286 (ApplicationBookmarks), 501 (SoftLeft)
            // ReSharper disable once ArrangeRedundantParentheses <-- stylistic choice
            return ((int)KeyName.VolumeDown - (int)KeyName.A)
                + ((int)KeyName.ExtendSelect - (int)KeyName.KeypadComma)
                + ((int)KeyName.KeypadHexadecimal - (int)KeyName.Keypad00)
                + ((int)KeyName.SuperRight - (int)KeyName.ControlLeft)
                + ((int)KeyName.ApplicationBookmarks - (int)KeyName.Mode)
                + ((int)KeyName.EndCall - (int)KeyName.SoftLeft)
                + 6;
        }

        return -1;
    }

    /// <summary>
    /// Creates a <see cref="ButtonReadOnlyList{T}"/> wrapping the given button <see cref="InputReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <typeparam name="T">The button name type.</typeparam>
    /// <returns>The button list.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
    public static ButtonReadOnlyList<T> AsButtonList<T>(this InputReadOnlyList<Button<T>> list)
        where T : unmanaged, Enum => new(list);

    /// <summary>
    /// Creates a <see cref="InputReadOnlyList{T}"/> wrapping the given <see cref="ButtonReadOnlyList{T}"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <typeparam name="T">The button name type.</typeparam>
    /// <returns>The button list.</returns>
    public static InputReadOnlyList<Button<T>> AsInputList<T>(this ButtonReadOnlyList<T> list)
        where T : unmanaged, Enum => new(list);

    /// <summary>
    /// Creates a new <see cref="InputReadOnlyList{T}"/> for the given <typeparamref name="T" />, optionally with the
    /// given <paramref name="capacity"/> where <see cref="GetUnderlyingList{T}"/> is applicable for this
    /// <typeparamref name="T"/>.
    /// </summary>
    /// <param name="capacity">The capacity.</param>
    /// <typeparam name="T">The element type.</typeparam>
    /// <returns>The list.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
    public static ListOwner<T> CreateList<T>(int capacity = 0)
    {
        if (typeof(T) == typeof(Button<KeyName>))
        {
            return (ListOwner<T>)
                (object)
                    new ListOwner<Button<KeyName>>(
                        new InputReadOnlyList<Button<KeyName>>(new ButtonList<KeyName>())
                    );
        }

        if (typeof(T) == typeof(Button<JoystickButton>))
        {
            return (ListOwner<T>)
                (object)
                    new ListOwner<Button<JoystickButton>>(
                        new InputReadOnlyList<Button<JoystickButton>>(
                            new ButtonList<JoystickButton>()
                        )
                    );
        }

        if (typeof(T) == typeof(Button<PointerButton>))
        {
            return (ListOwner<T>)
                (object)
                    new ListOwner<Button<PointerButton>>(
                        new InputReadOnlyList<Button<PointerButton>>(
                            new ButtonList<PointerButton>()
                        )
                    );
        }

        return new ListOwner<T>(new InputReadOnlyList<T>((new List<T>(capacity))));
    }

    /// <summary>
    /// Creates a new <see cref="InputReadOnlyList{T}"/> from the given <see cref="IReadOnlyList{T}"/>. This is
    /// equivalent to <see cref="InputReadOnlyList{T}(IReadOnlyList{T})"/>, but returns a <see cref="ListOwner{T}"/>
    /// instead.
    /// </summary>
    /// <param name="other">The elements to populate the list with.</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
   /* public static ListOwner<T> Clone<T>(IReadOnlyList<T> other)
    {
        // ReSharper disable once InvertIf <-- starting to really dislike this as it duplicates code
        if (other is InputReadOnlyList<T> irl)
        {
            if (typeof(T) == typeof(Button<KeyName>))
            {
                return new ListOwner<T>(
                    new InputReadOnlyList<T>(Unsafe.As<ButtonList<KeyName>>(irl.Data).Clone())
                );
            }

            if (typeof(T) == typeof(Button<PointerButton>))
            {
                return new ListOwner<T>(
                    new InputReadOnlyList<T>(Unsafe.As<ButtonList<PointerButton>>(irl.Data).Clone())
                );
            }

            if (typeof(T) == typeof(Button<JoystickButton>))
            {
                return new ListOwner<T>(
                    new InputReadOnlyList<T>(
                        Unsafe.As<ButtonList<JoystickButton>>(irl.Data).Clone()
                    )
                );
            }
        }

        if (typeof(T) == typeof(Button<KeyName>))
        {
            return new ListOwner<T>(
                new InputReadOnlyList<T>(CloneButtonList((IReadOnlyList<Button<KeyName>>)other))
            );
        }

        if (typeof(T) == typeof(Button<PointerButton>))
        {
            return new ListOwner<T>(
                new InputReadOnlyList<T>(
                    CloneButtonList((IReadOnlyList<Button<PointerButton>>)other)
                )
            );
        }

        // ReSharper disable once ConvertIfStatementToReturnStatement <-- stylistic choice
        if (typeof(T) == typeof(Button<JoystickButton>))
        {
            return new ListOwner<T>(
                new InputReadOnlyList<T>(
                    CloneButtonList((IReadOnlyList<Button<JoystickButton>>)other)
                )
            );
        }

        return new ListOwner<T>(new InputReadOnlyList<T>((object)new List<T>(other)));
        static ButtonList<TEnum> CloneButtonList<TEnum>(IReadOnlyList<Button<TEnum>> list)
            where TEnum : unmanaged, Enum
        {
            var ret = new ButtonList<TEnum>();
            foreach (var button in list)
            {
                ret.Set(
                    button,
                    (button.IsDown && button.Pressure >= 1.0)
                        || (!button.IsDown && button.Pressure <= 0.0)
                );
            }

            return ret;
        }
    }
*/
    /// <summary>
    /// Sets the button state in the given button list.
    /// </summary>
    /// <param name="list">The list to update.</param>
    /// <param name="value">The new state of the button.</param>
    /// <param name="isBinary">
    /// Whether the <see cref="Button{T}.Pressure"/> of <paramref name="value"/> can only be <c>1.0</c> when
    /// <see cref="Button{T}.IsDown"/> is <c>true</c>, and <c>0.0</c> when <see cref="Button{T}.IsDown"/> is
    /// <c>false</c>.
    /// </param>
    /// <typeparam name="T">The button type.</typeparam>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
    public static void SetButtonState<T>(ListOwner<Button<T>> list, Button<T> value, bool isBinary)
        where T : unmanaged, Enum
    {
        if (
            typeof(T) == typeof(KeyName)
            || typeof(T) == typeof(JoystickButton)
            || typeof(T) == typeof(PointerButton)
        )
        {
            Unsafe.As<ButtonList<T>>(list.List.Data).Set(value, isBinary);
            return;
        }

        var underlying = GetUnderlyingList(list)!;
        for (var i = 0; i < underlying.Count; i++)
        {
            // ReSharper disable once InvertIf <-- this literally results in more lines of code!!!!!
            if (underlying[i].Name.Equals(value.Name))
            {
                underlying[i] = value;
                return;
            }
        }

        underlying.Add(value);
    }

    /// <summary>
    /// Attempts to retrieve the underlying <see cref="IList{T}"/> implementation, provided that
    /// <see cref="InputReadOnlyList{T}"/> for the given <typeparamref name="T"/> is implemented as a sequential list
    /// with individually addressable and a variable number of  elements.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <typeparam name="T">The list element type.</typeparam>
    /// <returns>
    /// The list, or <c>null</c> if the optimised implementation of <see cref="InputReadOnlyList{T}"/> cannot be
    /// expressed as an <see cref="IList{T}" />.
    /// </returns>
    /// <remarks>
    /// Currently, this can be assumed to not null except for the following types:
    /// <list type="bullet">
    /// <item><description><see cref="Button{T}"/> where <c>T</c> is <see cref="KeyName"/></description></item>
    /// <item><description><see cref="Button{T}"/> where <c>T</c> is <see cref="JoystickButton"/></description></item>
    /// <item><description><see cref="Button{T}"/> where <c>T</c> is <see cref="PointerButton"/></description></item>
    /// </list>
    /// It is a breaking change to change the underlying implementation of the list such that this method returns
    /// <c>null</c> where it previously did not return <c>null</c>, therefore Silk.NET will only do this in a
    /// <i>major</i> release. As a result, it is safe to use the <c>!</c> operator for code targeting a specific major
    /// release. Ideally, this is also the case for major releases, but the Silk.NET team cannot guarantee this at this
    /// time.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
    public static IList<T>? GetUnderlyingList<T>(this ListOwner<T> list) =>
        typeof(T) == typeof(Button<KeyName>)
        || typeof(T) == typeof(Button<PointerButton>)
        || typeof(T) == typeof(Button<JoystickButton>)
            ? null
            : Unsafe.As<List<T>>(list.List.Data);

    /// <summary>
    /// Unsafely creates a <see cref="ListOwner{T}"/> for the given list. Note that you should really only do this if
    /// you are actually the owner of the list and are for some reason not storing the <see cref="ListOwner{T}"/>, using
    /// this API to gain mutable access to an input list is almost always breaking assumptions throughout the input API.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <typeparam name="T">The type of the elements in the list.</typeparam>
    /// <returns>The list owner.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ListOwner<T> AsOwned<T>(InputReadOnlyList<T> list) => new(list);

    /// <summary>
    /// Given an owned mutable <see cref="GamepadState"/>, swaps out the value of <see cref="GamepadState.Triggers"/>.
    /// Note that this should not be used unexpectedly, and if there are any doubts about ownership or usage then create
    /// a new instance of <see cref="GamepadState"/> for safe mutation.
    /// </summary>
    /// <param name="state">The <see cref="GamepadState"/>.</param>
    /// <param name="triggers">The new triggers.</param>
    public static void SetTriggers(GamepadState state, DualReadOnlyList<float> triggers) =>
        state.Triggers = triggers;

    /// <summary>
    /// Given an owned mutable <see cref="GamepadState"/>, swaps out the value of
    /// <see cref="GamepadState.Thumbsticks"/>. Note that this should not be used unexpectedly, and if there are any
    /// doubts about ownership or usage then create a new instance of <see cref="GamepadState"/> for safe mutation.
    /// </summary>
    /// <param name="state">The <see cref="GamepadState"/>.</param>
    /// <param name="thumbsticks">The new thumbsticks.</param>
    public static void SetThumbsticks(GamepadState state, DualReadOnlyList<Vector2> thumbsticks) =>
        state.Thumbsticks = thumbsticks;

    /// <summary>
    /// Given an owned mutable <see cref="PointerState"/>, swaps out the value of
    /// <see cref="PointerState.GripPressure"/>. Note that this should not be used unexpectedly, and if there are any
    /// doubts about ownership or usage then create a new instance of <see cref="PointerState"/> for safe mutation.
    /// </summary>
    /// <param name="state">The <see cref="PointerState"/>.</param>
    /// <param name="gripPressure">The new grip pressure.</param>
    public static void SetGripPressure(PointerState state, float gripPressure) =>
        state.GripPressure = gripPressure;

    // These are APIs defined on InputReadOnlyList or ButtonReadOnlyList but are implemented here to keep the
    // implementation of the backing list in one file, the hope being that this decreases the likelihood of bugs.

    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- generic specialisation
    internal static Button<T> GetButtonState<T>(InputReadOnlyList<Button<T>> list, T name)
        where T : unmanaged, Enum
    {
        if (
            typeof(T) == typeof(KeyName)
            || typeof(T) == typeof(JoystickButton)
            || typeof(T) == typeof(PointerButton)
        )
        {
            return Unsafe.As<ButtonList<T>>(list.Data)[name];
        }

        var underlying = Unsafe.As<List<Button<T>>>(list.Data);
        foreach (var t in underlying)
        {
            // ReSharper disable once InvertIf <-- this literally results in more lines of code!!!!!
            if (t.Name.Equals(name))
            {
                return t;
            }
        }

        return new Button<T>(name, false, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static int GetListCount<T>(InputReadOnlyList<T> list)
    {
        if (typeof(T) == typeof(Button<KeyName>))
        {
            return GetButtonListCount<KeyName>();
        }

        if (typeof(T) == typeof(Button<PointerButton>))
        {
            return GetButtonListCount<PointerButton>();
        }

        if (typeof(T) == typeof(Button<JoystickButton>))
        {
            return GetButtonListCount<JoystickButton>();
        }

        return Unsafe.As<List<T>>(list.Data).Count;
    }

    // ReSharper disable NotDisposedResourceIsReturned - Nope, sorry, not adding a reference to JetBrains.Annotations.
    internal static IEnumerator<T> EnumerateList<T>(InputReadOnlyList<T> list)
    {
        if (typeof(T) == typeof(Button<KeyName>))
        {
            return (IEnumerator<T>)Unsafe.As<ButtonList<KeyName>>(list.Data).GetEnumerator();
        }

        if (typeof(T) == typeof(Button<PointerButton>))
        {
            return (IEnumerator<T>)Unsafe.As<ButtonList<PointerButton>>(list.Data).GetEnumerator();
        }

        if (typeof(T) == typeof(Button<JoystickButton>))
        {
            return (IEnumerator<T>)Unsafe.As<ButtonList<JoystickButton>>(list.Data).GetEnumerator();
        }

        return Unsafe.As<List<T>>(list.Data).GetEnumerator();
    } // ReSharper restore NotDisposedResourceIsReturned

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static T ElementAt<T>(InputReadOnlyList<T> list, int index)
    {
        if (typeof(T) == typeof(Button<KeyName>))
        {
            return (T)(object)Unsafe.As<ButtonList<KeyName>>(list.Data)[index];
        }

        if (typeof(T) == typeof(Button<PointerButton>))
        {
            return (T)(object)Unsafe.As<ButtonList<PointerButton>>(list.Data)[index];
        }

        if (typeof(T) == typeof(Button<JoystickButton>))
        {
            return (T)(object)Unsafe.As<ButtonList<JoystickButton>>(list.Data)[index];
        }

        return Unsafe.As<List<T>>(list.Data)[index];
    }
}
