﻿// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_TEX3D_RTV.xml' path='doc/member[@name="D3D11_TEX3D_RTV"]/*' />
public partial struct D3D11_TEX3D_RTV
{
    /// <include file='D3D11_TEX3D_RTV.xml' path='doc/member[@name="D3D11_TEX3D_RTV.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D11_TEX3D_RTV.xml' path='doc/member[@name="D3D11_TEX3D_RTV.FirstWSlice"]/*' />
    public uint FirstWSlice;

    /// <include file='D3D11_TEX3D_RTV.xml' path='doc/member[@name="D3D11_TEX3D_RTV.WSize"]/*' />
    public uint WSize;
}