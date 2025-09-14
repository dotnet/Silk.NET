// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal static class SdlKeyConversions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static KeyName ScancodeToKeyName(uint scancode) => (KeyName)scancode;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static KeyName ScancodeToKeyName(Scancode scancode) => ScancodeToKeyName((uint)scancode);

    public static unsafe KeyName SdlToKeyName(uint key, ISdl sdl, ushort? modState = null)
    {
        modState ??= sdl.GetModState();
        var modStateVal = modState.Value;
        return (KeyName)sdl.GetScancodeFromKey(key, &modStateVal);
    }

    /// <summary>
    /// Maps an SDL key id to a <see cref="KeyName"/> without a reference to an SDL backend instance.
    /// </summary>
    /// <param name="key">The sdl key id</param>
    /// <returns>The associated key name</returns>
    public static KeyName SdlToKeyName(uint key) =>
        // * indicates a shifted key
        key switch {
            Sdl.KApplication => KeyName.Application,

            >= Sdl.K1 and <= Sdl.K9 => (KeyName)(key - _numKeyDiff),
            >= Sdl.Ka and <= Sdl.Kz => (KeyName)(key - _letterKeyDiff),
            >= Sdl.KCapslock and <= Sdl.KKpEqualsas400 => (KeyName)(key - _systemAndKeypadDiff),
            >= Sdl.KCancel and <= Sdl.KRgui => (KeyName)(key - _systemAndKeypadDiff),
            >= Sdl.KMode and <= Sdl.KAcBookmarks => (KeyName)(key - _systemAndKeypadDiff),
            >= Sdl.KSoftleft and <= Sdl.KEndcall => (KeyName)(key - _systemNonHidKeyDiff),

            Sdl.KDelete => KeyName.Delete,
            Sdl.KUnknown => KeyName.Unknown,
            Sdl.KReturn => KeyName.Return,
            Sdl.KEscape => KeyName.Escape,
            Sdl.KBackspace => KeyName.Backspace,
            Sdl.KTab => KeyName.Tab,
            Sdl.KSpace => KeyName.Space,
            Sdl.KExclaim => KeyName.Number1, // *
            Sdl.KDblapostrophe => KeyName.Apostrophe, // *
            Sdl.KHash => KeyName.Number3, // *
            Sdl.KDollar => KeyName.Number4, // *
            Sdl.KPercent => KeyName.Number5, // *
            Sdl.KAmpersand => KeyName.KeypadAmpersand,
            Sdl.KApostrophe => KeyName.Apostrophe,
            Sdl.KLeftparen => KeyName.KeypadLeftParenthesis,
            Sdl.KRightparen => KeyName.KeypadRightParenthesis,
            Sdl.KAsterisk => KeyName.KeypadAmpersand,
            Sdl.KPlus => KeyName.Equals, // *
            Sdl.KComma => KeyName.Comma,
            Sdl.KMinus => KeyName.Minus,
            Sdl.KPeriod => KeyName.Period,
            Sdl.KSlash => KeyName.Slash,
            Sdl.K0 => KeyName.Number0,
            Sdl.KColon => KeyName.Semicolon, // *
            Sdl.KSemicolon => KeyName.Semicolon,
            Sdl.KLess => KeyName.Comma, // *
            Sdl.KEquals => KeyName.Equals,
            Sdl.KGreater => KeyName.Period, // *
            Sdl.KQuestion => KeyName.Slash, // *
            Sdl.KAt => KeyName.Number2, // *
            Sdl.KLeftbracket => KeyName.LeftBracket,
            Sdl.KBackslash => KeyName.Backslash,
            Sdl.KRightbracket => KeyName.RightBracket,
            Sdl.KCaret => KeyName.Number6, // *
            Sdl.KUnderscore => KeyName.Minus, // *
            Sdl.KGrave => KeyName.Grave,
            Sdl.KLeftbrace => KeyName.LeftBracket, // *
            Sdl.KPipe => KeyName.Backslash, // *
            Sdl.KRightbrace => KeyName.RightBracket, // *
            Sdl.KTilde => KeyName.Grave, // *
            _ => (KeyName)key
        };

    /// <summary>
    /// Converts a <see cref="KeyName"/> to an SDL key id.
    /// </summary>
    /// <param name="key">The name of the key you would like to get an Sdl key id for</param>
    /// <param name="sdl">Sdl backend instance</param>
    /// <param name="asKeyEvent">Will this key be used in a key event?</param>
    /// <param name="modState">The current modifier key state</param>
    /// <returns>The sdl key id</returns>
    public static uint KeyNameToSdl(KeyName key, ISdl sdl, bool asKeyEvent, ushort? modState = null)
    {
        modState ??= sdl.GetModState();
        var scanCode = (uint)key;
        var asKeyEventByte = asKeyEvent ? (byte)1 : (byte)0;
        return sdl.GetKeyFromScancode((Scancode)scanCode, modState.Value, asKeyEventByte);
    }

    private const uint _letterKeyDiff = Sdl.Ka - (uint)KeyName.A;
    private const uint _numKeyDiff = Sdl.K1 - (uint)KeyName.Number1;
    private const uint _systemAndKeypadDiff = Sdl.KPrintscreen - (uint)KeyName.PrintScreen;
    private const uint _systemNonHidKeyDiff = Sdl.KSoftleft - (uint)KeyName.SoftLeft;
}
