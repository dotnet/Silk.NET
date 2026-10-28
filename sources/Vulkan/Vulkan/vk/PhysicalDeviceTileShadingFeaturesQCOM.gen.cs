// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTileShadingFeaturesQCOM")]
public unsafe partial struct PhysicalDeviceTileShadingFeaturesQCOM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTileShadingFeaturesQCOM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tileShading")]
    public MaybeBool<uint> TileShading;

    [NativeName("tileShadingFragmentStage")]
    public MaybeBool<uint> TileShadingFragmentStage;

    [NativeName("tileShadingColorAttachments")]
    public MaybeBool<uint> TileShadingColorAttachments;

    [NativeName("tileShadingDepthAttachments")]
    public MaybeBool<uint> TileShadingDepthAttachments;

    [NativeName("tileShadingStencilAttachments")]
    public MaybeBool<uint> TileShadingStencilAttachments;

    [NativeName("tileShadingInputAttachments")]
    public MaybeBool<uint> TileShadingInputAttachments;

    [NativeName("tileShadingSampledAttachments")]
    public MaybeBool<uint> TileShadingSampledAttachments;

    [NativeName("tileShadingPerTileDraw")]
    public MaybeBool<uint> TileShadingPerTileDraw;

    [NativeName("tileShadingPerTileDispatch")]
    public MaybeBool<uint> TileShadingPerTileDispatch;

    [NativeName("tileShadingDispatchTile")]
    public MaybeBool<uint> TileShadingDispatchTile;

    [NativeName("tileShadingApron")]
    public MaybeBool<uint> TileShadingApron;

    [NativeName("tileShadingAnisotropicApron")]
    public MaybeBool<uint> TileShadingAnisotropicApron;

    [NativeName("tileShadingAtomicOps")]
    public MaybeBool<uint> TileShadingAtomicOps;

    [NativeName("tileShadingImageProcessing")]
    public MaybeBool<uint> TileShadingImageProcessing;

    public PhysicalDeviceTileShadingFeaturesQCOM() { }
}
