// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlTouchSurface : SdlPointerDevice, ISdlDevice<SdlTouchSurface>, IPointerDevice
{
    public static SdlTouchSurface CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        throw new NotImplementedException();
    }

    public bool Equals(IInputDevice? other)
    {
        throw new NotImplementedException();
    }

    public override string Name
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    protected override void Release()
    {
        throw new NotImplementedException();
    }

    protected override uint GetButtonMaskSdl() => throw new NotImplementedException();

    public override PointerState State
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    protected override bool OnePointOnly => false;

    public SdlTouchSurface(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unbounded) : base(backend, uniqueId, sdlDeviceId, unbounded)
    {
    }

    public void Event(in TouchFingerEvent finger, IPointerTarget? target, SdlInputBackend.FingerEventType fingerType)
    {
    }
}
