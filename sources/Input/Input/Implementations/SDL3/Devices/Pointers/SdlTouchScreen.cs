// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlTouchScreen : SdlPointerDevice, ISdlDevice<SdlTouchScreen>, IPointerDevice
{
    public static SdlTouchScreen CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
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

    public SdlTouchScreen(uint sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unbounded) : base(backend, uniqueId, sdlDeviceId, unbounded)
    {
    }
}
