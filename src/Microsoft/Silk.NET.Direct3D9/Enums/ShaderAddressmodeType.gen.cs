// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DSHADER_ADDRESSMODE_TYPE")]
    public enum ShaderAddressmodeType : int
    {
        [Obsolete("Deprecated in favour of \"Absolute\"")]
        [NativeName("Name", "D3DSHADER_ADDRMODE_ABSOLUTE")]
        ShaderAddrmodeAbsolute = 0x0,
        [Obsolete("Deprecated in favour of \"Relative\"")]
        [NativeName("Name", "D3DSHADER_ADDRMODE_RELATIVE")]
        ShaderAddrmodeRelative = 0x2000,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSHADER_ADDRMODE_FORCE_DWORD")]
        ShaderAddrmodeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSHADER_ADDRMODE_ABSOLUTE")]
        Absolute = 0x0,
        [NativeName("Name", "D3DSHADER_ADDRMODE_RELATIVE")]
        Relative = 0x2000,
        [NativeName("Name", "D3DSHADER_ADDRMODE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
