// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpticalFlowSessionCreatePrivateDataInfoNV")]
public unsafe partial struct OpticalFlowSessionCreatePrivateDataInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.OpticalFlowSessionCreatePrivateDataInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("id")]
    public uint Id;

    [NativeName("size")]
    public uint Size;

    [NativeName("pPrivateData")]
    public void* PPrivateData;

    public OpticalFlowSessionCreatePrivateDataInfoNV() { }
}
