// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ReferenceName")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9ReferenceName : uint
{
    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_INTRA_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameIntraFrame = 0,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameLastFrame = 1,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_GOLDEN_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameGoldenFrame = 2,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_ALTREF_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameAltrefFrame = 3,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ReferenceNameMaxEnum = 0x7FFFFFFF,
}
