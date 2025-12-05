// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlPen : SdlPointerDevice, ISdlDevice<SdlPen>
{
    public SdlPen(SdlInputBackend backend, nint silkId, uint sdlDeviceId, IReadOnlyList<IPointerTarget> targets, string name) : base(backend, silkId, sdlDeviceId)
    {
        Targets = targets;
        Name = name;
    }

    public static SdlPen CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        throw new NotImplementedException();
    }

    public override PointerState State => throw new NotImplementedException();
    public override IReadOnlyList<IPointerTarget> Targets { get; }
    protected override bool IsBounded => true; // should this always be bounded?


    public override string Name { get; }
    protected override void Release() => throw new NotImplementedException();
}
