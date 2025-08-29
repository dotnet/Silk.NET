// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Guid = Silk.NET.SDL.Guid;

namespace Silk.NET.Input.SDL3.Pointers;

internal class SdlPen : SdlBoundedPointerDevice, ISdlDevice<SdlPen>
{
    public static SdlPen CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        throw new NotImplementedException();
    }

    public override PointerState State => throw new NotImplementedException();

    public SdlPen(uint sdlDeviceId, SdlInputBackend backend, IReadOnlyList<IPointerTarget> targets, InputMarshal.ListOwner<TargetPoint> boundedPoints) : base(sdlDeviceId, backend, targets, boundedPoints)
    {
    }

    public override uint SdlDeviceId => NativeBackend.guid;

    protected override Guid SdlDeviceGuid => throw new NotImplementedException();
}
