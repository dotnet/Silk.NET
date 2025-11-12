// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoDecodeVP9PictureInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeVP9PictureInfoFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoVP9Profile Profile;

    [SupportedApiProfile("vulkan")]
    public StdVideoVP9FrameType FrameType;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte FrameContextIdx;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ResetFrameContext;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte RefreshFrameFlags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte RefFrameSignBiasMask;

    [SupportedApiProfile("vulkan")]
    public StdVideoVP9InterpolationFilter InterpolationFilter;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BaseQIdx;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQYDc;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUvDc;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte DeltaQUvAc;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TileColsLog2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TileRowsLog2;

    [NativeTypeName("uint16_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeVP9PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoVP9ColorConfig *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9ColorConfig* PColorConfig;

    [NativeTypeName("const StdVideoVP9LoopFilter *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9LoopFilter* PLoopFilter;

    [NativeTypeName("const StdVideoVP9Segmentation *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9Segmentation* PSegmentation;
}
