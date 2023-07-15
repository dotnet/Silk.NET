// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_TOKEN_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO.File"]/*'/>
    public uint File;
    /// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO.Line"]/*'/>
    public uint Line;
    /// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO.Column"]/*'/>
    public uint Column;
    /// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO.TokenLength"]/*'/>
    public uint TokenLength;
    /// <include file='D3D10_SHADER_DEBUG_TOKEN_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_TOKEN_INFO.TokenId"]/*'/>
    public uint TokenId;
}