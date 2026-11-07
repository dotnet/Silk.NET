// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugReportCallbackCreateInfoEXT")]
public unsafe partial struct DebugReportCallbackCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DebugReportCallbackCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public DebugReportFlagsEXT Flags;

    [NativeName("pfnCallback")]
    public DebugReportCallbackEXT PfnCallback;

    [NativeName("pUserData")]
    public void* PUserData;

    public DebugReportCallbackCreateInfoEXT() { }
}
