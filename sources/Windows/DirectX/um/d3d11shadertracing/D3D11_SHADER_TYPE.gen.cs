// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_SHADER_TYPE
{
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_VERTEX_SHADER"]/*'/>
    D3D11_VERTEX_SHADER = 1,
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_HULL_SHADER"]/*'/>
    D3D11_HULL_SHADER = 2,
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_DOMAIN_SHADER"]/*'/>
    D3D11_DOMAIN_SHADER = 3,
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_GEOMETRY_SHADER"]/*'/>
    D3D11_GEOMETRY_SHADER = 4,
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_PIXEL_SHADER"]/*'/>
    D3D11_PIXEL_SHADER = 5,
    /// <include file='D3D11_SHADER_TYPE.xml' path='doc/member[@name="D3D11_SHADER_TYPE.D3D11_COMPUTE_SHADER"]/*'/>
    D3D11_COMPUTE_SHADER = 6,
}