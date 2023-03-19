// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_GRANULARITY")]
    public enum ComputePreemptionGranularity : int
    {
        [Obsolete("Deprecated in favour of \"DmaBufferBoundary\"")]
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY")]
        ComputePreemptionDmaBufferBoundary = 0x0,
        [Obsolete("Deprecated in favour of \"DispatchBoundary\"")]
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY")]
        ComputePreemptionDispatchBoundary = 0x1,
        [Obsolete("Deprecated in favour of \"ThreadGroupBoundary\"")]
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY")]
        ComputePreemptionThreadGroupBoundary = 0x2,
        [Obsolete("Deprecated in favour of \"ThreadBoundary\"")]
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY")]
        ComputePreemptionThreadBoundary = 0x3,
        [Obsolete("Deprecated in favour of \"InstructionBoundary\"")]
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY")]
        ComputePreemptionInstructionBoundary = 0x4,
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY")]
        DmaBufferBoundary = 0x0,
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY")]
        DispatchBoundary = 0x1,
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY")]
        ThreadGroupBoundary = 0x2,
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY")]
        ThreadBoundary = 0x3,
        [NativeName("Name", "DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY")]
        InstructionBoundary = 0x4,
    }
}
