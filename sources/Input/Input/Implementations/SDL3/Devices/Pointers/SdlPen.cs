// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, uint sdlDeviceId, string name, IPointerTarget unbounded) : base(backend, silkId, sdlDeviceId, unbounded)
    {
        Name = name;
    }

    public static SdlPen CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        throw new NotImplementedException();
    }

    protected override uint GetButtonMaskSdl()
    {
        throw new NotImplementedException();
    }

    public override PointerState State => throw new NotImplementedException();

    protected override bool OnePointOnly => true;


    public override string Name { get; }
    protected override void Release() => throw new NotImplementedException();
}
