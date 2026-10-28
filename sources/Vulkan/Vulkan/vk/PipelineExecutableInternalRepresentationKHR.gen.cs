// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineExecutableInternalRepresentationKHR")]
public unsafe partial struct PipelineExecutableInternalRepresentationKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineExecutableInternalRepresentationKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("name")]
    public PipelineExecutableInternalRepresentationKHRName Name;

    [NativeName("description")]
    public PipelineExecutableInternalRepresentationKHRDescription Description;

    [NativeName("isText")]
    public MaybeBool<uint> IsText;

    [NativeName("dataSize")]
    public nuint DataSize;

    [NativeName("pData")]
    public void* PData;

    public PipelineExecutableInternalRepresentationKHR() { }
}
