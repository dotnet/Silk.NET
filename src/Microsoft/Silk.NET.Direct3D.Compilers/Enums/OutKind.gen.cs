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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXC_OUT_NONE")]
        OutNone = 0x0,
        [Obsolete("Deprecated in favour of \"Object\"")]
        [NativeName("Name", "DXC_OUT_OBJECT")]
        OutObject = 0x1,
        [Obsolete("Deprecated in favour of \"Errors\"")]
        [NativeName("Name", "DXC_OUT_ERRORS")]
        OutErrors = 0x2,
        [Obsolete("Deprecated in favour of \"Pdb\"")]
        [NativeName("Name", "DXC_OUT_PDB")]
        OutPdb = 0x3,
        [Obsolete("Deprecated in favour of \"ShaderHash\"")]
        [NativeName("Name", "DXC_OUT_SHADER_HASH")]
        OutShaderHash = 0x4,
        [Obsolete("Deprecated in favour of \"Disassembly\"")]
        [NativeName("Name", "DXC_OUT_DISASSEMBLY")]
        OutDisassembly = 0x5,
        [Obsolete("Deprecated in favour of \"Hlsl\"")]
        [NativeName("Name", "DXC_OUT_HLSL")]
        OutHlsl = 0x6,
        [Obsolete("Deprecated in favour of \"Text\"")]
        [NativeName("Name", "DXC_OUT_TEXT")]
        OutText = 0x7,
        [Obsolete("Deprecated in favour of \"Reflection\"")]
        [NativeName("Name", "DXC_OUT_REFLECTION")]
        OutReflection = 0x8,
        [Obsolete("Deprecated in favour of \"RootSignature\"")]
        [NativeName("Name", "DXC_OUT_ROOT_SIGNATURE")]
        OutRootSignature = 0x9,
        [Obsolete("Deprecated in favour of \"ExtraOutputs\"")]
        [NativeName("Name", "DXC_OUT_EXTRA_OUTPUTS")]
        OutExtraOutputs = 0xA,
        [Obsolete("Deprecated in favour of \"Remarks\"")]
        [NativeName("Name", "DXC_OUT_REMARKS")]
        OutRemarks = 0xB,
        [Obsolete("Deprecated in favour of \"TimeReport\"")]
        [NativeName("Name", "DXC_OUT_TIME_REPORT")]
        OutTimeReport = 0xC,
        [Obsolete("Deprecated in favour of \"TimeTrace\"")]
        [NativeName("Name", "DXC_OUT_TIME_TRACE")]
        OutTimeTrace = 0xD,
        [Obsolete("Deprecated in favour of \"Last\"")]
        [NativeName("Name", "DXC_OUT_LAST")]
        OutLast = 0xD,
        [Obsolete("Deprecated in favour of \"NumEnums\"")]
        [NativeName("Name", "DXC_OUT_NUM_ENUMS")]
        OutNumEnums = 0xE,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "DXC_OUT_FORCE_DWORD")]
        OutForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DXC_OUT_NONE")]
        None = 0x0,
        [NativeName("Name", "DXC_OUT_OBJECT")]
        Object = 0x1,
        [NativeName("Name", "DXC_OUT_ERRORS")]
        Errors = 0x2,
        [NativeName("Name", "DXC_OUT_PDB")]
        Pdb = 0x3,
        [NativeName("Name", "DXC_OUT_SHADER_HASH")]
        ShaderHash = 0x4,
        [NativeName("Name", "DXC_OUT_DISASSEMBLY")]
        Disassembly = 0x5,
        [NativeName("Name", "DXC_OUT_HLSL")]
        Hlsl = 0x6,
        [NativeName("Name", "DXC_OUT_TEXT")]
        Text = 0x7,
        [NativeName("Name", "DXC_OUT_REFLECTION")]
        Reflection = 0x8,
        [NativeName("Name", "DXC_OUT_ROOT_SIGNATURE")]
        RootSignature = 0x9,
        [NativeName("Name", "DXC_OUT_EXTRA_OUTPUTS")]
        ExtraOutputs = 0xA,
        [NativeName("Name", "DXC_OUT_REMARKS")]
        Remarks = 0xB,
        [NativeName("Name", "DXC_OUT_TIME_REPORT")]
        TimeReport = 0xC,
        [NativeName("Name", "DXC_OUT_TIME_TRACE")]
        TimeTrace = 0xD,
        [NativeName("Name", "DXC_OUT_LAST")]
        Last = 0xD,
        [NativeName("Name", "DXC_OUT_NUM_ENUMS")]
        NumEnums = 0xE,
        [NativeName("Name", "DXC_OUT_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
