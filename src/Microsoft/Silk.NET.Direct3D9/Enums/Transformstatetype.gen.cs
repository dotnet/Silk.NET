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
        [Obsolete("Deprecated in favour of \"View\"")]
        [NativeName("Name", "D3DTS_VIEW")]
        TSView = 0x2,
        [Obsolete("Deprecated in favour of \"Projection\"")]
        [NativeName("Name", "D3DTS_PROJECTION")]
        TSProjection = 0x3,
        [Obsolete("Deprecated in favour of \"Texture0\"")]
        [NativeName("Name", "D3DTS_TEXTURE0")]
        TSTexture0 = 0x10,
        [Obsolete("Deprecated in favour of \"Texture1\"")]
        [NativeName("Name", "D3DTS_TEXTURE1")]
        TSTexture1 = 0x11,
        [Obsolete("Deprecated in favour of \"Texture2\"")]
        [NativeName("Name", "D3DTS_TEXTURE2")]
        TSTexture2 = 0x12,
        [Obsolete("Deprecated in favour of \"Texture3\"")]
        [NativeName("Name", "D3DTS_TEXTURE3")]
        TSTexture3 = 0x13,
        [Obsolete("Deprecated in favour of \"Texture4\"")]
        [NativeName("Name", "D3DTS_TEXTURE4")]
        TSTexture4 = 0x14,
        [Obsolete("Deprecated in favour of \"Texture5\"")]
        [NativeName("Name", "D3DTS_TEXTURE5")]
        TSTexture5 = 0x15,
        [Obsolete("Deprecated in favour of \"Texture6\"")]
        [NativeName("Name", "D3DTS_TEXTURE6")]
        TSTexture6 = 0x16,
        [Obsolete("Deprecated in favour of \"Texture7\"")]
        [NativeName("Name", "D3DTS_TEXTURE7")]
        TSTexture7 = 0x17,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTS_FORCE_DWORD")]
        TSForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTS_VIEW")]
        View = 0x2,
        [NativeName("Name", "D3DTS_PROJECTION")]
        Projection = 0x3,
        [NativeName("Name", "D3DTS_TEXTURE0")]
        Texture0 = 0x10,
        [NativeName("Name", "D3DTS_TEXTURE1")]
        Texture1 = 0x11,
        [NativeName("Name", "D3DTS_TEXTURE2")]
        Texture2 = 0x12,
        [NativeName("Name", "D3DTS_TEXTURE3")]
        Texture3 = 0x13,
        [NativeName("Name", "D3DTS_TEXTURE4")]
        Texture4 = 0x14,
        [NativeName("Name", "D3DTS_TEXTURE5")]
        Texture5 = 0x15,
        [NativeName("Name", "D3DTS_TEXTURE6")]
        Texture6 = 0x16,
        [NativeName("Name", "D3DTS_TEXTURE7")]
        Texture7 = 0x17,
        [NativeName("Name", "D3DTS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
