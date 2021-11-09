// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "DXC_OUT_KIND")]
    public enum OutKind : int
    {
        [NativeName("Name", "DXC_OUT_NONE")]
        OutNone = 0x0,
        [NativeName("Name", "DXC_OUT_OBJECT")]
        OutObject = 0x1,
        [NativeName("Name", "DXC_OUT_ERRORS")]
        OutErrors = 0x2,
        [NativeName("Name", "DXC_OUT_PDB")]
        OutPdb = 0x3,
        [NativeName("Name", "DXC_OUT_SHADER_HASH")]
        OutShaderHash = 0x4,
        [NativeName("Name", "DXC_OUT_DISASSEMBLY")]
        OutDisassembly = 0x5,
        [NativeName("Name", "DXC_OUT_HLSL")]
        OutHlsl = 0x6,
        [NativeName("Name", "DXC_OUT_TEXT")]
        OutText = 0x7,
        [NativeName("Name", "DXC_OUT_REFLECTION")]
        OutReflection = 0x8,
        [NativeName("Name", "DXC_OUT_ROOT_SIGNATURE")]
        OutRootSignature = 0x9,
        [NativeName("Name", "DXC_OUT_EXTRA_OUTPUTS")]
        OutExtraOutputs = 0xA,
        [NativeName("Name", "DXC_OUT_FORCE_DWORD")]
        OutForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
