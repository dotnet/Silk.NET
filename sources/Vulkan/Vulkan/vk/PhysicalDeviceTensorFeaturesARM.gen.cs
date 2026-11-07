// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTensorFeaturesARM")]
public unsafe partial struct PhysicalDeviceTensorFeaturesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTensorFeaturesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tensorNonPacked")]
    public MaybeBool<uint> TensorNonPacked;

    [NativeName("shaderTensorAccess")]
    public MaybeBool<uint> ShaderTensorAccess;

    [NativeName("shaderStorageTensorArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderStorageTensorArrayDynamicIndexing;

    [NativeName("shaderStorageTensorArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderStorageTensorArrayNonUniformIndexing;

    [NativeName("descriptorBindingStorageTensorUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingStorageTensorUpdateAfterBind;

    [NativeName("tensors")]
    public MaybeBool<uint> Tensors;

    public PhysicalDeviceTensorFeaturesARM() { }
}
