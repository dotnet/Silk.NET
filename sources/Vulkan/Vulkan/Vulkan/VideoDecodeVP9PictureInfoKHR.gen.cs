// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeVP9PictureInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("const StdVideoDecodeVP9PictureInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeVP9PictureInfo* PStdPictureInfo;

    [NativeTypeName("int32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public VideoDecodeVP9PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint UncompressedHeaderOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CompressedHeaderOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint TilesOffset;
}
