// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTransformFeedbackPropertiesEXT")]
public unsafe partial struct PhysicalDeviceTransformFeedbackPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxTransformFeedbackStreams")]
    public uint MaxTransformFeedbackStreams;

    [NativeName("maxTransformFeedbackBuffers")]
    public uint MaxTransformFeedbackBuffers;

    [NativeName("maxTransformFeedbackBufferSize")]
    public ulong MaxTransformFeedbackBufferSize;

    [NativeName("maxTransformFeedbackStreamDataSize")]
    public uint MaxTransformFeedbackStreamDataSize;

    [NativeName("maxTransformFeedbackBufferDataSize")]
    public uint MaxTransformFeedbackBufferDataSize;

    [NativeName("maxTransformFeedbackBufferDataStride")]
    public uint MaxTransformFeedbackBufferDataStride;

    [NativeName("transformFeedbackQueries")]
    public MaybeBool<uint> TransformFeedbackQueries;

    [NativeName("transformFeedbackStreamsLinesTriangles")]
    public MaybeBool<uint> TransformFeedbackStreamsLinesTriangles;

    [NativeName("transformFeedbackRasterizationStreamSelect")]
    public MaybeBool<uint> TransformFeedbackRasterizationStreamSelect;

    [NativeName("transformFeedbackDraw")]
    public MaybeBool<uint> TransformFeedbackDraw;

    public PhysicalDeviceTransformFeedbackPropertiesEXT() { }
}
