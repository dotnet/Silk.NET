// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Pointers;

internal class SdlPen : SdlBoundedPointerDevice, ISdlDevice<SdlPen>
{
    public static SdlPen CreateDevice(SdlInputBackend backend, uint sdlDeviceId) => throw new NotImplementedException();

    public override PointerState State => throw new NotImplementedException();

    public SdlPen(uint sdlDeviceId, SdlInputBackend backend, IReadOnlyList<IPointerTarget> targets, InputMarshal.ListOwner<TargetPoint> boundedPoints) : base(sdlDeviceId, backend, targets, boundedPoints)
    {
    }
}
