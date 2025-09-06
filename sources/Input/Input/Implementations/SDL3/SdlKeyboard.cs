// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard, ISdlDevice<SdlKeyboard>
{
    private readonly List<Button<KeyName>> _keyStates;
    public unsafe SdlKeyboard(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId, sdlDeviceId)
    {
        _keyStates = new List<Button<KeyName>>((int)Scancode.ScancodeCount);
        _sdlDeviceId = sdlDeviceId;
        for (var i = 0; i < 512; i++)
        {
            _keyStates.Add(new Button<KeyName>((KeyName)i, false, 0f));
        }

        State = new KeyboardState(_keyStates, () => false, () => false);// todo : how do i get the num lock/capslock?
        _modState = NativeBackend.GetModState();
    }

    public static SdlKeyboard CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        var namePtr = backend.Sdl.GetKeyboardNameForID(sdlDeviceId);
        nint uniqueId = 0;
        if (backend.AttemptUniqueId(namePtr, ref uniqueId))
        {
            return new SdlKeyboard(sdlDeviceId, uniqueId, backend);
        }

        uniqueId = backend.FallbackUniqueId(sdlDeviceId, uniqueId);
        return new SdlKeyboard(sdlDeviceId, uniqueId, backend);
    }

    public KeyboardState State { get; }
    protected override void Release() {} // empty?


    public override string Name => NativeBackend.GetKeyboardNameForID(SdlDeviceId).ReadToString();
    public string? ClipboardText
    {
        get
        {
            if(Sdl.Instance.HasClipboardText() == 0)
                return null;

            return Sdl.Instance.GetClipboardText().ReadToString();
        }
        set => Sdl.Instance.SetClipboardText(value);
        //throw new NotImplementedException("Setting clipboard text is not implemented in SDL3 backend.");
    }

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name)
    {
        // todo: should 'asKeyEvent' be true?
        var sdlKey = KeyNameToSdl(key, NativeBackend, true, _modState);
        var namePtr = NativeBackend.GetKeyName(sdlKey);
        name = namePtr.ReadToString();
        return !string.IsNullOrWhiteSpace(name);
    }


    // todo - there should be a backend-independent way to do this text input handling via KeyboardState?
    public void BeginInput() => throw new NotImplementedException();

    public string? EndInput() => throw new NotImplementedException();

    public void UpdateModState()
    {
        // this mod state is purely used for sdl-related calls - otherwise, we handle the modifier states with our
        // standard key handling logic
        _modState = NativeBackend.GetModState();
    }

    public void AddKeyEvent(in KeyboardEvent key)
    {
        const float fraction = 1f / 255f;
        var keyName = ScancodeToKeyName(key.Scancode); // SdlToKeyName(key.Which);
        _keyStates[(int)key.Key] = new Button<KeyName>(keyName, key.Down != 0, key.Down * fraction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static KeyName ScancodeToKeyName(uint scancode) => (KeyName)scancode;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static KeyName ScancodeToKeyName(Scancode scancode) => ScancodeToKeyName((uint)scancode);

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
            Sdl.KApplication =>KeyName.Application,

            >= Sdl.K1 and <= Sdl.K9 => (KeyName)(key - _numKeyDiff),
            >= Sdl.Ka and <= Sdl.Kz => (KeyName)(key - _letterKeyDiff),
            >= Sdl.KCapslock and <= Sdl.KKpEqualsas400 => (KeyName)(key - _systemAndKeypadDiff),
            >= Sdl.KCancel and <= Sdl.KRgui => (KeyName)(key - _systemAndKeypadDiff),
            >= Sdl.KMode and <= Sdl.KAcBookmarks=> (KeyName)(key - _systemAndKeypadDiff),
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
    /// The reverse operation of <see cref="SdlToKeyName"/>,
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

    private ushort _modState;
    private const uint _letterKeyDiff = Sdl.Ka - (uint)KeyName.A;
    private const uint _numKeyDiff = Sdl.K1 - (uint)KeyName.Number1;
    private const uint _systemAndKeypadDiff = Sdl.KPrintscreen - (uint)KeyName.PrintScreen;
    private const uint _systemNonHidKeyDiff = Sdl.KSoftleft - (uint)KeyName.SoftLeft;
}
