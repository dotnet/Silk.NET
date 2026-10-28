// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1CDEF")]
public partial struct StdVideoAv1Cdef
{
    [NativeName("cdef_damping_minus_3")]
    public byte CdefDampingMinus3;

    [NativeName("cdef_bits")]
    public byte CdefBits;

    [NativeName("cdef_y_pri_strength")]
    public StdVideoAv1CdefCdefYPriStrength CdefYPriStrength;

    [NativeName("cdef_y_sec_strength")]
    public StdVideoAv1CdefCdefYSecStrength CdefYSecStrength;

    [NativeName("cdef_uv_pri_strength")]
    public StdVideoAv1CdefCdefUvPriStrength CdefUvPriStrength;

    [NativeName("cdef_uv_sec_strength")]
    public StdVideoAv1CdefCdefUvSecStrength CdefUvSecStrength;
}
