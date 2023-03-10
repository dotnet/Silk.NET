// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BARRIER_TYPE")]
    public enum BarrierType : int
    {
        [Obsolete("Deprecated in favour of \"Global\"")]
        [NativeName("Name", "D3D12_BARRIER_TYPE_GLOBAL")]
        BarrierTypeGlobal = 0x0,
        [Obsolete("Deprecated in favour of \"Texture\"")]
        [NativeName("Name", "D3D12_BARRIER_TYPE_TEXTURE")]
        BarrierTypeTexture = 0x1,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D12_BARRIER_TYPE_BUFFER")]
        BarrierTypeBuffer = 0x2,
        [NativeName("Name", "D3D12_BARRIER_TYPE_GLOBAL")]
        Global = 0x0,
        [NativeName("Name", "D3D12_BARRIER_TYPE_TEXTURE")]
        Texture = 0x1,
        [NativeName("Name", "D3D12_BARRIER_TYPE_BUFFER")]
        Buffer = 0x2,
    }
}
