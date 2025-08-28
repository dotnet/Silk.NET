// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Pointers;

internal class SdlTouchScreen : SdlDevice, ISdlDevice<SdlTouchScreen>, IPointerDevice
{
    public static SdlTouchScreen CreateDevice(uint sdlDeviceId, SdlInputBackend backend) => throw new NotImplementedException();

    public bool Equals(IInputDevice? other) => throw new NotImplementedException();

    public override string Name => throw new NotImplementedException();
    protected override void Release() => throw new NotImplementedException();

    public PointerState State => throw new NotImplementedException();

    public IReadOnlyList<IPointerTarget> Targets => throw new NotImplementedException();

    public SdlTouchScreen(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
    }
}
