// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MAP")]
    public enum Map : int
    {
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "D3D11_MAP_READ")]
        MapRead = 0x1,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "D3D11_MAP_WRITE")]
        MapWrite = 0x2,
        [Obsolete("Deprecated in favour of \"ReadWrite\"")]
        [NativeName("Name", "D3D11_MAP_READ_WRITE")]
        MapReadWrite = 0x3,
        [Obsolete("Deprecated in favour of \"WriteDiscard\"")]
        [NativeName("Name", "D3D11_MAP_WRITE_DISCARD")]
        MapWriteDiscard = 0x4,
        [Obsolete("Deprecated in favour of \"WriteNoOverwrite\"")]
        [NativeName("Name", "D3D11_MAP_WRITE_NO_OVERWRITE")]
        MapWriteNoOverwrite = 0x5,
        [NativeName("Name", "D3D11_MAP_READ")]
        Read = 0x1,
        [NativeName("Name", "D3D11_MAP_WRITE")]
        Write = 0x2,
        [NativeName("Name", "D3D11_MAP_READ_WRITE")]
        ReadWrite = 0x3,
        [NativeName("Name", "D3D11_MAP_WRITE_DISCARD")]
        WriteDiscard = 0x4,
        [NativeName("Name", "D3D11_MAP_WRITE_NO_OVERWRITE")]
        WriteNoOverwrite = 0x5,
    }
}
