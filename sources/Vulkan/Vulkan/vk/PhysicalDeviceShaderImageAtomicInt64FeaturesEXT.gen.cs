// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT")]
public unsafe partial struct PhysicalDeviceShaderImageAtomicInt64FeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderImageInt64Atomics")]
    public MaybeBool<uint> ShaderImageInt64Atomics;

    [NativeName("sparseImageInt64Atomics")]
    public MaybeBool<uint> SparseImageInt64Atomics;

    public PhysicalDeviceShaderImageAtomicInt64FeaturesEXT() { }
}
