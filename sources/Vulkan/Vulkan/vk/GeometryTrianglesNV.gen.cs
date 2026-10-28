// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeometryTrianglesNV")]
public unsafe partial struct GeometryTrianglesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GeometryTrianglesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("vertexData")]
    public BufferHandle VertexData;

    [NativeName("vertexOffset")]
    public ulong VertexOffset;

    [NativeName("vertexCount")]
    public uint VertexCount;

    [NativeName("vertexStride")]
    public ulong VertexStride;

    [NativeName("vertexFormat")]
    public Format VertexFormat;

    [NativeName("indexData")]
    public BufferHandle IndexData;

    [NativeName("indexOffset")]
    public ulong IndexOffset;

    [NativeName("indexCount")]
    public uint IndexCount;

    [NativeName("indexType")]
    public IndexType IndexType;

    [NativeName("transformData")]
    public BufferHandle TransformData;

    [NativeName("transformOffset")]
    public ulong TransformOffset;

    public GeometryTrianglesNV() { }
}
