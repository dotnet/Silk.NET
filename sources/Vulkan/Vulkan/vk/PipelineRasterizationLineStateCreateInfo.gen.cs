// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineRasterizationLineStateCreateInfo")]
public unsafe partial struct PipelineRasterizationLineStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineRasterizationLineStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("lineRasterizationMode")]
    public LineRasterizationMode LineRasterizationMode;

    [NativeName("stippledLineEnable")]
    public MaybeBool<uint> StippledLineEnable;

    [NativeName("lineStippleFactor")]
    public uint LineStippleFactor;

    [NativeName("lineStipplePattern")]
    public ushort LineStipplePattern;

    public PipelineRasterizationLineStateCreateInfo() { }
}
