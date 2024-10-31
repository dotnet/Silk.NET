// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_BUFFER_UAV_FLAG")]
    public enum BufferUavFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Raw\"")]
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_RAW")]
        BufferUavFlagRaw = 0x1,
        [Obsolete("Deprecated in favour of \"Append\"")]
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_APPEND")]
        BufferUavFlagAppend = 0x2,
        [Obsolete("Deprecated in favour of \"Counter\"")]
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_COUNTER")]
        BufferUavFlagCounter = 0x4,
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_RAW")]
        Raw = 0x1,
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_APPEND")]
        Append = 0x2,
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_COUNTER")]
        Counter = 0x4,
    }
}
