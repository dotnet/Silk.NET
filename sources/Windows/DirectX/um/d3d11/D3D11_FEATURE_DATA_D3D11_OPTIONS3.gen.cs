// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS3.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS3"]/*' />
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS3
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS3.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS3.VPAndRTArrayIndexFromAnyShaderFeedingRasterizer"]/*' />
    public BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizer;
}
