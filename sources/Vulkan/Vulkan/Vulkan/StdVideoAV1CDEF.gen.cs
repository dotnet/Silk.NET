// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1CDEF
{
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CdefDampingMinus3;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CdefBits;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefYPriStrength CdefYPriStrength;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefYSecStrength CdefYSecStrength;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefUvPriStrength CdefUvPriStrength;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1CDEFCdefUvSecStrength CdefUvSecStrength;
}
