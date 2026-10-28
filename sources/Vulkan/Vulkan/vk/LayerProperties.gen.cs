// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLayerProperties")]
public partial struct LayerProperties
{
    [NativeName("layerName")]
    public LayerPropertiesLayerName LayerName;

    [NativeName("specVersion")]
    public uint SpecVersion;

    [NativeName("implementationVersion")]
    public uint ImplementationVersion;

    [NativeName("description")]
    public LayerPropertiesDescription Description;
}
