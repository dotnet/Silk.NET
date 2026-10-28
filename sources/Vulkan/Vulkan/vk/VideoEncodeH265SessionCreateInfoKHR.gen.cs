// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265SessionCreateInfoKHR")]
public unsafe partial struct VideoEncodeH265SessionCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265SessionCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("useMaxLevelIdc")]
    public MaybeBool<uint> UseMaxLevelIdc;

    [NativeName("maxLevelIdc")]
    public StdVideoH265LevelIdc MaxLevelIdc;

    public VideoEncodeH265SessionCreateInfoKHR() { }
}
