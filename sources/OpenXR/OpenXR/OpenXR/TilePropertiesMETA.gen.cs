// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTilePropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct TilePropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public StructureType Type = StructureType.TilePropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public void* Next;

    [NativeName("tileDimensions")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public Extent3DiMETA TileDimensions;

    [NativeName("apronDimensions")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public Extent2Di ApronDimensions;

    [NativeName("origin")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public Offset2Di Origin;

    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public TilePropertiesMETA() { }
}
