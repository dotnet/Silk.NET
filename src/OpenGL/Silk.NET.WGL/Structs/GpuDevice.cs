// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.WGL;

public unsafe struct GpuDevice
{
    public uint Cb;
    public fixed byte DeviceName[32];
    public fixed byte DeviceString[128];
    public uint Flags;
    public Box2D<long> RcVirtualScreen;
}
