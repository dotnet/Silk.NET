// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE"]/*'/>
public enum D3D10_SHADER_DEBUG_SCOPETYPE
{
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_GLOBAL"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_GLOBAL,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_BLOCK"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_BLOCK,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_FORLOOP"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_FORLOOP,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_STRUCT"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_STRUCT,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_FUNC_PARAMS"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_FUNC_PARAMS,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_STATEBLOCK"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_STATEBLOCK,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_NAMESPACE"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_NAMESPACE,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_ANNOTATION"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_ANNOTATION,
    /// <include file='D3D10_SHADER_DEBUG_SCOPETYPE.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPETYPE.D3D10_SHADER_DEBUG_SCOPE_FORCE_DWORD"]/*'/>
    D3D10_SHADER_DEBUG_SCOPE_FORCE_DWORD = 0x7fffffff,
}