// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrApiLayerProperties")]
public unsafe partial struct ApiLayerProperties
{
    [NativeName("type")]
    public StructureType Type = StructureType.ApiLayerProperties;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerName")]
    public ApiLayerPropertiesLayerName LayerName;

    [NativeName("specVersion")]
    public ulong SpecVersion;

    [NativeName("layerVersion")]
    public uint LayerVersion;

    [NativeName("description")]
    public ApiLayerPropertiesDescription Description;

    public ApiLayerProperties() { }
}
