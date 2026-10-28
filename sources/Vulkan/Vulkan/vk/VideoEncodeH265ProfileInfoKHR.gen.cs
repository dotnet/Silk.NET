// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265ProfileInfoKHR")]
public unsafe partial struct VideoEncodeH265ProfileInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265ProfileInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stdProfileIdc")]
    public StdVideoH265ProfileIdc StdProfileIdc;

    public VideoEncodeH265ProfileInfoKHR() { }
}
