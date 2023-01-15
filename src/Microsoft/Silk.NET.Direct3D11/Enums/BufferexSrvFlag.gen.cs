// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BUFFEREX_SRV_FLAG")]
    public enum BufferexSrvFlag : int
    {
        [Obsolete("Deprecated in favour of \"Raw\"")]
        [NativeName("Name", "D3D11_BUFFEREX_SRV_FLAG_RAW")]
        BufferexSrvFlagRaw = 0x1,
        [NativeName("Name", "D3D11_BUFFEREX_SRV_FLAG_RAW")]
        Raw = 0x1,
    }
}
