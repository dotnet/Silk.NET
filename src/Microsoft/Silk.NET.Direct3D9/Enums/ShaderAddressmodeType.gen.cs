// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_ADDRESSMODE_TYPE")]
    public enum ShaderAddressmodeType
    {
        [NativeName("Name", "D3DSHADER_ADDRMODE_ABSOLUTE")]
        ShaderAddrmodeAbsolute = 0x0,
        [NativeName("Name", "D3DSHADER_ADDRMODE_RELATIVE")]
        ShaderAddrmodeRelative = 0x2000,
        [NativeName("Name", "D3DSHADER_ADDRMODE_FORCE_DWORD")]
        ShaderAddrmodeForceDword = 0x7FFFFFFF,
    }
}
