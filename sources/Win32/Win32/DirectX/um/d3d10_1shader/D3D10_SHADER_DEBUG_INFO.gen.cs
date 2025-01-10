// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_SHADER_DEBUG_INFO
{
    public uint Size;
    public uint Creator;
    public uint EntrypointName;
    public uint ShaderTarget;
    public uint CompileFlags;
    public uint Files;
    public uint FileInfo;
    public uint Instructions;
    public uint InstructionInfo;
    public uint Variables;
    public uint VariableInfo;
    public uint InputVariables;
    public uint InputVariableInfo;
    public uint Tokens;
    public uint TokenInfo;
    public uint Scopes;
    public uint ScopeInfo;
    public uint ScopeVariables;
    public uint ScopeVariableInfo;
    public uint UintOffset;
    public uint StringOffset;
}
