// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevice16BitStorageFeatures")]
public unsafe partial struct PhysicalDevice16BitStorageFeatures
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDevice16BitStorageFeatures;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("storageBuffer16BitAccess")]
    public MaybeBool<uint> StorageBuffer16BitAccess;

    [NativeName("uniformAndStorageBuffer16BitAccess")]
    public MaybeBool<uint> UniformAndStorageBuffer16BitAccess;

    [NativeName("storagePushConstant16")]
    public MaybeBool<uint> StoragePushConstant16;

    [NativeName("storageInputOutput16")]
    public MaybeBool<uint> StorageInputOutput16;

    public PhysicalDevice16BitStorageFeatures() { }
}
