// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeneratedCommandsInfoNV")]
public unsafe partial struct GeneratedCommandsInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GeneratedCommandsInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pipelineBindPoint")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeName("pipeline")]
    public PipelineHandle Pipeline;

    [NativeName("indirectCommandsLayout")]
    public IndirectCommandsLayoutHandleNV IndirectCommandsLayout;

    [NativeName("streamCount")]
    public uint StreamCount;

    [NativeName("pStreams")]
    public IndirectCommandsStreamNV* PStreams;

    [NativeName("sequencesCount")]
    public uint SequencesCount;

    [NativeName("preprocessBuffer")]
    public BufferHandle PreprocessBuffer;

    [NativeName("preprocessOffset")]
    public ulong PreprocessOffset;

    [NativeName("preprocessSize")]
    public ulong PreprocessSize;

    [NativeName("sequencesCountBuffer")]
    public BufferHandle SequencesCountBuffer;

    [NativeName("sequencesCountOffset")]
    public ulong SequencesCountOffset;

    [NativeName("sequencesIndexBuffer")]
    public BufferHandle SequencesIndexBuffer;

    [NativeName("sequencesIndexOffset")]
    public ulong SequencesIndexOffset;

    public GeneratedCommandsInfoNV() { }
}
