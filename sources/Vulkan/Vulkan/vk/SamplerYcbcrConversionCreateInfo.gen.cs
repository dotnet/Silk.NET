// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerYcbcrConversionCreateInfo")]
public unsafe partial struct SamplerYcbcrConversionCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SamplerYcbcrConversionCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("format")]
    public Format Format;

    [NativeName("ycbcrModel")]
    public SamplerYcbcrModelConversion YcbcrModel;

    [NativeName("ycbcrRange")]
    public SamplerYcbcrRange YcbcrRange;

    [NativeName("components")]
    public ComponentMapping Components;

    [NativeName("xChromaOffset")]
    public ChromaLocation XChromaOffset;

    [NativeName("yChromaOffset")]
    public ChromaLocation YChromaOffset;

    [NativeName("chromaFilter")]
    public Filter ChromaFilter;

    [NativeName("forceExplicitReconstruction")]
    public MaybeBool<uint> ForceExplicitReconstruction;

    public SamplerYcbcrConversionCreateInfo() { }
}
