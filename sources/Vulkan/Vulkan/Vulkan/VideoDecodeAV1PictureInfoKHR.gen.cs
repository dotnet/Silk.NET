// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeAV1PictureInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* PNext;

    [NativeTypeName("const StdVideoDecodeAV1PictureInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoDecodeAV1PictureInfoHandle PStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public VideoDecodeAV1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint FrameHeaderOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint TileCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint* PTileOffsets;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public uint* PTileSizes;
}
