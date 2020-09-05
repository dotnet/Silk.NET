// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BUFFER_UAV_FLAG")]
    public enum BufferUavFlag
    {
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_RAW")]
        BufferUavFlagRaw = 0x1,
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_APPEND")]
        BufferUavFlagAppend = 0x2,
        [NativeName("Name", "D3D11_BUFFER_UAV_FLAG_COUNTER")]
        BufferUavFlagCounter = 0x4,
    }
}
