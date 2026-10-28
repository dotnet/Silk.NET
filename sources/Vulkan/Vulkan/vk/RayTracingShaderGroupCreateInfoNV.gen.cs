// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRayTracingShaderGroupCreateInfoNV")]
public unsafe partial struct RayTracingShaderGroupCreateInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RayTracingShaderGroupCreateInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("type")]
    public RayTracingShaderGroupTypeKHR Type;

    [NativeName("generalShader")]
    public uint GeneralShader;

    [NativeName("closestHitShader")]
    public uint ClosestHitShader;

    [NativeName("anyHitShader")]
    public uint AnyHitShader;

    [NativeName("intersectionShader")]
    public uint IntersectionShader;

    public RayTracingShaderGroupCreateInfoNV() { }
}
