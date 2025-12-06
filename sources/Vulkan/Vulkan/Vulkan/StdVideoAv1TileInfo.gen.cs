// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TileInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoAv1TileInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TileInfoFlags Flags;

    [NativeName("TileCols")]
    [SupportedApiProfile("vulkan")]
    public byte TileCols;

    [NativeName("TileRows")]
    [SupportedApiProfile("vulkan")]
    public byte TileRows;

    [NativeName("context_update_tile_id")]
    [SupportedApiProfile("vulkan")]
    public ushort ContextUpdateTileId;

    [NativeName("tile_size_bytes_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte TileSizeBytesMinus1;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TileInfoReserved1 Reserved1;

    [NativeName("pMiColStarts")]
    [SupportedApiProfile("vulkan")]
    public ushort* PMiColStarts;

    [NativeName("pMiRowStarts")]
    [SupportedApiProfile("vulkan")]
    public ushort* PMiRowStarts;

    [NativeName("pWidthInSbsMinus1")]
    [SupportedApiProfile("vulkan")]
    public ushort* PWidthInSbsMinus1;

    [NativeName("pHeightInSbsMinus1")]
    [SupportedApiProfile("vulkan")]
    public ushort* PHeightInSbsMinus1;
}
