// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTRANSFORMSTATETYPE")]
    public enum Transformstatetype : int
    {
        [NativeName("Name", "D3DTS_VIEW")]
        TSView = 0x2,
        [NativeName("Name", "D3DTS_PROJECTION")]
        TSProjection = 0x3,
        [NativeName("Name", "D3DTS_TEXTURE0")]
        TSTexture0 = 0x10,
        [NativeName("Name", "D3DTS_TEXTURE1")]
        TSTexture1 = 0x11,
        [NativeName("Name", "D3DTS_TEXTURE2")]
        TSTexture2 = 0x12,
        [NativeName("Name", "D3DTS_TEXTURE3")]
        TSTexture3 = 0x13,
        [NativeName("Name", "D3DTS_TEXTURE4")]
        TSTexture4 = 0x14,
        [NativeName("Name", "D3DTS_TEXTURE5")]
        TSTexture5 = 0x15,
        [NativeName("Name", "D3DTS_TEXTURE6")]
        TSTexture6 = 0x16,
        [NativeName("Name", "D3DTS_TEXTURE7")]
        TSTexture7 = 0x17,
        [NativeName("Name", "D3DTS_FORCE_DWORD")]
        TSForceDword = 0x7FFFFFFF,
    }
}
