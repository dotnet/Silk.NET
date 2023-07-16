// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE"]/*'/>
public enum D3D10_SHADER_DEBUG_REGTYPE
{
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_INPUT"]/*'/>
    D3D10_SHADER_DEBUG_REG_INPUT,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_OUTPUT"]/*'/>
    D3D10_SHADER_DEBUG_REG_OUTPUT,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_CBUFFER"]/*'/>
    D3D10_SHADER_DEBUG_REG_CBUFFER,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_TBUFFER"]/*'/>
    D3D10_SHADER_DEBUG_REG_TBUFFER,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_TEMP"]/*'/>
    D3D10_SHADER_DEBUG_REG_TEMP,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_TEMPARRAY"]/*'/>
    D3D10_SHADER_DEBUG_REG_TEMPARRAY,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_TEXTURE"]/*'/>
    D3D10_SHADER_DEBUG_REG_TEXTURE,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_SAMPLER"]/*'/>
    D3D10_SHADER_DEBUG_REG_SAMPLER,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_IMMEDIATECBUFFER"]/*'/>
    D3D10_SHADER_DEBUG_REG_IMMEDIATECBUFFER,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_LITERAL"]/*'/>
    D3D10_SHADER_DEBUG_REG_LITERAL,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_UNUSED"]/*'/>
    D3D10_SHADER_DEBUG_REG_UNUSED,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D11_SHADER_DEBUG_REG_INTERFACE_POINTERS"]/*'/>
    D3D11_SHADER_DEBUG_REG_INTERFACE_POINTERS,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D11_SHADER_DEBUG_REG_UAV"]/*'/>
    D3D11_SHADER_DEBUG_REG_UAV,
    /// <include file='D3D10_SHADER_DEBUG_REGTYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_REGTYPE.D3D10_SHADER_DEBUG_REG_FORCE_DWORD"]/*'/>
    D3D10_SHADER_DEBUG_REG_FORCE_DWORD = 0x7fffffff,
}