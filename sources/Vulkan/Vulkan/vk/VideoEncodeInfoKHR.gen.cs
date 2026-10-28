// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeInfoKHR")]
public unsafe partial struct VideoEncodeInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeFlagsKHR Flags;

    [NativeName("dstBuffer")]
    public BufferHandle DstBuffer;

    [NativeName("dstBufferOffset")]
    public ulong DstBufferOffset;

    [NativeName("dstBufferRange")]
    public ulong DstBufferRange;

    [NativeName("srcPictureResource")]
    public VideoPictureResourceInfoKHR SrcPictureResource;

    [NativeName("pSetupReferenceSlot")]
    public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;

    [NativeName("referenceSlotCount")]
    public uint ReferenceSlotCount;

    [NativeName("pReferenceSlots")]
    public VideoReferenceSlotInfoKHR* PReferenceSlots;

    [NativeName("precedingExternallyEncodedBytes")]
    public uint PrecedingExternallyEncodedBytes;

    public VideoEncodeInfoKHR() { }
}
