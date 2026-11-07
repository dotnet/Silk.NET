// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TileInfo")]
public unsafe partial struct StdVideoAv1TileInfo
{
    [NativeName("flags")]
    public StdVideoAv1TileInfoFlags Flags;

    [NativeName("TileCols")]
    public byte TileCols;

    [NativeName("TileRows")]
    public byte TileRows;

    [NativeName("context_update_tile_id")]
    public ushort ContextUpdateTileId;

    [NativeName("tile_size_bytes_minus_1")]
    public byte TileSizeBytesMinus1;

    [NativeName("reserved1")]
    public StdVideoAv1TileInfoReserved1 Reserved1;

    [NativeName("pMiColStarts")]
    public ushort* PMiColStarts;

    [NativeName("pMiRowStarts")]
    public ushort* PMiRowStarts;

    [NativeName("pWidthInSbsMinus1")]
    public ushort* PWidthInSbsMinus1;

    [NativeName("pHeightInSbsMinus1")]
    public ushort* PHeightInSbsMinus1;
}
