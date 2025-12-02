// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "QCOM", 0)]
[NativeName("FoveationConfigBitQCOM")]
[Flags]
public enum FoveationConfigBitQCOM : uint
{
    None = 0x0,

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_FOVEATION_ENABLE_BIT_QCOM")]
    EnableBit = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM")]
    ScaledBinMethodBit = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "QCOM", -1)]
    [NativeName("GL_FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM")]
    SubsampledLayoutMethodBit = unchecked((uint)0x00000004),
}
