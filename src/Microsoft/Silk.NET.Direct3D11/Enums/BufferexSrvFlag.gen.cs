// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BUFFEREX_SRV_FLAG")]
    public enum BufferexSrvFlag : int
    {
        [NativeName("Name", "D3D11_BUFFEREX_SRV_FLAG_RAW")]
        BufferexSrvFlagRaw = 0x1,
    }
}
