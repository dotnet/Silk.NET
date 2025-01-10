// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_SHADER_DEBUG_OUTPUTREG_INFO
{
    public D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;
    public uint OutputReg;
    public uint TempArrayReg;

    [NativeTypeName("UINT[4]")]
    public _OutputComponents_e__FixedBuffer OutputComponents;

    [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTVAR[4]")]
    public _OutputVars_e__FixedBuffer OutputVars;
    public uint IndexReg;
    public uint IndexComp;

    [InlineArray(4)]
    public partial struct _OutputComponents_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(4)]
    public partial struct _OutputVars_e__FixedBuffer
    {
        public D3D10_SHADER_DEBUG_OUTPUTVAR e0;
    }
}
