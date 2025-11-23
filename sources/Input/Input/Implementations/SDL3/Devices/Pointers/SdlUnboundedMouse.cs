// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal class SdlUnboundedMouse : SdlDevice, IMouse, ISdlDevice<SdlUnboundedMouse>
{
    private SdlUnboundedMouse(uint sdlDeviceId, nint silkId, SdlInputBackend backend, ICursorConfiguration cursor) : base(backend, silkId, sdlDeviceId)
    {
        Cursor = cursor;
    }


    public MouseState State => throw new NotImplementedException();
    public static SdlUnboundedMouse? CreateDevice(uint sdlDeviceId, SdlInputBackend backend)
    {
        throw new NotImplementedException();
    }

    public override string Name => NativeBackend.GetMouseNameForID(SdlDeviceId).ReadToString();

    public ICursorConfiguration Cursor { get; }

    public bool TrySetPosition(Vector2 position) => throw new NotImplementedException();

    public IReadOnlyList<IPointerTarget> Targets => throw new NotImplementedException();

    protected override void Release()
    {
        // nothing?
    }
}
