// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_SHADER_DEBUG_INST_INFO
{
    public uint Id;
    public uint Opcode;
    public uint uOutputs;

    [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTREG_INFO[2]")]
    public _pOutputs_e__FixedBuffer pOutputs;
    public uint TokenId;
    public uint NestingLevel;
    public uint Scopes;
    public uint ScopeInfo;
    public uint AccessedVars;
    public uint AccessedVarsInfo;

    [InlineArray(2)]
    public partial struct _pOutputs_e__FixedBuffer
    {
        public D3D10_SHADER_DEBUG_OUTPUTREG_INFO e0;
    }
}
