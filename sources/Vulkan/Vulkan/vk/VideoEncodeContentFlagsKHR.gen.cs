// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeContentFlagsKHR")]
[Flags]
public enum VideoEncodeContentFlagsKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR")]
    Default = 0x0,

    [NativeName("VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR")]
    CameraBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR")]
    DesktopBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR")]
    RenderedBit = 0x4,
}
