// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using Silk.NET.SDL;

namespace Silk.NET.Input;

/// <summary>
/// A utility class for recording text input.
/// Where possible, it may be preferable to use <see cref="ISdl.StartTextInput"/> and <see cref="ISdl.StopTextInput"/>
/// instead, but this requires the use of the SDL windowing API, which may not be available in all contexts.
/// This class is a work in progress, and not yet sufficient for full text-editor support.
/// </summary>
public class TextRecorder
{
    public void AddKeyStroke(KeyName name, bool isDown, IKeyboard keyboard)
    {
        var isChar = name.IsChar();
        var isDeletion = name.IsDeletion();

        if (!isChar && !isDeletion)
        {
            return;
        }

        if (name == KeyName.Paste)
        {
            var clipboardText = keyboard.ClipboardText;
            if (!string.IsNullOrEmpty(clipboardText))
            {
                OverwriteSelectionBeforeInsert();
                InsertString(clipboardText);
            }

            return;
        }

        var state = keyboard.State;
        var activeModifiers = state.Modifiers;

    }

    private void OverwriteSelectionBeforeInsert()
    {
        if (_cursorStart == _cursorEnd)
        {
            return;
        }

        _sb.Remove(_cursorStart, _cursorEnd - _cursorStart);
        _cursorEnd = _cursorStart;
    }

    public void InsertString(string str)
    {
        _sb.Insert(_cursorStart, str);
        _cursorEnd = _cursorStart += str.Length;
    }

    public void AddChar(char c)
    {
        OverwriteSelectionBeforeInsert();
        _sb.Insert(_cursorStart, c);
        _cursorEnd = _cursorStart += 1;
    }

    public string? ConsumeInput()
    {
        var result = _sb.ToString();
        _sb.Clear();
        return result;
    }

    public void GetCurrentBuffer(Span<char> buffer)
    {
        var maxCount = Math.Min(buffer.Length, _sb.Length);
        _sb.CopyTo(0, buffer, maxCount);
    }

    public void GetSelectedRegion(Span<char> buffer)
    {

    }

    public int Count => _sb.Length;

    private int _cursorStart, _cursorEnd;
    private readonly StringBuilder _sb = new();
}

/// <summary>
/// A series of extension methods for making sense of <see cref="KeyName"/> values
/// </summary>
public static class KeyNameExtensions
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

}
