// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccessFlags3KHR")]
[Flags]
public enum AccessFlags3KHR : ulong
{
    [NativeName("VK_ACCESS_3_NONE_KHR")]
    Access3NoneKHR = 0x0,
}
