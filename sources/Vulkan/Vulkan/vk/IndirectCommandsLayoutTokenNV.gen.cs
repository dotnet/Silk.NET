// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsLayoutTokenNV")]
public unsafe partial struct IndirectCommandsLayoutTokenNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.IndirectCommandsLayoutTokenNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tokenType")]
    public IndirectCommandsTokenTypeNV TokenType;

    [NativeName("stream")]
    public uint Stream;

    [NativeName("offset")]
    public uint Offset;

    [NativeName("vertexBindingUnit")]
    public uint VertexBindingUnit;

    [NativeName("vertexDynamicStride")]
    public MaybeBool<uint> VertexDynamicStride;

    [NativeName("pushconstantPipelineLayout")]
    public PipelineLayoutHandle PushconstantPipelineLayout;

    [NativeName("pushconstantShaderStageFlags")]
    public ShaderStageFlags PushconstantShaderStageFlags;

    [NativeName("pushconstantOffset")]
    public uint PushconstantOffset;

    [NativeName("pushconstantSize")]
    public uint PushconstantSize;

    [NativeName("indirectStateFlags")]
    public IndirectStateFlagsNV IndirectStateFlags;

    [NativeName("indexTypeCount")]
    public uint IndexTypeCount;

    [NativeName("pIndexTypes")]
    public IndexType* PIndexTypes;

    [NativeName("pIndexTypeValues")]
    public uint* PIndexTypeValues;

    public IndirectCommandsLayoutTokenNV() { }
}
