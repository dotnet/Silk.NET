// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeInfoKHR")]
public unsafe partial struct VideoDecodeInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("srcBuffer")]
    public BufferHandle SrcBuffer;

    [NativeName("srcBufferOffset")]
    public ulong SrcBufferOffset;

    [NativeName("srcBufferRange")]
    public ulong SrcBufferRange;

    [NativeName("dstPictureResource")]
    public VideoPictureResourceInfoKHR DstPictureResource;

    [NativeName("pSetupReferenceSlot")]
    public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;

    [NativeName("referenceSlotCount")]
    public uint ReferenceSlotCount;

    [NativeName("pReferenceSlots")]
    public VideoReferenceSlotInfoKHR* PReferenceSlots;

    public VideoDecodeInfoKHR() { }
}
