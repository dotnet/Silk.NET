// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [NativeName("Name", "GLenum")]
    public enum IMG : int
    {
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        MemUseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        MemUseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MIPMAP_FILTER_ANY_IMG")]
        MipmapFilterAnyImg = 0x0,
        [NativeName("Name", "CL_MIPMAP_FILTER_BOX_IMG")]
        MipmapFilterBoxImg = 0x1,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        CommandGenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        MemAllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
        MemAllocRelaxRequirementsImg = 0x1,
        [NativeName("Name", "CL_GRALLOC_RESOURCE_NOT_ACQUIRED_IMG")]
        GrallocResourceNotAcquiredImg = 0x40D4,
        [NativeName("Name", "CL_INVALID_GRALLOC_OBJECT_IMG")]
        InvalidGrallocObjectImg = 0x40D5,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        MemUseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        CommandAcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        CommandReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_NV21_IMG")]
        NV21Img = 0x40D0,
        [NativeName("Name", "CL_YV12_IMG")]
        YV12Img = 0x40D1,
    }
}
