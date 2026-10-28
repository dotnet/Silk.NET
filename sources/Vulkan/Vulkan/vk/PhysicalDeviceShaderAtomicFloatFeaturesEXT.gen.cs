// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderAtomicFloatFeaturesEXT")]
public unsafe partial struct PhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderBufferFloat32Atomics")]
    public MaybeBool<uint> ShaderBufferFloat32Atomics;

    [NativeName("shaderBufferFloat32AtomicAdd")]
    public MaybeBool<uint> ShaderBufferFloat32AtomicAdd;

    [NativeName("shaderBufferFloat64Atomics")]
    public MaybeBool<uint> ShaderBufferFloat64Atomics;

    [NativeName("shaderBufferFloat64AtomicAdd")]
    public MaybeBool<uint> ShaderBufferFloat64AtomicAdd;

    [NativeName("shaderSharedFloat32Atomics")]
    public MaybeBool<uint> ShaderSharedFloat32Atomics;

    [NativeName("shaderSharedFloat32AtomicAdd")]
    public MaybeBool<uint> ShaderSharedFloat32AtomicAdd;

    [NativeName("shaderSharedFloat64Atomics")]
    public MaybeBool<uint> ShaderSharedFloat64Atomics;

    [NativeName("shaderSharedFloat64AtomicAdd")]
    public MaybeBool<uint> ShaderSharedFloat64AtomicAdd;

    [NativeName("shaderImageFloat32Atomics")]
    public MaybeBool<uint> ShaderImageFloat32Atomics;

    [NativeName("shaderImageFloat32AtomicAdd")]
    public MaybeBool<uint> ShaderImageFloat32AtomicAdd;

    [NativeName("sparseImageFloat32Atomics")]
    public MaybeBool<uint> SparseImageFloat32Atomics;

    [NativeName("sparseImageFloat32AtomicAdd")]
    public MaybeBool<uint> SparseImageFloat32AtomicAdd;

    public PhysicalDeviceShaderAtomicFloatFeaturesEXT() { }
}
