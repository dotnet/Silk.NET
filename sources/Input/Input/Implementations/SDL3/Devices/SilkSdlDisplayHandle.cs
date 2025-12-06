// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3.Devices.Pointers.Targets;

internal readonly struct SilkSdlDisplayHandle
{
    public static readonly SilkSdlDisplayHandle AllDisplays = new(uint.MaxValue);
    public uint Id { get; }
    public SilkSdlDisplayHandle(uint id) => Id = id;
}
