// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.AMD
{
    [NativeName("Name", "GLenum")]
    public enum AMD : int
    {
        [Obsolete("Deprecated in favour of \"VendorAmd\"")]
        [NativeName("Name", "WGL_GPU_VENDOR_AMD")]
        GpuVendorAmd = 0x1F00,
        [Obsolete("Deprecated in favour of \"RendererStringAmd\"")]
        [NativeName("Name", "WGL_GPU_RENDERER_STRING_AMD")]
        GpuRendererStringAmd = 0x1F01,
        [Obsolete("Deprecated in favour of \"OpenglVersionStringAmd\"")]
        [NativeName("Name", "WGL_GPU_OPENGL_VERSION_STRING_AMD")]
        GpuOpenglVersionStringAmd = 0x1F02,
        [Obsolete("Deprecated in favour of \"FastestTargetGpusAmd\"")]
        [NativeName("Name", "WGL_GPU_FASTEST_TARGET_GPUS_AMD")]
        GpuFastestTargetGpusAmd = 0x21A2,
        [Obsolete("Deprecated in favour of \"RamAmd\"")]
        [NativeName("Name", "WGL_GPU_RAM_AMD")]
        GpuRamAmd = 0x21A3,
        [Obsolete("Deprecated in favour of \"ClockAmd\"")]
        [NativeName("Name", "WGL_GPU_CLOCK_AMD")]
        GpuClockAmd = 0x21A4,
        [Obsolete("Deprecated in favour of \"NumPipesAmd\"")]
        [NativeName("Name", "WGL_GPU_NUM_PIPES_AMD")]
        GpuNumPipesAmd = 0x21A5,
        [Obsolete("Deprecated in favour of \"NumSimdAmd\"")]
        [NativeName("Name", "WGL_GPU_NUM_SIMD_AMD")]
        GpuNumSimdAmd = 0x21A6,
        [Obsolete("Deprecated in favour of \"NumRBAmd\"")]
        [NativeName("Name", "WGL_GPU_NUM_RB_AMD")]
        GpuNumRBAmd = 0x21A7,
        [Obsolete("Deprecated in favour of \"NumSpiAmd\"")]
        [NativeName("Name", "WGL_GPU_NUM_SPI_AMD")]
        GpuNumSpiAmd = 0x21A8,
        [NativeName("Name", "WGL_GPU_VENDOR_AMD")]
        VendorAmd = 0x1F00,
        [NativeName("Name", "WGL_GPU_RENDERER_STRING_AMD")]
        RendererStringAmd = 0x1F01,
        [NativeName("Name", "WGL_GPU_OPENGL_VERSION_STRING_AMD")]
        OpenglVersionStringAmd = 0x1F02,
        [NativeName("Name", "WGL_GPU_FASTEST_TARGET_GPUS_AMD")]
        FastestTargetGpusAmd = 0x21A2,
        [NativeName("Name", "WGL_GPU_RAM_AMD")]
        RamAmd = 0x21A3,
        [NativeName("Name", "WGL_GPU_CLOCK_AMD")]
        ClockAmd = 0x21A4,
        [NativeName("Name", "WGL_GPU_NUM_PIPES_AMD")]
        NumPipesAmd = 0x21A5,
        [NativeName("Name", "WGL_GPU_NUM_SIMD_AMD")]
        NumSimdAmd = 0x21A6,
        [NativeName("Name", "WGL_GPU_NUM_RB_AMD")]
        NumRBAmd = 0x21A7,
        [NativeName("Name", "WGL_GPU_NUM_SPI_AMD")]
        NumSpiAmd = 0x21A8,
    }
}
