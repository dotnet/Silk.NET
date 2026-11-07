// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderTileImagePropertiesEXT")]
public unsafe partial struct PhysicalDeviceShaderTileImagePropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderTileImagePropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderTileImageCoherentReadAccelerated")]
    public MaybeBool<uint> ShaderTileImageCoherentReadAccelerated;

    [NativeName("shaderTileImageReadSampleFromPixelRateInvocation")]
    public MaybeBool<uint> ShaderTileImageReadSampleFromPixelRateInvocation;

    [NativeName("shaderTileImageReadFromHelperInvocation")]
    public MaybeBool<uint> ShaderTileImageReadFromHelperInvocation;

    public PhysicalDeviceShaderTileImagePropertiesEXT() { }
}
