// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE")]
public unsafe partial struct PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderMixedFloatDotProductFloat16AccFloat32")]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat16AccFloat32;

    [NativeName("shaderMixedFloatDotProductFloat16AccFloat16")]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat16AccFloat16;

    [NativeName("shaderMixedFloatDotProductBFloat16Acc")]
    public MaybeBool<uint> ShaderMixedFloatDotProductBFloat16Acc;

    [NativeName("shaderMixedFloatDotProductFloat8AccFloat32")]
    public MaybeBool<uint> ShaderMixedFloatDotProductFloat8AccFloat32;

    public PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE() { }
}
