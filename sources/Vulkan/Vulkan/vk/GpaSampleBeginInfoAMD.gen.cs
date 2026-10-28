// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaSampleBeginInfoAMD")]
public unsafe partial struct GpaSampleBeginInfoAMD
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GpaSampleBeginInfoAMD;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("sampleType")]
    public GpaSampleTypeAMD SampleType;

    [NativeName("sampleInternalOperations")]
    public MaybeBool<uint> SampleInternalOperations;

    [NativeName("cacheFlushOnCounterCollection")]
    public MaybeBool<uint> CacheFlushOnCounterCollection;

    [NativeName("sqShaderMaskEnable")]
    public MaybeBool<uint> SqShaderMaskEnable;

    [NativeName("sqShaderMask")]
    public GpaSqShaderStageFlagsAMD SqShaderMask;

    [NativeName("perfCounterCount")]
    public uint PerfCounterCount;

    [NativeName("pPerfCounters")]
    public GpaPerfCounterAMD* PPerfCounters;

    [NativeName("streamingPerfTraceSampleInterval")]
    public uint StreamingPerfTraceSampleInterval;

    [NativeName("perfCounterDeviceMemoryLimit")]
    public ulong PerfCounterDeviceMemoryLimit;

    [NativeName("sqThreadTraceEnable")]
    public MaybeBool<uint> SqThreadTraceEnable;

    [NativeName("sqThreadTraceSuppressInstructionTokens")]
    public MaybeBool<uint> SqThreadTraceSuppressInstructionTokens;

    [NativeName("sqThreadTraceDeviceMemoryLimit")]
    public ulong SqThreadTraceDeviceMemoryLimit;

    [NativeName("timingPreSample")]
    public PipelineStageFlags TimingPreSample;

    [NativeName("timingPostSample")]
    public PipelineStageFlags TimingPostSample;

    public GpaSampleBeginInfoAMD() { }
}
