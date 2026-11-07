// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplayPresentInfoKHR")]
public unsafe partial struct DisplayPresentInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DisplayPresentInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcRect")]
    public Rect2D SrcRect;

    [NativeName("dstRect")]
    public Rect2D DstRect;

    [NativeName("persistent")]
    public MaybeBool<uint> Persistent;

    public DisplayPresentInfoKHR() { }
}
