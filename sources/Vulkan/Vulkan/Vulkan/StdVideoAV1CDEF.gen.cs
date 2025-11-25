// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1CDEF")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1CDEF
{
    [NativeName("cdef_damping_minus_3")]
    [SupportedApiProfile("vulkan")]
    public byte CdefDampingMinus3;

    [NativeName("cdef_bits")]
    [SupportedApiProfile("vulkan")]
    public byte CdefBits;

    [NativeName("cdef_y_pri_strength")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefYPriStrength CdefYPriStrength;

    [NativeName("cdef_y_sec_strength")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefYSecStrength CdefYSecStrength;

    [NativeName("cdef_uv_pri_strength")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefUvPriStrength CdefUvPriStrength;

    [NativeName("cdef_uv_sec_strength")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefUvSecStrength CdefUvSecStrength;
}
