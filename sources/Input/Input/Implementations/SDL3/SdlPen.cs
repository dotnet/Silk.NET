// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

internal class SdlPen : SdlBoundedPointerDevice
{
    private uint _penId;

    public SdlPen(SdlInputBackend backend, uint pen)
        : base(backend)
    {
        _penId = pen;
    }

    public override IntPtr Id => HashCode.Combine(Backend.Id, _penId);

    public override string Name => throw new NotImplementedException();

    public override PointerState State => throw new NotImplementedException();
}
