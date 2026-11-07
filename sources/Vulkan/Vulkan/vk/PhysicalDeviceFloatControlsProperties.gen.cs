// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFloatControlsProperties")]
public unsafe partial struct PhysicalDeviceFloatControlsProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceFloatControlsProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("denormBehaviorIndependence")]
    public ShaderFloatControlsIndependence DenormBehaviorIndependence;

    [NativeName("roundingModeIndependence")]
    public ShaderFloatControlsIndependence RoundingModeIndependence;

    [NativeName("shaderSignedZeroInfNanPreserveFloat16")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat16;

    [NativeName("shaderSignedZeroInfNanPreserveFloat32")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat32;

    [NativeName("shaderSignedZeroInfNanPreserveFloat64")]
    public MaybeBool<uint> ShaderSignedZeroInfNanPreserveFloat64;

    [NativeName("shaderDenormPreserveFloat16")]
    public MaybeBool<uint> ShaderDenormPreserveFloat16;

    [NativeName("shaderDenormPreserveFloat32")]
    public MaybeBool<uint> ShaderDenormPreserveFloat32;

    [NativeName("shaderDenormPreserveFloat64")]
    public MaybeBool<uint> ShaderDenormPreserveFloat64;

    [NativeName("shaderDenormFlushToZeroFloat16")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat16;

    [NativeName("shaderDenormFlushToZeroFloat32")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat32;

    [NativeName("shaderDenormFlushToZeroFloat64")]
    public MaybeBool<uint> ShaderDenormFlushToZeroFloat64;

    [NativeName("shaderRoundingModeRTEFloat16")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat16;

    [NativeName("shaderRoundingModeRTEFloat32")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat32;

    [NativeName("shaderRoundingModeRTEFloat64")]
    public MaybeBool<uint> ShaderRoundingModeRteFloat64;

    [NativeName("shaderRoundingModeRTZFloat16")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat16;

    [NativeName("shaderRoundingModeRTZFloat32")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat32;

    [NativeName("shaderRoundingModeRTZFloat64")]
    public MaybeBool<uint> ShaderRoundingModeRtzFloat64;

    public PhysicalDeviceFloatControlsProperties() { }
}
