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
        CommandNdrangeKernel = 0x11F0,
        [NativeName("Name", "CL_COMMAND_TASK")]
        CommandTask = 0x11F1,
        [NativeName("Name", "CL_COMMAND_NATIVE_KERNEL")]
        CommandNativeKernel = 0x11F2,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER")]
        CommandReadBuffer = 0x11F3,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER")]
        CommandWriteBuffer = 0x11F4,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER")]
        CommandCopyBuffer = 0x11F5,
        [NativeName("Name", "CL_COMMAND_READ_IMAGE")]
        CommandReadImage = 0x11F6,
        [NativeName("Name", "CL_COMMAND_WRITE_IMAGE")]
        CommandWriteImage = 0x11F7,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE")]
        CommandCopyImage = 0x11F8,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE_TO_BUFFER")]
        CommandCopyImageToBuffer = 0x11F9,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_TO_IMAGE")]
        CommandCopyBufferToImage = 0x11FA,
        [NativeName("Name", "CL_COMMAND_MAP_BUFFER")]
        CommandMapBuffer = 0x11FB,
        [NativeName("Name", "CL_COMMAND_MAP_IMAGE")]
        CommandMapImage = 0x11FC,
        [NativeName("Name", "CL_COMMAND_UNMAP_MEM_OBJECT")]
        CommandUnmapMemObject = 0x11FD,
        [NativeName("Name", "CL_COMMAND_MARKER")]
        CommandMarker = 0x11FE,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GL_OBJECTS")]
        CommandAcquireGLObjects = 0x11FF,
        [NativeName("Name", "CL_COMMAND_RELEASE_GL_OBJECTS")]
        CommandReleaseGLObjects = 0x1200,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER_RECT")]
        CommandReadBufferRect = 0x1201,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER_RECT")]
        CommandWriteBufferRect = 0x1202,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_RECT")]
        CommandCopyBufferRect = 0x1203,
        [NativeName("Name", "CL_COMMAND_USER")]
        CommandUser = 0x1204,
        [NativeName("Name", "CL_COMMAND_BARRIER")]
        CommandBarrier = 0x1205,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECTS")]
        CommandMigrateMemObjects = 0x1206,
        [NativeName("Name", "CL_COMMAND_FILL_BUFFER")]
        CommandFillBuffer = 0x1207,
        [NativeName("Name", "CL_COMMAND_FILL_IMAGE")]
        CommandFillImage = 0x1208,
        [NativeName("Name", "CL_COMMAND_SVM_FREE")]
        CommandSvmFree = 0x1209,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY")]
        CommandSvmMemcpy = 0x120A,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL")]
        CommandSvmMemfill = 0x120B,
        [NativeName("Name", "CL_COMMAND_SVM_MAP")]
        CommandSvmMap = 0x120C,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP")]
        CommandSvmUnmap = 0x120D,
        [NativeName("Name", "CL_COMMAND_SVM_MIGRATE_MEM")]
        CommandSvmMigrateMem = 0x120E,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR")]
        CommandAcquireD3D10ObjectsKhr = 0x4017,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR")]
        CommandReleaseD3D10ObjectsKhr = 0x4018,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR")]
        CommandAcquireD3D11ObjectsKhr = 0x4020,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR")]
        CommandReleaseD3D11ObjectsKhr = 0x4021,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR")]
        CommandAcquireDX9MediaSurfacesKhr = 0x202B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR")]
        CommandReleaseDX9MediaSurfacesKhr = 0x202C,
        [NativeName("Name", "CL_COMMAND_EGL_FENCE_SYNC_OBJECT_KHR")]
        CommandEglFenceSyncObjectKhr = 0x202F,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EGL_OBJECTS_KHR")]
        CommandAcquireEglObjectsKhr = 0x202D,
        [NativeName("Name", "CL_COMMAND_RELEASE_EGL_OBJECTS_KHR")]
        CommandReleaseEglObjectsKhr = 0x202E,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        CommandMigrateMemObjectExt = 0x4040,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        CommandAcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        CommandReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_SVM_FREE_ARM")]
        CommandSvmFreeArm = 0x40BA,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY_ARM")]
        CommandSvmMemcpyArm = 0x40BB,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL_ARM")]
        CommandSvmMemfillArm = 0x40BC,
        [NativeName("Name", "CL_COMMAND_SVM_MAP_ARM")]
        CommandSvmMapArm = 0x40BD,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP_ARM")]
        CommandSvmUnmapArm = 0x40BE,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        CommandGLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandAcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        CommandAcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        CommandReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        CommandMemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        CommandMemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        CommandMigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        CommandMemadviseIntel = 0x4207,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        CommandGenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_WAIT_KHR")]
        CommandSemaphoreWaitKhr = 0x2042,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_SIGNAL_KHR")]
        CommandSemaphoreSignalKhr = 0x2043,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR")]
        CommandAcquireExternalMemObjectsKhr = 0x2047,
        [NativeName("Name", "CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR")]
        CommandReleaseExternalMemObjectsKhr = 0x2048,
        [NativeName("Name", "CL_COMMAND_COMMAND_BUFFER_KHR")]
        CommandCommandBufferKhr = 0x12A8,
    }
}
