// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input.SDL3.Pointers;

internal class SdlUnboundedMouse : SdlDevice, IMouse
{
    public SdlUnboundedMouse(uint sdlDeviceId, SdlInputBackend backend) : base(sdlDeviceId, backend)
    {
    }

    public override unsafe void* DeviceHandle => throw new NotImplementedException();

    public override string Name => throw new NotImplementedException();

    public MouseState State => throw new NotImplementedException();

    public ICursorConfiguration Cursor => Backend;

    public bool TrySetPosition(Vector2 position) => throw new NotImplementedException();

    public IReadOnlyList<IPointerTarget> Targets => throw new NotImplementedException();
}
