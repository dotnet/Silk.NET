// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum BufferUsageFlags2 : long
{
    None = 0,
    TransferSrcBit = unchecked((ulong)0x00000001UL),
    TransferDstBit = unchecked((ulong)0x00000002UL),
    UniformTexelBufferBit = unchecked((ulong)0x00000004UL),
    StorageTexelBufferBit = unchecked((ulong)0x00000008UL),
    UniformBufferBit = unchecked((ulong)0x00000010UL),
    StorageBufferBit = unchecked((ulong)0x00000020UL),
    IndexBufferBit = unchecked((ulong)0x00000040UL),
    VertexBufferBit = unchecked((ulong)0x00000080UL),
    IndirectBufferBit = unchecked((ulong)0x00000100UL),
    ShaderDeviceAddressBit = unchecked((ulong)0x00020000UL),
    TransferSrcBitKHR = unchecked((ulong)0x00000001UL),
    TransferDstBitKHR = unchecked((ulong)0x00000002UL),
    UniformTexelBufferBitKHR = unchecked((ulong)0x00000004UL),
    StorageTexelBufferBitKHR = unchecked((ulong)0x00000008UL),
    UniformBufferBitKHR = unchecked((ulong)0x00000010UL),
    StorageBufferBitKHR = unchecked((ulong)0x00000020UL),
    IndexBufferBitKHR = unchecked((ulong)0x00000040UL),
    VertexBufferBitKHR = unchecked((ulong)0x00000080UL),
    IndirectBufferBitKHR = unchecked((ulong)0x00000100UL),
    ConditionalRenderingBitEXT = unchecked((ulong)0x00000200UL),
    ShaderBindingTableBitKHR = unchecked((ulong)0x00000400UL),
    RayTracingBitNV = unchecked((ulong)0x00000400UL),
    TransformFeedbackBufferBitEXT = unchecked((ulong)0x00000800UL),
    TransformFeedbackCounterBufferBitEXT = unchecked((ulong)0x00001000UL),
    VideoDecodeSrcBitKHR = unchecked((ulong)0x00002000UL),
    VideoDecodeDstBitKHR = unchecked((ulong)0x00004000UL),
    VideoEncodeDstBitKHR = unchecked((ulong)0x00008000UL),
    VideoEncodeSrcBitKHR = unchecked((ulong)0x00010000UL),
    ShaderDeviceAddressBitKHR = unchecked((ulong)0x00020000UL),
    AccelerationStructureBuildInputReadOnlyBitKHR = unchecked((ulong)0x00080000UL),
    AccelerationStructureStorageBitKHR = unchecked((ulong)0x00100000UL),
    SamplerDescriptorBufferBitEXT = unchecked((ulong)0x00200000UL),
    ResourceDescriptorBufferBitEXT = unchecked((ulong)0x00400000UL),
    PushDescriptorsDescriptorBufferBitEXT = unchecked((ulong)0x04000000UL),
    MicromapBuildInputReadOnlyBitEXT = unchecked((ulong)0x00800000UL),
    MicromapStorageBitEXT = unchecked((ulong)0x01000000UL),
    DataGraphForeignDescriptorBitARM = unchecked((ulong)0x20000000UL),
    TileMemoryBitQCOM = unchecked((ulong)0x08000000UL),
    MemoryDecompressionBitEXT = unchecked((ulong)0x100000000UL),
    PreprocessBufferBitEXT = unchecked((ulong)0x80000000UL),
}
