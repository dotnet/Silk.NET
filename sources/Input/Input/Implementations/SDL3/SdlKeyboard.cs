// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal partial class SdlKeyboard : SdlDevice, IKeyboard, ISdlDevice<SdlKeyboard>
{
    public KeyboardState State { get; }
    public override string Name => NativeBackend.GetKeyboardNameForID(SdlDeviceId).ReadToString();
    public string? ClipboardText
    {
        get => NativeBackend.HasClipboardText() ? NativeBackend.GetClipboardText().ReadToString() : null;
        set => NativeBackend.SetClipboardText(value);
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

    private SdlKeyboard(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId, sdlDeviceId)
    {
        Span<Button<KeyName>> keyStates = stackalloc Button<KeyName>[(int)KeyName.EndCall + 1];
        int keyCount = 0;
        for (var i = 0; i < 512; i++)
        {
            var keyName = (KeyName)i;
            if (Enum.IsDefined(keyName))
            {
                keyStates[keyCount++] = new Button<KeyName>((KeyName)i, false, 0f);
            }
        }

        _keyStates = keyStates[..keyCount].ToArray();
        _modState = NativeBackend.GetModState();

        State = new KeyboardState(
            keys: _keyStates,
            capsLockActive: () => (_modState & Sdl.KmodCaps) == Sdl.KmodCaps,
            numLockActive: () => (_modState & Sdl.KmodNum) == Sdl.KmodNum);
    }


    protected override void Release()
    {
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
    public void BeginInput()
    {
        _textIsRecording = true;
        _textRecorder ??= new TextRecorder();
    }

    public string? EndInput()
    {
        _textIsRecording = false;
        return _textRecorder?.ConsumeInput();
    }

    /// <summary>
    /// Updates the internal modifier state.
    /// </summary>
    /// <remarks>
    /// This should be called every frame the keyboard is updated in <see cref="SdlInputBackend"/>.
    /// This mod state is purely used for sdl-related calls and modifiers that are independent of key state (e.g. numlock, caps lock)
    /// - otherwise, we handle the modifier states with our standard key handling logic
    /// </remarks>
    public void UpdateModState() => _modState = NativeBackend.GetModState();

    public void AddKeyEvent(in KeyboardEvent key)
    {
        const float fraction = 1f / 255f;
        var keyName = ScancodeToKeyName(key.Scancode); // SdlToKeyName(key.Which);

        if (Enum.IsDefined(keyName))
        {
            var index = EnumInfo<KeyName>.ValueIndexOf(keyName);
            _keyStates[index] = new Button<KeyName>(keyName, key.Down != 0, key.Down * fraction);

            if (_textIsRecording)
            {
                _textRecorder!.AddKeyStroke(keyName, key.Down != 0);
            }
        }
    }


    private TextRecorder? _textRecorder;
    private bool _textIsRecording;
    private ushort _modState;
    private readonly Button<KeyName>[] _keyStates;
    private const uint _letterKeyDiff = Sdl.Ka - (uint)KeyName.A;
    private const uint _numKeyDiff = Sdl.K1 - (uint)KeyName.Number1;
    private const uint _systemAndKeypadDiff = Sdl.KPrintscreen - (uint)KeyName.PrintScreen;
    private const uint _systemNonHidKeyDiff = Sdl.KSoftleft - (uint)KeyName.SoftLeft;
}
