// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTilePropertiesHintMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct TilePropertiesHintMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public StructureType Type = StructureType.TilePropertiesHintMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public void* Next;

    [NativeName("propertiesCount")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public uint PropertiesCount;

    [NativeName("properties")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public TilePropertiesMETA* Properties;

    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public TilePropertiesHintMETA() { }
}
