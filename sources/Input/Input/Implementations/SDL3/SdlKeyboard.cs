// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard, ISdlDevice<SdlKeyboard>
{
    private readonly List<Button<KeyName>> _keyStates;
    public unsafe SdlKeyboard(uint sdlDeviceId, SdlInputBackend backend) : base(backend, uniqueId, sdlDeviceId)
    {
        _keyStates = new List<Button<KeyName>>((int)Scancode.ScancodeCount);
        _sdlDeviceId = sdlDeviceId;
        for (var i = 0; i < 512; i++)
        {
            _keyStates.Add(new Button<KeyName>((KeyName)i, false, 0f));
        }

        State = new KeyboardState(_keyStates, () => false, () => false);// todo : how do i get the num lock/capslock?
    }

    public static SdlKeyboard CreateDevice(uint sdlDeviceId, SdlInputBackend backend) => throw new NotImplementedException();

    public KeyboardState State { get; }
    protected override void Release() {} // empty?

    private readonly uint _sdlDeviceId;
    public override uint RefreshIdFromBackend() => _sdlDeviceId;

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

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name) =>
        throw new NotImplementedException();

    // todo - there should be a backend-independent way to do this text input handling via KeyboardState?
    public void BeginInput() => throw new NotImplementedException();

    public string? EndInput() => throw new NotImplementedException();

    public void AddKeyEvent(KeyboardEvent key)
    {
        const float fraction = 1f / 255f;
        _keyStates[(int)key.Key] = new Button<KeyName>((KeyName)key.Key, key.Down != 0, key.Down * fraction);
    }
}
