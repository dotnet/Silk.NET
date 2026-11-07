// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDescriptorMappingSourceDataEXT")]
[StructLayout(LayoutKind.Explicit)]
public partial struct DescriptorMappingSourceDataEXT
{
    [NativeName("constantOffset")]
    [FieldOffset(0)]
    public DescriptorMappingSourceConstantOffsetEXT ConstantOffset;

    [NativeName("pushIndex")]
    [FieldOffset(0)]
    public DescriptorMappingSourcePushIndexEXT PushIndex;

    [NativeName("indirectIndex")]
    [FieldOffset(0)]
    public DescriptorMappingSourceIndirectIndexEXT IndirectIndex;

    [NativeName("indirectIndexArray")]
    [FieldOffset(0)]
    public DescriptorMappingSourceIndirectIndexArrayEXT IndirectIndexArray;

    [NativeName("heapData")]
    [FieldOffset(0)]
    public DescriptorMappingSourceHeapDataEXT HeapData;

    [NativeName("pushDataOffset")]
    [FieldOffset(0)]
    public uint PushDataOffset;

    [NativeName("pushAddressOffset")]
    [FieldOffset(0)]
    public uint PushAddressOffset;

    [NativeName("indirectAddress")]
    [FieldOffset(0)]
    public DescriptorMappingSourceIndirectAddressEXT IndirectAddress;

    [NativeName("shaderRecordIndex")]
    [FieldOffset(0)]
    public DescriptorMappingSourceShaderRecordIndexEXT ShaderRecordIndex;

    [NativeName("shaderRecordDataOffset")]
    [FieldOffset(0)]
    public uint ShaderRecordDataOffset;

    [NativeName("shaderRecordAddressOffset")]
    [FieldOffset(0)]
    public uint ShaderRecordAddressOffset;
}
