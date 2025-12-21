// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Silk.NET.Input.KeyHandling;

/// <summary>
/// A series of extension methods for making sense of <see cref="KeyName"/> values
/// </summary>
internal static class KeyNameExtensions
{
    /// <summary>
    /// Returns true if the key would produce a character in common text editing scenarios. Includes whitespace.
    /// </summary>
    public static bool IsChar(this KeyName name) =>
        name is >= KeyName.A and <= KeyName.Return
            or >= KeyName.KeypadDivide and <= KeyName.KeypadPeriod
            or >= KeyName.Tab and <= KeyName.Slash
            or >= KeyName.KeypadMultiply and <= KeyName.KeypadEnter
            or >= KeyName.KeypadA and <= KeyName.KeypadExclamation
            or >= KeyName.Keypad00 and <= KeyName.KeypadTab
            or KeyName.Return2 or KeyName.Separator or KeyName.KeypadPlusMinus
            or KeyName.KeypadComma
            or KeyName.KeypadEquals or KeyName.OtherKeypadEquals;

    /// <summary>
    /// Returns true if the given key would produce a deletion of one or more characters in common text
    /// editing scenarios.
    /// </summary>
    public static bool IsDeletion(this KeyName name) =>
        name is KeyName.Backspace
            or KeyName.Delete
            or KeyName.KeypadBackspace
            or KeyName.Clear
            or KeyName.KeypadClear
            or KeyName.KeypadClearEntry
            or KeyName.ClearAgain;

    public static TextDeletionType GetDeletionType(this KeyName name)
    {
        Debug.Assert(name.IsDeletion());

        return name switch {
            KeyName.Backspace => TextDeletionType.Back,
            KeyName.Delete => TextDeletionType.Forward,
            KeyName.KeypadBackspace => TextDeletionType.Back,
            KeyName.Clear => TextDeletionType.All,
            KeyName.KeypadClear => TextDeletionType.All,
            KeyName.KeypadClearEntry => TextDeletionType.All,
            KeyName.ClearAgain => TextDeletionType.All,
            _ => TextDeletionType.None
        };
    }

    /// <summary>
    /// An enum representing the type of text deletion, if any. For example, <see cref="KeyName.Backspace"/>
    /// would be <see cref="Back"/>, <see cref="KeyName.Delete"/> would be <see cref="Forward"/>, etc.
    /// </summary>
    public enum TextDeletionType
    {
        /// <summary>
        /// Key represents a deletion of one (or more) character(s) behind the cursor.
        /// </summary>
        Back,

        /// <summary>
        /// Key represents a deletion of one (or more) character(s) ahead of the cursor.
        /// </summary>
        Forward,

        /// <summary>
        /// Key represents a deletion of all characters in current text entry context
        /// </summary>
        All,

        /// <summary>
        /// Key does not represent a deletion.
        /// </summary>
        None = -1
    }

    /// <summary>
    /// Returns true if the modifiers signify that the next character should be capitalized.
    /// </summary>
    public static bool ShouldCapitalize(this KeyModifiers modifiers) =>
        ((modifiers & KeyModifiers.CapsLock) == KeyModifiers.CapsLock) ^
        ((modifiers & KeyModifiers.ShiftLeft) == KeyModifiers.ShiftLeft
         || (modifiers & KeyModifiers.ShiftRight) == KeyModifiers.ShiftRight);

    public static bool IsControl(this KeyName name) =>
        name is KeyName.ControlLeft or KeyName.ControlRight;

    public static bool IsControl(this KeyModifiers mod) =>
        (mod & KeyModifiers.ControlLeft) == KeyModifiers.ControlLeft ||
        (mod & KeyModifiers.ControlRight) == KeyModifiers.ControlRight;

    public static bool IsShift(this KeyName name) =>
        name is KeyName.ShiftLeft or KeyName.ShiftRight;

    public static bool IsShift(this KeyModifiers mod) =>
        (mod & KeyModifiers.ShiftLeft) == KeyModifiers.ShiftLeft ||
        (mod & KeyModifiers.ShiftRight) == KeyModifiers.ShiftRight;

    public static bool IsAlt(this KeyName name) =>
        name is KeyName.AltLeft or KeyName.AltRight;

    public static bool IsAlt(this KeyModifiers mod) =>
        (mod & KeyModifiers.AltLeft) == KeyModifiers.AltLeft ||
        (mod & KeyModifiers.AltRight) == KeyModifiers.AltRight;
}
