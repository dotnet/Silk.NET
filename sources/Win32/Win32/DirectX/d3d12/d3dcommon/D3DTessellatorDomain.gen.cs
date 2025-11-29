// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN"]/*'/>
public enum D3DTessellatorDomain
{
    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    DTessellatorDomainUndefined = 0,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    DTessellatorDomainIsoline = 1,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_TRI"]/*'/>

    DTessellatorDomainTri = 2,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    DTessellatorDomainQuad = 3,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    D11TessellatorDomainUndefined = DTessellatorDomainUndefined,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    D11TessellatorDomainIsoline = DTessellatorDomainIsoline,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_TRI"]/*'/>

    D11TessellatorDomainTri = DTessellatorDomainTri,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    D11TessellatorDomainQuad = DTessellatorDomainQuad,
}
