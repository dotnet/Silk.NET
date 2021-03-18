// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [NativeName("Name", "GLenum")]
    public enum NVX : int
    {
        [NativeName("Name", "GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX")]
        GpuMemoryInfoDedicatedVidmemNvx = 0x9047,
        [NativeName("Name", "GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX")]
        GpuMemoryInfoTotalAvailableMemoryNvx = 0x9048,
        [NativeName("Name", "GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX")]
        GpuMemoryInfoCurrentAvailableVidmemNvx = 0x9049,
        [NativeName("Name", "GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX")]
        GpuMemoryInfoEvictionCountNvx = 0x904A,
        [NativeName("Name", "GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX")]
        GpuMemoryInfoEvictedMemoryNvx = 0x904B,
        [NativeName("Name", "GL_UPLOAD_GPU_MASK_NVX")]
        UploadGpuMaskNvx = 0x954A,
        [NativeName("Name", "GL_LGPU_SEPARATE_STORAGE_BIT_NVX")]
        LgpuSeparateStorageBitNvx = 0x800,
        [NativeName("Name", "GL_MAX_LGPU_GPUS_NVX")]
        MaxLgpuGpusNvx = 0x92BA,
    }
}
