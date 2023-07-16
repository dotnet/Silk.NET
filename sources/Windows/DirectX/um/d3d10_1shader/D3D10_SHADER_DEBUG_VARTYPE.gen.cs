// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_VARTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VARTYPE"]/*'/>
public enum D3D10_SHADER_DEBUG_VARTYPE
{
    /// <include file='D3D10_SHADER_DEBUG_VARTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VARTYPE.D3D10_SHADER_DEBUG_VAR_VARIABLE"]/*'/>
    D3D10_SHADER_DEBUG_VAR_VARIABLE,
    /// <include file='D3D10_SHADER_DEBUG_VARTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VARTYPE.D3D10_SHADER_DEBUG_VAR_FUNCTION"]/*'/>
    D3D10_SHADER_DEBUG_VAR_FUNCTION,
    /// <include file='D3D10_SHADER_DEBUG_VARTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VARTYPE.D3D10_SHADER_DEBUG_VAR_FORCE_DWORD"]/*'/>
    D3D10_SHADER_DEBUG_VAR_FORCE_DWORD = 0x7fffffff,
}