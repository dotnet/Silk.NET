// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_type")]
public enum CommandType : uint
{
    [NativeName("CL_COMMAND_NDRANGE_KERNEL")]
    NdrangeKernel = 4592,

    [NativeName("CL_COMMAND_TASK")]
    Task = 4593,

    [NativeName("CL_COMMAND_NATIVE_KERNEL")]
    NativeKernel = 4594,

    [NativeName("CL_COMMAND_READ_BUFFER")]
    ReadBuffer = 4595,

    [NativeName("CL_COMMAND_WRITE_BUFFER")]
    WriteBuffer = 4596,

    [NativeName("CL_COMMAND_COPY_BUFFER")]
    CopyBuffer = 4597,

    [NativeName("CL_COMMAND_READ_IMAGE")]
    ReadImage = 4598,

    [NativeName("CL_COMMAND_WRITE_IMAGE")]
    WriteImage = 4599,

    [NativeName("CL_COMMAND_COPY_IMAGE")]
    CopyImage = 4600,

    [NativeName("CL_COMMAND_COPY_IMAGE_TO_BUFFER")]
    CopyImageToBuffer = 4601,

    [NativeName("CL_COMMAND_COPY_BUFFER_TO_IMAGE")]
    CopyBufferToImage = 4602,

    [NativeName("CL_COMMAND_MAP_BUFFER")]
    MapBuffer = 4603,

    [NativeName("CL_COMMAND_MAP_IMAGE")]
    MapImage = 4604,

    [NativeName("CL_COMMAND_UNMAP_MEM_OBJECT")]
    UnmapMemObject = 4605,

    [NativeName("CL_COMMAND_MARKER")]
    Marker = 4606,

    [NativeName("CL_COMMAND_ACQUIRE_GL_OBJECTS")]
    AcquireGlObjects = 4607,

    [NativeName("CL_COMMAND_RELEASE_GL_OBJECTS")]
    ReleaseGlObjects = 4608,

    [NativeName("CL_COMMAND_READ_BUFFER_RECT")]
    ReadBufferRect = 4609,

    [NativeName("CL_COMMAND_WRITE_BUFFER_RECT")]
    WriteBufferRect = 4610,

    [NativeName("CL_COMMAND_COPY_BUFFER_RECT")]
    CopyBufferRect = 4611,

    [NativeName("CL_COMMAND_USER")]
    User = 4612,

    [NativeName("CL_COMMAND_BARRIER")]
    Barrier = 4613,

    [NativeName("CL_COMMAND_MIGRATE_MEM_OBJECTS")]
    MigrateMemObjects = 4614,

    [NativeName("CL_COMMAND_FILL_BUFFER")]
    FillBuffer = 4615,

    [NativeName("CL_COMMAND_FILL_IMAGE")]
    FillImage = 4616,

    [NativeName("CL_COMMAND_SVM_FREE")]
    SvmFree = 4617,

    [NativeName("CL_COMMAND_SVM_MEMCPY")]
    SvmMemcpy = 4618,

    [NativeName("CL_COMMAND_SVM_MEMFILL")]
    SvmMemfill = 4619,

    [NativeName("CL_COMMAND_SVM_MAP")]
    SvmMap = 4620,

    [NativeName("CL_COMMAND_SVM_UNMAP")]
    SvmUnmap = 4621,

    [NativeName("CL_COMMAND_SVM_MIGRATE_MEM")]
    SvmMigrateMem = 4622,

    [NativeName("CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
    MigrateMemObjectEXT = 16448,

    [NativeName("CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
    AcquireGrallocObjectsIMG = 16594,

    [NativeName("CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
    ReleaseGrallocObjectsIMG = 16595,

    [NativeName("CL_COMMAND_GENERATE_MIPMAP_IMG")]
    GenerateMipmapIMG = 16598,

    [NativeName("CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR")]
    AcquireExternalMemObjectsKHR = 8263,

    [NativeName("CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR")]
    ReleaseExternalMemObjectsKHR = 8264,

    [NativeName("CL_COMMAND_SEMAPHORE_WAIT_KHR")]
    SemaphoreWaitKHR = 8258,

    [NativeName("CL_COMMAND_SEMAPHORE_SIGNAL_KHR")]
    SemaphoreSignalKHR = 8259,

    [NativeName("CL_COMMAND_SVM_FREE_ARM")]
    SvmFreeARM = 16570,

    [NativeName("CL_COMMAND_SVM_MEMCPY_ARM")]
    SvmMemcpyARM = 16571,

    [NativeName("CL_COMMAND_SVM_MEMFILL_ARM")]
    SvmMemfillARM = 16572,

    [NativeName("CL_COMMAND_SVM_MAP_ARM")]
    SvmMapARM = 16573,

    [NativeName("CL_COMMAND_SVM_UNMAP_ARM")]
    SvmUnmapARM = 16574,

    [NativeName("CL_COMMAND_MEMFILL_INTEL")]
    MemfillINTEL = 16900,

    [NativeName("CL_COMMAND_MEMCPY_INTEL")]
    MemcpyINTEL = 16901,

    [NativeName("CL_COMMAND_MIGRATEMEM_INTEL")]
    MigratememINTEL = 16902,

    [NativeName("CL_COMMAND_MEMADVISE_INTEL")]
    MemadviseINTEL = 16903,
}
