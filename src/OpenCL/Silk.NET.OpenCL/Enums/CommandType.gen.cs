// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_command_type")]
    public enum CommandType : int
    {
        [NativeName("Name", "CL_COMMAND_NDRANGE_KERNEL")]
        NdrangeKernel = 0x11F0,
        [NativeName("Name", "CL_COMMAND_TASK")]
        Task = 0x11F1,
        [NativeName("Name", "CL_COMMAND_NATIVE_KERNEL")]
        NativeKernel = 0x11F2,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER")]
        ReadBuffer = 0x11F3,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER")]
        WriteBuffer = 0x11F4,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER")]
        CopyBuffer = 0x11F5,
        [NativeName("Name", "CL_COMMAND_READ_IMAGE")]
        ReadImage = 0x11F6,
        [NativeName("Name", "CL_COMMAND_WRITE_IMAGE")]
        WriteImage = 0x11F7,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE")]
        CopyImage = 0x11F8,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE_TO_BUFFER")]
        CopyImageToBuffer = 0x11F9,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_TO_IMAGE")]
        CopyBufferToImage = 0x11FA,
        [NativeName("Name", "CL_COMMAND_MAP_BUFFER")]
        MapBuffer = 0x11FB,
        [NativeName("Name", "CL_COMMAND_MAP_IMAGE")]
        MapImage = 0x11FC,
        [NativeName("Name", "CL_COMMAND_UNMAP_MEM_OBJECT")]
        UnmapMemObject = 0x11FD,
        [NativeName("Name", "CL_COMMAND_MARKER")]
        Marker = 0x11FE,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GL_OBJECTS")]
        AcquireGLObjects = 0x11FF,
        [NativeName("Name", "CL_COMMAND_RELEASE_GL_OBJECTS")]
        ReleaseGLObjects = 0x1200,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER_RECT")]
        ReadBufferRect = 0x1201,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER_RECT")]
        WriteBufferRect = 0x1202,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_RECT")]
        CopyBufferRect = 0x1203,
        [NativeName("Name", "CL_COMMAND_USER")]
        User = 0x1204,
        [NativeName("Name", "CL_COMMAND_BARRIER")]
        Barrier = 0x1205,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECTS")]
        MigrateMemObjects = 0x1206,
        [NativeName("Name", "CL_COMMAND_FILL_BUFFER")]
        FillBuffer = 0x1207,
        [NativeName("Name", "CL_COMMAND_FILL_IMAGE")]
        FillImage = 0x1208,
        [NativeName("Name", "CL_COMMAND_SVM_FREE")]
        SvmFree = 0x1209,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY")]
        SvmMemcpy = 0x120A,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL")]
        SvmMemfill = 0x120B,
        [NativeName("Name", "CL_COMMAND_SVM_MAP")]
        SvmMap = 0x120C,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP")]
        SvmUnmap = 0x120D,
        [NativeName("Name", "CL_COMMAND_SVM_MIGRATE_MEM")]
        SvmMigrateMem = 0x120E,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR")]
        AcquireD3D10ObjectsKhr = 0x4017,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR")]
        ReleaseD3D10ObjectsKhr = 0x4018,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR")]
        AcquireD3D11ObjectsKhr = 0x4020,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR")]
        ReleaseD3D11ObjectsKhr = 0x4021,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR")]
        AcquireDX9MediaSurfacesKhr = 0x202B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR")]
        ReleaseDX9MediaSurfacesKhr = 0x202C,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        MigrateMemObjectExt = 0x4040,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        AcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        ReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_SVM_FREE_ARM")]
        SvmFreeArm = 0x40BA,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY_ARM")]
        SvmMemcpyArm = 0x40BB,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL_ARM")]
        SvmMemfillArm = 0x40BC,
        [NativeName("Name", "CL_COMMAND_SVM_MAP_ARM")]
        SvmMapArm = 0x40BD,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP_ARM")]
        SvmUnmapArm = 0x40BE,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        GLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        AcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        ReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        AcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        ReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        MemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        MemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        MigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        MemadviseIntel = 0x4207,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        GenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_WAIT_KHR")]
        SemaphoreWaitKhr = 0x2042,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_SIGNAL_KHR")]
        SemaphoreSignalKhr = 0x2043,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR")]
        AcquireExternalMemObjectsKhr = 0x2047,
        [NativeName("Name", "CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR")]
        ReleaseExternalMemObjectsKhr = 0x2048,
        [NativeName("Name", "CL_COMMAND_COMMAND_BUFFER_KHR")]
        CommandBufferKhr = 0x12A8,
    }
}
