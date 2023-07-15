// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS4.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS4"]/*'/>
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS4
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS4.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS4.ExtendedNV12SharedTextureSupported"]/*'/>
    public BOOL ExtendedNV12SharedTextureSupported;
}