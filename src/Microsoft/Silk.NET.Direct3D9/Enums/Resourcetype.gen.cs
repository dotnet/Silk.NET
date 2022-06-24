// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRESOURCETYPE")]
    public enum Resourcetype : int
    {
        [Obsolete("Deprecated in favour of \"Surface\"")]
        [NativeName("Name", "D3DRTYPE_SURFACE")]
        RtypeSurface = 0x1,
        [Obsolete("Deprecated in favour of \"Volume\"")]
        [NativeName("Name", "D3DRTYPE_VOLUME")]
        RtypeVolume = 0x2,
        [Obsolete("Deprecated in favour of \"Texture\"")]
        [NativeName("Name", "D3DRTYPE_TEXTURE")]
        RtypeTexture = 0x3,
        [Obsolete("Deprecated in favour of \"Volumetexture\"")]
        [NativeName("Name", "D3DRTYPE_VOLUMETEXTURE")]
        RtypeVolumetexture = 0x4,
        [Obsolete("Deprecated in favour of \"Cubetexture\"")]
        [NativeName("Name", "D3DRTYPE_CUBETEXTURE")]
        RtypeCubetexture = 0x5,
        [Obsolete("Deprecated in favour of \"Vertexbuffer\"")]
        [NativeName("Name", "D3DRTYPE_VERTEXBUFFER")]
        RtypeVertexbuffer = 0x6,
        [Obsolete("Deprecated in favour of \"Indexbuffer\"")]
        [NativeName("Name", "D3DRTYPE_INDEXBUFFER")]
        RtypeIndexbuffer = 0x7,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DRTYPE_FORCE_DWORD")]
        RtypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DRTYPE_SURFACE")]
        Surface = 0x1,
        [NativeName("Name", "D3DRTYPE_VOLUME")]
        Volume = 0x2,
        [NativeName("Name", "D3DRTYPE_TEXTURE")]
        Texture = 0x3,
        [NativeName("Name", "D3DRTYPE_VOLUMETEXTURE")]
        Volumetexture = 0x4,
        [NativeName("Name", "D3DRTYPE_CUBETEXTURE")]
        Cubetexture = 0x5,
        [NativeName("Name", "D3DRTYPE_VERTEXBUFFER")]
        Vertexbuffer = 0x6,
        [NativeName("Name", "D3DRTYPE_INDEXBUFFER")]
        Indexbuffer = 0x7,
        [NativeName("Name", "D3DRTYPE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
