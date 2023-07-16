// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Size"]/*'/>
    public uint Size;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Creator"]/*'/>
    public uint Creator;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.EntrypointName"]/*'/>
    public uint EntrypointName;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.ShaderTarget"]/*'/>
    public uint ShaderTarget;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.CompileFlags"]/*'/>
    public uint CompileFlags;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Files"]/*'/>
    public uint Files;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.FileInfo"]/*'/>
    public uint FileInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Instructions"]/*'/>
    public uint Instructions;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.InstructionInfo"]/*'/>
    public uint InstructionInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Variables"]/*'/>
    public uint Variables;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.VariableInfo"]/*'/>
    public uint VariableInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.InputVariables"]/*'/>
    public uint InputVariables;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.InputVariableInfo"]/*'/>
    public uint InputVariableInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Tokens"]/*'/>
    public uint Tokens;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.TokenInfo"]/*'/>
    public uint TokenInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.Scopes"]/*'/>
    public uint Scopes;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.ScopeInfo"]/*'/>
    public uint ScopeInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.ScopeVariables"]/*'/>
    public uint ScopeVariables;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.ScopeVariableInfo"]/*'/>
    public uint ScopeVariableInfo;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.UintOffset"]/*'/>
    public uint UintOffset;
    /// <include file='D3D10_SHADER_DEBUG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INFO.StringOffset"]/*'/>
    public uint StringOffset;
}