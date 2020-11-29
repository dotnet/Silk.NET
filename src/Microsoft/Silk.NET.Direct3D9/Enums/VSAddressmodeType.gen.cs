// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVS_ADDRESSMODE_TYPE")]
    public enum VSAddressmodeType
    {
        [NativeName("Name", "D3DVS_ADDRMODE_ABSOLUTE")]
        VSAddrmodeAbsolute = 0x0,
        [NativeName("Name", "D3DVS_ADDRMODE_RELATIVE")]
        VSAddrmodeRelative = 0x2000,
        [NativeName("Name", "D3DVS_ADDRMODE_FORCE_DWORD")]
        VSAddrmodeForceDword = 0x7FFFFFFF,
    }
}
