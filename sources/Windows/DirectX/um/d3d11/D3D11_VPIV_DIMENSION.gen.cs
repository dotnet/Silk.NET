// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VPIV_DIMENSION.xml' path='doc/member[@name="D3D11_VPIV_DIMENSION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VPIV_DIMENSION
{
    /// <include file='D3D11_VPIV_DIMENSION.xml' path='doc/member[@name="D3D11_VPIV_DIMENSION.D3D11_VPIV_DIMENSION_UNKNOWN"]/*'/>
    D3D11_VPIV_DIMENSION_UNKNOWN = 0,
    /// <include file='D3D11_VPIV_DIMENSION.xml' path='doc/member[@name="D3D11_VPIV_DIMENSION.D3D11_VPIV_DIMENSION_TEXTURE2D"]/*'/>
    D3D11_VPIV_DIMENSION_TEXTURE2D = 1,
}