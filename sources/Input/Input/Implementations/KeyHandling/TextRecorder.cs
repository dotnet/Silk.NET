// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Text;
using Silk.NET.SDL;

namespace Silk.NET.Input.KeyHandling;

/// <summary>
/// A utility class for recording text input.
/// Where possible, it may be preferable to use <see cref="ISdl.StartTextInput"/> and <see cref="ISdl.StopTextInput"/>
/// instead, but this requires the use of the SDL windowing API, which may not be available in all contexts.
/// This class is a work in progress, and not yet sufficient for full text-editor support.
/// </summary>
internal sealed class TextRecorder
{
    private readonly ICharacterConverter _converter;

    /// <summary>
    /// Constructor
    /// </summary>
    public TextRecorder(ICharacterConverter? converter)
    {
        _converter = converter ?? new DummyCharConverter();
    }

    /// <summary>
    /// The number of characters currently in the buffer.
    /// </summary>
    public int Count => _sb.Length;

    /// <summary>
    /// Modify the buffer and recorder state based on the input key name and the state of the keyboard.
    /// </summary>
    /// <param name="name">The keystroke to add</param>
    /// <param name="keyboard">The keyboard whose state we are recording</param>
    public void AddKeyStroke(KeyName name, IKeyboard keyboard)
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
                InsertText(clipboardText);
            }

            return;
        }

        var state = keyboard.State;
        var activeModifiers = state.Modifiers;
        if (name.IsChar())
        {
            if (activeModifiers.IsAlt() || activeModifiers.IsControl())
            {
                return;
            }

            // insert the appropriate character
            // first, we need the virtual key represented by the scancode (KeyName)

            if (_converter.TryConvert(name, activeModifiers, out var c))
            {
                InsertText(c.Value);
            }

            return;
        }

        if (name.IsDeletion())
        {
            var deletionType = name.GetDeletionType();
            Debug.Assert(deletionType != KeyNameExtensions.TextDeletionType.None);
            switch (deletionType)
            {
                case KeyNameExtensions.TextDeletionType.Back:
                    if (_selectionLength > 0)
                    {
                        RemoveSelectedTextAndClearSelection();
                    }
                    else if (_cursorStart > 0)
                    {
                        // remove from behind cursor and move cursor back accordingly
                        if (activeModifiers.IsControl())
                        {
                            // find first whitespace character prior to current cursor position
                            var cursorPos = _cursorStart;
                            while (cursorPos > 0 && !char.IsWhiteSpace(_sb[cursorPos - 1]))
                            {
                                --cursorPos;
                            }

                            var count = Math.Min(_cursorStart - cursorPos, 1);
                            _sb.Remove(cursorPos, count);
                            _cursorStart = cursorPos;
                        }
                        else
                        {
                            _sb.Remove(--_cursorStart, 1);
                        }
                    }

                    break;
                case KeyNameExtensions.TextDeletionType.Forward:
                    if (_selectionLength > 0)
                    {
                        RemoveSelectedTextAndClearSelection();
                    }
                    else if (_cursorStart < _sb.Length)
                    {
                        // remove from front of cursor
                        if (activeModifiers.IsControl())
                        {
                            // find first whitespace character after current cursor position
                            var cursorPos = _cursorStart;
                            while (cursorPos < _sb.Length && !char.IsWhiteSpace(_sb[cursorPos]))
                            {
                                ++cursorPos;
                            }

                            var count = Math.Min(_sb.Length - cursorPos, 1);
                            _sb.Remove(cursorPos, count);
                        }
                        else
                        {
                            _sb.Remove(_cursorStart, 1);
                        }
                    }
                    break;
                case KeyNameExtensions.TextDeletionType.All:
                    _sb.Clear();
                    SetCursorPositionRaw(0);
                    SetSelectionLength(0);
                    break;
                default:
                    Console.Error.WriteLine("Unexpected text deletion type");
                    break;
            }
        }
    }

    /// <summary>
    /// Removes the currently selected text and sets the current selection length to 0.
    /// </summary>
    private void RemoveSelectedTextAndClearSelection()
    {
        // remove the currently selected text
        var selectedLength = _selectionLength;
        SetSelectionLength(0);
        if (selectedLength > 0 && _cursorStart < _sb.Length)
        {
            Debug.Assert(_cursorStart + selectedLength <= _sb.Length);
            _sb.Remove(_cursorStart, selectedLength);
        }
    }

    /// <summary>
    /// Inserts the given text into the buffer at the current cursor/selection position.
    /// </summary>
    /// <param name="str"></param>
    public void InsertText(ReadOnlySpan<char> str)
    {
        RemoveSelectedTextAndClearSelection();

        if (str.Length > 0)
        {
            _sb.Insert(_cursorStart, str);
            SetCursorPositionRaw(_cursorStart + str.Length);
        }
    }

    /// <summary>
    /// Inserts the given text into the buffer at the current cursor/selection position.
    /// </summary>
    /// <param name="c"></param>
    public void InsertText(char c)
    {
        ReadOnlySpan<char> span = [c];
        InsertText(span);
    }

    /// <summary>
    /// Inserts the given text into the buffer at the given cursor position. Given cursor position is always
    /// clamped to the bounds of the buffer. Clears any current selection if the actual cursor position is different from
    /// the provided cursor position.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="cursorStart">The cursor position in the buffer to inject </param>
    public void InsertTextAt(ReadOnlySpan<char> str, int cursorStart)
    {
        if (_cursorStart != cursorStart)
        {
            SetCursorPositionRaw(cursorStart);
            SetSelectionLength(0);
        }

        InsertText(str);
    }

    /// <summary>
    /// Inserts the given text into the buffer at the given cursor position. Given cursor position is always
    /// clamped to the bounds of the buffer. Clears any current selection if the actual cursor position is different from
    /// the provided cursor position.
    /// </summary>
    /// <param name="textPtrUnsafe"></param>
    /// <param name="cursorStart">The cursor position in the buffer to inject</param>
    /// <param name="textLength"></param>
    public unsafe void InsertTextAt(sbyte* textPtrUnsafe, int cursorStart, int textLength) =>
        InsertTextAt(textPtr: new Ptr<sbyte>(textPtrUnsafe), cursorStart, textLength);

    /// <summary>
    /// Inserts the given text into the buffer at the given cursor position. Given cursor position is always
    /// clamped to the bounds of the buffer. Clears any current selection if the actual cursor position is different from
    /// the provided cursor position.
    /// </summary>
    /// <param name="textPtr"></param>
    /// <param name="cursorStart">The cursor position in the buffer to inject</param>
    public void InsertTextAt(Ptr<sbyte> textPtr, int cursorStart)
    {
        // count to end
        const char terminator = '\0';
        for (uint i = 0; i < int.MaxValue; ++i)
        {
            if (textPtr[i] == terminator)
            {
                InsertTextAt(textPtr, cursorStart, (int)i);
                return;
            }

            ++i;
        }
    }

    /// <summary>
    /// Inserts the given text into the buffer at the given cursor position. Given cursor position is always
    /// clamped to the bounds of the buffer. Clears any current selection if the actual cursor position is different from
    /// the provided cursor position.
    /// </summary>
    /// <param name="textPtr"></param>
    /// <param name="cursorStart">The cursor position in the buffer to inject</param>
    /// <param name="textLength"></param>
    public void InsertTextAt(Ptr<sbyte> textPtr, int cursorStart, int textLength)
    {
        Span<char> textSpan = stackalloc char[textLength];

        if (textPtr.TryReadToSpan(ref textSpan))
        {
            Debug.Assert(textSpan.Length == textLength);
            InsertTextAt(textSpan, cursorStart);
        }
        else
        {
            Console.Error.WriteLine("Failed to read text from text editing event.");
            // insert empty just to synchronize cursor position
            SetSelection(cursorStart, 0);
        }
    }

    /// <summary>
    /// Sets the selection appropriately for the given positions. Positions can be provided in any order,
    /// and resulting selection will be clamped to a valid range for the current buffer.
    /// </summary>
    /// <param name="positionA"></param>
    /// <param name="positionB"></param>
    public void SetSelectionPositions(int positionA, int positionB)
    {
        if (positionA > positionB)
        {
            SetSelection(positionB, positionA - positionB);
        }
        else
        {
            SetSelection(positionA, positionB - positionA);
        }
    }

    /// <summary>
    /// Set the selection to the given start and length. Position and length are clamped to the bounds of the buffer.
    /// </summary>
    /// <param name="startPosition"></param>
    /// <param name="length"></param>
    public void SetSelection(int startPosition, int length)
    {
        SetCursorPositionRaw(startPosition);
        SetSelectionLength(length);
    }

    /// <summary>
    /// Moves the cursor start to the given position, and adjusts the selection length such that
    /// the selection's end does not move
    /// </summary>
    /// <param name="newPosition"></param>
    public void MoveCursorStart(int newPosition)
    {
        var pCursor = _cursorStart;
        SetCursorPositionRaw(newPosition);
        var diff = pCursor - _cursorStart;
        SetSelectionLength(_selectionLength + diff);
    }

    /// <summary>
    /// Adjusts the selection length based on a given end position. The end position is clamped to the bounds of the
    /// buffer. This may modify the selection start position if the provided position is less than the current
    /// start cursor position.
    /// </summary>
    /// <param name="endPosition"></param>
    public void MoveCursorEnd(int endPosition)
    {
        if (endPosition < _cursorStart)
        {
            SetCursorPositionRaw(endPosition);
            SetSelectionLength(0);
            return;
        }

        var clampedEndPosition = Math.Clamp(endPosition, _cursorStart, _sb.Length);
        SetSelectionLength(clampedEndPosition - _cursorStart);
    }

    /// <summary>
    /// Sets the selection length to the given value. The value is clamped to the bounds of the buffer.
    /// </summary>
    /// <param name="newLength"></param>
    private void SetSelectionLength(int newLength) =>
        _selectionLength = Math.Clamp(newLength, 0, _sb.Length - _cursorStart);

    /// <summary>
    /// Sets the value of <see cref="_cursorStart"/> to the given value. The value is clamped to the bounds of the buffer.
    /// Selection length is not affected.
    /// </summary>
    /// <param name="newPosition"></param>
    private void SetCursorPositionRaw(int newPosition) => _cursorStart = Math.Clamp(newPosition, 0, _sb.Length);

    /// <summary>
    /// Fills a span with current buffer contents. Will fill the given span up to the length of the contents or the
    /// length of the span.
    /// </summary>
    /// <param name="buffer"></param>
    /// <returns></returns>
    public int GetCurrentBuffer(Span<char> buffer)
    {
        var maxCount = Math.Min(buffer.Length, _sb.Length);
        _sb.CopyTo(0, buffer, maxCount);
        return maxCount;
    }

    /// <summary>
    /// Fills a span with the currently selected text. Will fill the given span up to the length of the selection or the
    /// length of the span.
    /// </summary>
    /// <param name="buffer"></param>
    /// <returns></returns>
    public int GetSelectedRegion(Span<char> buffer)
    {
        var maxCount = Math.Min(buffer.Length, _selectionLength);
        if (maxCount == 0)
        {
            return 0;
        }

        _sb.CopyTo(_cursorStart, buffer, maxCount);
        return maxCount;
    }

    /// <summary>
    /// Retrieves the current buffer contents and clears the buffer, resetting the cursor and selection positions.
    /// </summary>
    /// <returns></returns>
    public string ConsumeInput()
    {
        var result = _sb.ToString();
        Clear();
        return result;
    }

    /// <summary>
    /// Clears the buffer and resets the cursor and selection positions.
    /// </summary>
    public void Clear()
    {
        _sb.Clear();
        _cursorStart = 0;
        _selectionLength = 0;
    }


    private int _cursorStart, _selectionLength;
    private readonly StringBuilder _sb = new();
}
