// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT")]
public unsafe partial struct PhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderAtomicFloat2FeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderBufferFloat16Atomics")]
    public MaybeBool<uint> ShaderBufferFloat16Atomics;

    [NativeName("shaderBufferFloat16AtomicAdd")]
    public MaybeBool<uint> ShaderBufferFloat16AtomicAdd;

    [NativeName("shaderBufferFloat16AtomicMinMax")]
    public MaybeBool<uint> ShaderBufferFloat16AtomicMinMax;

    [NativeName("shaderBufferFloat32AtomicMinMax")]
    public MaybeBool<uint> ShaderBufferFloat32AtomicMinMax;

    [NativeName("shaderBufferFloat64AtomicMinMax")]
    public MaybeBool<uint> ShaderBufferFloat64AtomicMinMax;

    [NativeName("shaderSharedFloat16Atomics")]
    public MaybeBool<uint> ShaderSharedFloat16Atomics;

    [NativeName("shaderSharedFloat16AtomicAdd")]
    public MaybeBool<uint> ShaderSharedFloat16AtomicAdd;

    [NativeName("shaderSharedFloat16AtomicMinMax")]
    public MaybeBool<uint> ShaderSharedFloat16AtomicMinMax;

    [NativeName("shaderSharedFloat32AtomicMinMax")]
    public MaybeBool<uint> ShaderSharedFloat32AtomicMinMax;

    [NativeName("shaderSharedFloat64AtomicMinMax")]
    public MaybeBool<uint> ShaderSharedFloat64AtomicMinMax;

    [NativeName("shaderImageFloat32AtomicMinMax")]
    public MaybeBool<uint> ShaderImageFloat32AtomicMinMax;

    [NativeName("sparseImageFloat32AtomicMinMax")]
    public MaybeBool<uint> SparseImageFloat32AtomicMinMax;

    public PhysicalDeviceShaderAtomicFloat2FeaturesEXT() { }
}
