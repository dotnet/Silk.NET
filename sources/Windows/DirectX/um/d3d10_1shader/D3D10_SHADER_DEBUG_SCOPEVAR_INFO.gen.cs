// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_SCOPEVAR_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.TokenId"]/*'/>
    public uint TokenId;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.VarType"]/*'/>
    public D3D10_SHADER_DEBUG_VARTYPE VarType;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.Class"]/*'/>
    [NativeTypeName("D3D10_SHADER_VARIABLE_CLASS")]
    public D3D_SHADER_VARIABLE_CLASS Class;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.Rows"]/*'/>
    public uint Rows;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.Columns"]/*'/>
    public uint Columns;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.StructMemberScope"]/*'/>
    public uint StructMemberScope;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.uArrayIndices"]/*'/>
    public uint uArrayIndices;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.ArrayElements"]/*'/>
    public uint ArrayElements;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.ArrayStrides"]/*'/>
    public uint ArrayStrides;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.uVariables"]/*'/>
    public uint uVariables;
    /// <include file='D3D10_SHADER_DEBUG_SCOPEVAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_SCOPEVAR_INFO.uFirstVariable"]/*'/>
    public uint uFirstVariable;
}