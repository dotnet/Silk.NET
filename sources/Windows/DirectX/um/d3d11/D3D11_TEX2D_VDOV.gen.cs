// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_TEX2D_VDOV.xml' path='doc/member[@name="D3D11_TEX2D_VDOV"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TEX2D_VDOV
{
    /// <include file='D3D11_TEX2D_VDOV.xml' path='doc/member[@name="D3D11_TEX2D_VDOV.ArraySlice"]/*' />
    public uint ArraySlice;
}
