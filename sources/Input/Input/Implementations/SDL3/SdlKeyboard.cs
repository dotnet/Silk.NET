// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard
{
    public override string Name
    {
        get
        {
            var namePtr = Backend.Sdl.GetKeyboardNameForID(Backend.AsSdlId(Id));
            ref var casted = ref Unsafe.As<sbyte,byte>(ref namePtr[0]);
            var marshalled = SilkMarshal.NativeToString(ref casted);
            return marshalled ?? "Unknown Sdl Keyboard";
        }
    }

    public KeyboardState State { get; } = new ();

    public string? ClipboardText
    {
        get
        {
            if(Sdl.Instance.HasClipboardText() == 0)
                return null;

            return Sdl.Instance.GetClipboardText().ReadToString();
        }
        set => throw new NotImplementedException("Setting clipboard text is not implemented in SDL3 backend.");
    }

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name) =>
        throw new NotImplementedException();

    // todo - there should be a backend-independent way to do this text input handling via KeyboardState?
    public void BeginInput() => throw new NotImplementedException();

    public string? EndInput() => throw new NotImplementedException();
}
