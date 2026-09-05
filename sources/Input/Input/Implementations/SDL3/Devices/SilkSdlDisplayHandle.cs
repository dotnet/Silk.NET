// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

[StructLayout(LayoutKind.Explicit, Size = sizeof(uint), Pack = 1)]
internal readonly struct SilkSdlDisplayHandle
{
    [FieldOffset(0)] public readonly uint Id;

    private SilkSdlDisplayHandle(uint id) => Id = id;

    public static readonly SilkSdlDisplayHandle AllDisplays = new(uint.MaxValue);
}
