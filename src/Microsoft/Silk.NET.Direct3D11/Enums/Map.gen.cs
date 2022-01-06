// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_MAP")]
    public enum Map : int
    {
        [NativeName("Name", "D3D11_MAP_READ")]
        MapRead = 0x1,
        [NativeName("Name", "D3D11_MAP_WRITE")]
        MapWrite = 0x2,
        [NativeName("Name", "D3D11_MAP_READ_WRITE")]
        MapReadWrite = 0x3,
        [NativeName("Name", "D3D11_MAP_WRITE_DISCARD")]
        MapWriteDiscard = 0x4,
        [NativeName("Name", "D3D11_MAP_WRITE_NO_OVERWRITE")]
        MapWriteNoOverwrite = 0x5,
    }
}
