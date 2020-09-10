// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_TESSELLATOR_DOMAIN")]
    public enum TessellatorDomain
    {
        [NativeName("Name", "D3D_TESSELLATOR_DOMAIN_UNDEFINED")]
        TessellatorDomainUndefined = 0x0,
        [NativeName("Name", "D3D_TESSELLATOR_DOMAIN_ISOLINE")]
        TessellatorDomainIsoline = 0x1,
        [NativeName("Name", "D3D_TESSELLATOR_DOMAIN_TRI")]
        TessellatorDomainTri = 0x2,
        [NativeName("Name", "D3D_TESSELLATOR_DOMAIN_QUAD")]
        TessellatorDomainQuad = 0x3,
        [NativeName("Name", "D3D11_TESSELLATOR_DOMAIN_UNDEFINED")]
        D3D11TessellatorDomainUndefined = 0x0,
        [NativeName("Name", "D3D11_TESSELLATOR_DOMAIN_ISOLINE")]
        D3D11TessellatorDomainIsoline = 0x1,
        [NativeName("Name", "D3D11_TESSELLATOR_DOMAIN_TRI")]
        D3D11TessellatorDomainTri = 0x2,
        [NativeName("Name", "D3D11_TESSELLATOR_DOMAIN_QUAD")]
        D3D11TessellatorDomainQuad = 0x3,
    }
}
