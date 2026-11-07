// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevice8BitStorageFeatures")]
public unsafe partial struct PhysicalDevice8BitStorageFeatures
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDevice8BitStorageFeatures;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("storageBuffer8BitAccess")]
    public MaybeBool<uint> StorageBuffer8BitAccess;

    [NativeName("uniformAndStorageBuffer8BitAccess")]
    public MaybeBool<uint> UniformAndStorageBuffer8BitAccess;

    [NativeName("storagePushConstant8")]
    public MaybeBool<uint> StoragePushConstant8;

    public PhysicalDevice8BitStorageFeatures() { }
}
