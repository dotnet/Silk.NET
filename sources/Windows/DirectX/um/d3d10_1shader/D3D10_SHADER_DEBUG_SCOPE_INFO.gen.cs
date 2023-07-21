// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO"]/*' />
public partial struct D3D10_SHADER_DEBUG_SCOPE_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO.ScopeType"]/*' />
    public D3D10_SHADER_DEBUG_SCOPETYPE ScopeType;

    /// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO.Name"]/*' />
    public uint Name;

    /// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO.uNameLen"]/*' />
    public uint uNameLen;

    /// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO.uVariables"]/*' />
    public uint uVariables;

    /// <include file='D3D10_SHADER_DEBUG_SCOPE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPE_INFO.VariableData"]/*' />
    public uint VariableData;
}
