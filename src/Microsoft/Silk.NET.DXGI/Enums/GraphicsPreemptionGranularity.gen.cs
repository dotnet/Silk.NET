// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_GRANULARITY")]
    public enum GraphicsPreemptionGranularity : int
    {
        [Obsolete("Deprecated in favour of \"DmaBufferBoundary\"")]
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_DMA_BUFFER_BOUNDARY")]
        GraphicsPreemptionDmaBufferBoundary = 0x0,
        [Obsolete("Deprecated in favour of \"PrimitiveBoundary\"")]
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_PRIMITIVE_BOUNDARY")]
        GraphicsPreemptionPrimitiveBoundary = 0x1,
        [Obsolete("Deprecated in favour of \"TriangleBoundary\"")]
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_TRIANGLE_BOUNDARY")]
        GraphicsPreemptionTriangleBoundary = 0x2,
        [Obsolete("Deprecated in favour of \"PixelBoundary\"")]
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_PIXEL_BOUNDARY")]
        GraphicsPreemptionPixelBoundary = 0x3,
        [Obsolete("Deprecated in favour of \"InstructionBoundary\"")]
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_INSTRUCTION_BOUNDARY")]
        GraphicsPreemptionInstructionBoundary = 0x4,
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_DMA_BUFFER_BOUNDARY")]
        DmaBufferBoundary = 0x0,
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_PRIMITIVE_BOUNDARY")]
        PrimitiveBoundary = 0x1,
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_TRIANGLE_BOUNDARY")]
        TriangleBoundary = 0x2,
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_PIXEL_BOUNDARY")]
        PixelBoundary = 0x3,
        [NativeName("Name", "DXGI_GRAPHICS_PREEMPTION_INSTRUCTION_BOUNDARY")]
        InstructionBoundary = 0x4,
    }
}
