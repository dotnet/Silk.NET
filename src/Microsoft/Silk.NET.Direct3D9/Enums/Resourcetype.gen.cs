// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRESOURCETYPE")]
    public enum Resourcetype
    {
        [NativeName("Name", "D3DRTYPE_SURFACE")]
        RtypeSurface = 0x1,
        [NativeName("Name", "D3DRTYPE_VOLUME")]
        RtypeVolume = 0x2,
        [NativeName("Name", "D3DRTYPE_TEXTURE")]
        RtypeTexture = 0x3,
        [NativeName("Name", "D3DRTYPE_VOLUMETEXTURE")]
        RtypeVolumetexture = 0x4,
        [NativeName("Name", "D3DRTYPE_CUBETEXTURE")]
        RtypeCubetexture = 0x5,
        [NativeName("Name", "D3DRTYPE_VERTEXBUFFER")]
        RtypeVertexbuffer = 0x6,
        [NativeName("Name", "D3DRTYPE_INDEXBUFFER")]
        RtypeIndexbuffer = 0x7,
        [NativeName("Name", "D3DRTYPE_FORCE_DWORD")]
        RtypeForceDword = 0x7FFFFFFF,
    }
}
