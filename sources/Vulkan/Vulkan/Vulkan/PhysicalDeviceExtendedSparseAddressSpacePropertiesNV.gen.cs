// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceExtendedSparseAddressSpacePropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public void* PNext;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public ulong ExtendedSparseAddressSpaceSize;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public uint ExtendedSparseImageUsageFlags;

    [NativeTypeName("VkBufferUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_extended_sparse_address_space"])]
    public uint ExtendedSparseBufferUsageFlags;
}
