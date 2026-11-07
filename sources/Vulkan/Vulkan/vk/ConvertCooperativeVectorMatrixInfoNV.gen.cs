// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConvertCooperativeVectorMatrixInfoNV")]
public unsafe partial struct ConvertCooperativeVectorMatrixInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ConvertCooperativeVectorMatrixInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcSize")]
    public nuint SrcSize;

    [NativeName("srcData")]
    public DeviceOrHostAddressConstKHR SrcData;

    [NativeName("pDstSize")]
    public nuint* PDstSize;

    [NativeName("dstData")]
    public DeviceOrHostAddressKHR DstData;

    [NativeName("srcComponentType")]
    public ComponentTypeKHR SrcComponentType;

    [NativeName("dstComponentType")]
    public ComponentTypeKHR DstComponentType;

    [NativeName("numRows")]
    public uint NumRows;

    [NativeName("numColumns")]
    public uint NumColumns;

    [NativeName("srcLayout")]
    public CooperativeVectorMatrixLayoutNV SrcLayout;

    [NativeName("srcStride")]
    public nuint SrcStride;

    [NativeName("dstLayout")]
    public CooperativeVectorMatrixLayoutNV DstLayout;

    [NativeName("dstStride")]
    public nuint DstStride;

    public ConvertCooperativeVectorMatrixInfoNV() { }
}
