// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    public enum NVX
    {
        GpuMemoryInfoDedicatedVidmemNvx = 0x9047,
        GpuMemoryInfoTotalAvailableMemoryNvx = 0x9048,
        GpuMemoryInfoCurrentAvailableVidmemNvx = 0x9049,
        GpuMemoryInfoEvictionCountNvx = 0x904A,
        GpuMemoryInfoEvictedMemoryNvx = 0x904B,
        UploadGpuMaskNvx = 0x954A,
        LgpuSeparateStorageBitNvx = 0x800,
        MaxLgpuGpusNvx = 0x92BA,
    }
}
