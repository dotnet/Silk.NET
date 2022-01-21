// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_BUFFER_SRV_FLAGS")]
    public enum BufferSrvFlags : int
    {
        [NativeName("Name", "D3D12_BUFFER_SRV_FLAG_NONE")]
        BufferSrvFlagNone = 0x0,
        [NativeName("Name", "D3D12_BUFFER_SRV_FLAG_RAW")]
        BufferSrvFlagRaw = 0x1,
    }
}
