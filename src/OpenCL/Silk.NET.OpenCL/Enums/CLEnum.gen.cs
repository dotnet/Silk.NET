// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum CLEnum : int
    {
        [NativeName("Name", "CL_ADDRESS_NONE")]
        None = 0x1130,
        [NativeName("Name", "CL_ADDRESS_NONE")]
        AddressNone = 0x1130,
        [NativeName("Name", "CL_ADDRESS_CLAMP_TO_EDGE")]
        ClampToEdge = 0x1131,
        [NativeName("Name", "CL_ADDRESS_CLAMP_TO_EDGE")]
        AddressClampToEdge = 0x1131,
        [NativeName("Name", "CL_ADDRESS_CLAMP")]
        Clamp = 0x1132,
        [NativeName("Name", "CL_ADDRESS_CLAMP")]
        AddressClamp = 0x1132,
        [NativeName("Name", "CL_ADDRESS_REPEAT")]
        Repeat = 0x1133,
        [NativeName("Name", "CL_ADDRESS_REPEAT")]
        AddressRepeat = 0x1133,
        [NativeName("Name", "CL_ADDRESS_MIRRORED_REPEAT")]
        MirroredRepeat = 0x1134,
        [NativeName("Name", "CL_ADDRESS_MIRRORED_REPEAT")]
        AddressMirroredRepeat = 0x1134,
        [NativeName("Name", "CL_FALSE")]
        False = 0x0,
        [NativeName("Name", "CL_TRUE")]
        True = 0x1,
        [NativeName("Name", "CL_BLOCKING")]
        Blocking = 0x1,
        [NativeName("Name", "CL_NON_BLOCKING")]
        NonBlocking = 0x0,
        [NativeName("Name", "CL_BUFFER_CREATE_TYPE_REGION")]
        Region = 0x1220,
        [NativeName("Name", "CL_BUFFER_CREATE_TYPE_REGION")]
        BufferCreateTypeRegion = 0x1220,
        [NativeName("Name", "CL_BUILD_SUCCESS")]
        Success = 0x0,
        [NativeName("Name", "CL_BUILD_SUCCESS")]
        BuildSuccess = 0x0,
        [NativeName("Name", "CL_BUILD_NONE")]
        BuildNone = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "CL_BUILD_ERROR")]
        Error = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_BUILD_ERROR")]
        BuildError = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_BUILD_IN_PROGRESS")]
        InProgress = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "CL_BUILD_IN_PROGRESS")]
        BuildInProgress = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "CL_R")]
        R = 0x10B0,
        [NativeName("Name", "CL_A")]
        A = 0x10B1,
        [NativeName("Name", "CL_RG")]
        RG = 0x10B2,
        [NativeName("Name", "CL_RA")]
        RA = 0x10B3,
        [NativeName("Name", "CL_RGB")]
        Rgb = 0x10B4,
        [NativeName("Name", "CL_RGBA")]
        Rgba = 0x10B5,
        [NativeName("Name", "CL_BGRA")]
        Bgra = 0x10B6,
        [NativeName("Name", "CL_ARGB")]
        Argb = 0x10B7,
        [NativeName("Name", "CL_INTENSITY")]
        Intensity = 0x10B8,
        [NativeName("Name", "CL_LUMINANCE")]
        Luminance = 0x10B9,
        [NativeName("Name", "CL_Rx")]
        Rx = 0x10BA,
        [NativeName("Name", "CL_RGx")]
        RGx = 0x10BB,
        [NativeName("Name", "CL_RGBx")]
        Rgbx = 0x10BC,
        [NativeName("Name", "CL_DEPTH")]
        Depth = 0x10BD,
        [NativeName("Name", "CL_sRGB")]
        SRgb = 0x10BF,
        [NativeName("Name", "CL_sRGBx")]
        SRgbx = 0x10C0,
        [NativeName("Name", "CL_sRGBA")]
        SRgba = 0x10C1,
        [NativeName("Name", "CL_sBGRA")]
        SBgra = 0x10C2,
        [NativeName("Name", "CL_ABGR")]
        Abgr = 0x10C3,
        [NativeName("Name", "CL_NV21_IMG")]
        NV21Img = 0x40D0,
        [NativeName("Name", "CL_YV12_IMG")]
        YV12Img = 0x40D1,
        [NativeName("Name", "CL_YUYV_INTEL")]
        YuyvIntel = 0x4076,
        [NativeName("Name", "CL_UYVY_INTEL")]
        UyvyIntel = 0x4077,
        [NativeName("Name", "CL_YVYU_INTEL")]
        YvyuIntel = 0x4078,
        [NativeName("Name", "CL_VYUY_INTEL")]
        VyuyIntel = 0x4079,
        [NativeName("Name", "CL_NV12_INTEL")]
        NV12Intel = 0x410E,
        [NativeName("Name", "CL_DEPTH_STENCIL")]
        DepthStencil = 0x10BE,
        [NativeName("Name", "CL_SNORM_INT8")]
        SNormInt8 = 0x10D0,
        [NativeName("Name", "CL_SNORM_INT16")]
        SNormInt16 = 0x10D1,
        [NativeName("Name", "CL_UNORM_INT8")]
        UnormInt8 = 0x10D2,
        [NativeName("Name", "CL_UNORM_INT16")]
        UnormInt16 = 0x10D3,
        [NativeName("Name", "CL_UNORM_SHORT_565")]
        UnormShort565 = 0x10D4,
        [NativeName("Name", "CL_UNORM_SHORT_555")]
        UnormShort555 = 0x10D5,
        [NativeName("Name", "CL_UNORM_INT_101010")]
        UnormInt101010 = 0x10D6,
        [NativeName("Name", "CL_SIGNED_INT8")]
        SignedInt8 = 0x10D7,
        [NativeName("Name", "CL_SIGNED_INT16")]
        SignedInt16 = 0x10D8,
        [NativeName("Name", "CL_SIGNED_INT32")]
        SignedInt32 = 0x10D9,
        [NativeName("Name", "CL_UNSIGNED_INT8")]
        UnsignedInt8 = 0x10DA,
        [NativeName("Name", "CL_UNSIGNED_INT16")]
        UnsignedInt16 = 0x10DB,
        [NativeName("Name", "CL_UNSIGNED_INT32")]
        UnsignedInt32 = 0x10DC,
        [NativeName("Name", "CL_HALF_FLOAT")]
        HalfFloat = 0x10DD,
        [NativeName("Name", "CL_FLOAT")]
        Float = 0x10DE,
        [NativeName("Name", "CL_UNORM_INT_101010_2")]
        UnormInt1010102 = 0x10E0,
        [NativeName("Name", "CL_UNORM_INT24")]
        UnormInt24 = 0x10DF,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW10_EXT")]
        UnsignedIntRaw10Ext = 0x10E3,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW12_EXT")]
        UnsignedIntRaw12Ext = 0x10E4,
        [NativeName("Name", "CL_UNORM_INT_2_101010_EXT")]
        UnormInt2101010Ext = 0x10E5,
        [NativeName("Name", "CL_COMPLETE")]
        Complete = 0x0,
        [NativeName("Name", "CL_RUNNING")]
        Running = 0x1,
        [NativeName("Name", "CL_SUBMITTED")]
        Submitted = 0x2,
        [NativeName("Name", "CL_QUEUED")]
        Queued = 0x3,
        [NativeName("Name", "CL_QUEUE_CONTEXT")]
        Context = 0x1090,
        [NativeName("Name", "CL_QUEUE_CONTEXT")]
        QueueContext = 0x1090,
        [NativeName("Name", "CL_QUEUE_DEVICE")]
        Device = 0x1091,
        [NativeName("Name", "CL_QUEUE_DEVICE")]
        QueueDevice = 0x1091,
        [NativeName("Name", "CL_QUEUE_REFERENCE_COUNT")]
        ReferenceCount = 0x1092,
        [NativeName("Name", "CL_QUEUE_REFERENCE_COUNT")]
        QueueReferenceCount = 0x1092,
        [NativeName("Name", "CL_QUEUE_PROPERTIES")]
        Properties = 0x1093,
        [NativeName("Name", "CL_QUEUE_PROPERTIES")]
        QueueProperties = 0x1093,
        [NativeName("Name", "CL_QUEUE_SIZE")]
        Size = 0x1094,
        [NativeName("Name", "CL_QUEUE_SIZE")]
        QueueSize = 0x1094,
        [NativeName("Name", "CL_QUEUE_DEVICE_DEFAULT")]
        DeviceDefault = 0x1095,
        [NativeName("Name", "CL_QUEUE_DEVICE_DEFAULT")]
        QueueDeviceDefault = 0x1095,
        [NativeName("Name", "CL_QUEUE_PROPERTIES_ARRAY")]
        PropertiesArray = 0x1098,
        [NativeName("Name", "CL_QUEUE_PROPERTIES_ARRAY")]
        QueuePropertiesArray = 0x1098,
        [NativeName("Name", "CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
        OutOfOrderExecModeEnable = 0x1,
        [NativeName("Name", "CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
        QueueOutOfOrderExecModeEnable = 0x1,
        [NativeName("Name", "CL_QUEUE_PROFILING_ENABLE")]
        ProfilingEnable = 0x2,
        [NativeName("Name", "CL_QUEUE_PROFILING_ENABLE")]
        QueueProfilingEnable = 0x2,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE")]
        OnDevice = 0x4,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE")]
        QueueOnDevice = 0x4,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE_DEFAULT")]
        OnDeviceDefault = 0x8,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE_DEFAULT")]
        QueueOnDeviceDefault = 0x8,
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        ThreadLocalExecEnableIntel = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_QUEUE_THREAD_LOCAL_EXEC_ENABLE_INTEL")]
        QueueThreadLocalExecEnableIntel = unchecked((int) 0x80000000),
        [NativeName("Name", "CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
        NoSyncOperationsIntel = 0x20000000,
        [NativeName("Name", "CL_QUEUE_NO_SYNC_OPERATIONS_INTEL")]
        QueueNoSyncOperationsIntel = 0x20000000,
        [NativeName("Name", "CL_COMMAND_NDRANGE_KERNEL")]
        NdrangeKernel = 0x11F0,
        [NativeName("Name", "CL_COMMAND_NDRANGE_KERNEL")]
        CommandNdrangeKernel = 0x11F0,
        [NativeName("Name", "CL_COMMAND_TASK")]
        Task = 0x11F1,
        [NativeName("Name", "CL_COMMAND_TASK")]
        CommandTask = 0x11F1,
        [NativeName("Name", "CL_COMMAND_NATIVE_KERNEL")]
        NativeKernel = 0x11F2,
        [NativeName("Name", "CL_COMMAND_NATIVE_KERNEL")]
        CommandNativeKernel = 0x11F2,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER")]
        ReadBuffer = 0x11F3,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER")]
        CommandReadBuffer = 0x11F3,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER")]
        WriteBuffer = 0x11F4,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER")]
        CommandWriteBuffer = 0x11F4,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER")]
        CopyBuffer = 0x11F5,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER")]
        CommandCopyBuffer = 0x11F5,
        [NativeName("Name", "CL_COMMAND_READ_IMAGE")]
        ReadImage = 0x11F6,
        [NativeName("Name", "CL_COMMAND_READ_IMAGE")]
        CommandReadImage = 0x11F6,
        [NativeName("Name", "CL_COMMAND_WRITE_IMAGE")]
        WriteImage = 0x11F7,
        [NativeName("Name", "CL_COMMAND_WRITE_IMAGE")]
        CommandWriteImage = 0x11F7,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE")]
        CopyImage = 0x11F8,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE")]
        CommandCopyImage = 0x11F8,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE_TO_BUFFER")]
        CopyImageToBuffer = 0x11F9,
        [NativeName("Name", "CL_COMMAND_COPY_IMAGE_TO_BUFFER")]
        CommandCopyImageToBuffer = 0x11F9,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_TO_IMAGE")]
        CopyBufferToImage = 0x11FA,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_TO_IMAGE")]
        CommandCopyBufferToImage = 0x11FA,
        [NativeName("Name", "CL_COMMAND_MAP_BUFFER")]
        MapBuffer = 0x11FB,
        [NativeName("Name", "CL_COMMAND_MAP_BUFFER")]
        CommandMapBuffer = 0x11FB,
        [NativeName("Name", "CL_COMMAND_MAP_IMAGE")]
        MapImage = 0x11FC,
        [NativeName("Name", "CL_COMMAND_MAP_IMAGE")]
        CommandMapImage = 0x11FC,
        [NativeName("Name", "CL_COMMAND_UNMAP_MEM_OBJECT")]
        UnmapMemObject = 0x11FD,
        [NativeName("Name", "CL_COMMAND_UNMAP_MEM_OBJECT")]
        CommandUnmapMemObject = 0x11FD,
        [NativeName("Name", "CL_COMMAND_MARKER")]
        Marker = 0x11FE,
        [NativeName("Name", "CL_COMMAND_MARKER")]
        CommandMarker = 0x11FE,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GL_OBJECTS")]
        AcquireGLObjects = 0x11FF,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GL_OBJECTS")]
        CommandAcquireGLObjects = 0x11FF,
        [NativeName("Name", "CL_COMMAND_RELEASE_GL_OBJECTS")]
        ReleaseGLObjects = 0x1200,
        [NativeName("Name", "CL_COMMAND_RELEASE_GL_OBJECTS")]
        CommandReleaseGLObjects = 0x1200,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER_RECT")]
        ReadBufferRect = 0x1201,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER_RECT")]
        CommandReadBufferRect = 0x1201,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER_RECT")]
        WriteBufferRect = 0x1202,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER_RECT")]
        CommandWriteBufferRect = 0x1202,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_RECT")]
        CopyBufferRect = 0x1203,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_RECT")]
        CommandCopyBufferRect = 0x1203,
        [NativeName("Name", "CL_COMMAND_USER")]
        User = 0x1204,
        [NativeName("Name", "CL_COMMAND_USER")]
        CommandUser = 0x1204,
        [NativeName("Name", "CL_COMMAND_BARRIER")]
        Barrier = 0x1205,
        [NativeName("Name", "CL_COMMAND_BARRIER")]
        CommandBarrier = 0x1205,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECTS")]
        MigrateMemObjects = 0x1206,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECTS")]
        CommandMigrateMemObjects = 0x1206,
        [NativeName("Name", "CL_COMMAND_FILL_BUFFER")]
        FillBuffer = 0x1207,
        [NativeName("Name", "CL_COMMAND_FILL_BUFFER")]
        CommandFillBuffer = 0x1207,
        [NativeName("Name", "CL_COMMAND_FILL_IMAGE")]
        FillImage = 0x1208,
        [NativeName("Name", "CL_COMMAND_FILL_IMAGE")]
        CommandFillImage = 0x1208,
        [NativeName("Name", "CL_COMMAND_SVM_FREE")]
        SvmFree = 0x1209,
        [NativeName("Name", "CL_COMMAND_SVM_FREE")]
        CommandSvmFree = 0x1209,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY")]
        SvmMemcpy = 0x120A,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY")]
        CommandSvmMemcpy = 0x120A,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL")]
        SvmMemfill = 0x120B,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL")]
        CommandSvmMemfill = 0x120B,
        [NativeName("Name", "CL_COMMAND_SVM_MAP")]
        SvmMap = 0x120C,
        [NativeName("Name", "CL_COMMAND_SVM_MAP")]
        CommandSvmMap = 0x120C,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP")]
        SvmUnmap = 0x120D,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP")]
        CommandSvmUnmap = 0x120D,
        [NativeName("Name", "CL_COMMAND_SVM_MIGRATE_MEM")]
        SvmMigrateMem = 0x120E,
        [NativeName("Name", "CL_COMMAND_SVM_MIGRATE_MEM")]
        CommandSvmMigrateMem = 0x120E,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR")]
        AcquireD3D10ObjectsKhr = 0x4017,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D10_OBJECTS_KHR")]
        CommandAcquireD3D10ObjectsKhr = 0x4017,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR")]
        ReleaseD3D10ObjectsKhr = 0x4018,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D10_OBJECTS_KHR")]
        CommandReleaseD3D10ObjectsKhr = 0x4018,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR")]
        AcquireD3D11ObjectsKhr = 0x4020,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_D3D11_OBJECTS_KHR")]
        CommandAcquireD3D11ObjectsKhr = 0x4020,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR")]
        ReleaseD3D11ObjectsKhr = 0x4021,
        [NativeName("Name", "CL_COMMAND_RELEASE_D3D11_OBJECTS_KHR")]
        CommandReleaseD3D11ObjectsKhr = 0x4021,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR")]
        AcquireDX9MediaSurfacesKhr = 0x202B,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_MEDIA_SURFACES_KHR")]
        CommandAcquireDX9MediaSurfacesKhr = 0x202B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR")]
        ReleaseDX9MediaSurfacesKhr = 0x202C,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_MEDIA_SURFACES_KHR")]
        CommandReleaseDX9MediaSurfacesKhr = 0x202C,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        MigrateMemObjectExt = 0x4040,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        CommandMigrateMemObjectExt = 0x4040,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        AcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        CommandAcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        ReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        CommandReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_SVM_FREE_ARM")]
        SvmFreeArm = 0x40BA,
        [NativeName("Name", "CL_COMMAND_SVM_FREE_ARM")]
        CommandSvmFreeArm = 0x40BA,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY_ARM")]
        SvmMemcpyArm = 0x40BB,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY_ARM")]
        CommandSvmMemcpyArm = 0x40BB,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL_ARM")]
        SvmMemfillArm = 0x40BC,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL_ARM")]
        CommandSvmMemfillArm = 0x40BC,
        [NativeName("Name", "CL_COMMAND_SVM_MAP_ARM")]
        SvmMapArm = 0x40BD,
        [NativeName("Name", "CL_COMMAND_SVM_MAP_ARM")]
        CommandSvmMapArm = 0x40BD,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP_ARM")]
        SvmUnmapArm = 0x40BE,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP_ARM")]
        CommandSvmUnmapArm = 0x40BE,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        GLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        CommandGLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        AcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandAcquireVAApiMediaSurfacesIntel = 0x409A,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        ReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_RELEASE_VA_API_MEDIA_SURFACES_INTEL")]
        CommandReleaseVAApiMediaSurfacesIntel = 0x409B,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        AcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_DX9_OBJECTS_INTEL")]
        CommandAcquireDX9ObjectsIntel = 0x402A,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        ReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_RELEASE_DX9_OBJECTS_INTEL")]
        CommandReleaseDX9ObjectsIntel = 0x402B,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        MemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMFILL_INTEL")]
        CommandMemfillIntel = 0x4204,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        MemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MEMCPY_INTEL")]
        CommandMemcpyIntel = 0x4205,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        MigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MIGRATEMEM_INTEL")]
        CommandMigratememIntel = 0x4206,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        MemadviseIntel = 0x4207,
        [NativeName("Name", "CL_COMMAND_MEMADVISE_INTEL")]
        CommandMemadviseIntel = 0x4207,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        GenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        CommandGenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_WAIT_KHR")]
        SemaphoreWaitKhr = 0x2042,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_WAIT_KHR")]
        CommandSemaphoreWaitKhr = 0x2042,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_SIGNAL_KHR")]
        SemaphoreSignalKhr = 0x2043,
        [NativeName("Name", "CL_COMMAND_SEMAPHORE_SIGNAL_KHR")]
        CommandSemaphoreSignalKhr = 0x2043,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR")]
        AcquireExternalMemObjectsKhr = 0x2047,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EXTERNAL_MEM_OBJECTS_KHR")]
        CommandAcquireExternalMemObjectsKhr = 0x2047,
        [NativeName("Name", "CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR")]
        ReleaseExternalMemObjectsKhr = 0x2048,
        [NativeName("Name", "CL_COMMAND_RELEASE_EXTERNAL_MEM_OBJECTS_KHR")]
        CommandReleaseExternalMemObjectsKhr = 0x2048,
        [NativeName("Name", "CL_COMMAND_COMMAND_BUFFER_KHR")]
        CommandBufferKhr = 0x12A8,
        [NativeName("Name", "CL_COMMAND_COMMAND_BUFFER_KHR")]
        CommandCommandBufferKhr = 0x12A8,
        [NativeName("Name", "CL_CONTEXT_REFERENCE_COUNT")]
        ContextReferenceCount = 0x1080,
        [NativeName("Name", "CL_CONTEXT_DEVICES")]
        Devices = 0x1081,
        [NativeName("Name", "CL_CONTEXT_DEVICES")]
        ContextDevices = 0x1081,
        [NativeName("Name", "CL_CONTEXT_PROPERTIES")]
        ContextProperties = 0x1082,
        [NativeName("Name", "CL_CONTEXT_NUM_DEVICES")]
        NumDevices = 0x1083,
        [NativeName("Name", "CL_CONTEXT_NUM_DEVICES")]
        ContextNumDevices = 0x1083,
        [NativeName("Name", "CL_CONTEXT_D3D10_DEVICE_KHR")]
        D3D10DeviceKhr = 0x4014,
        [NativeName("Name", "CL_CONTEXT_D3D10_DEVICE_KHR")]
        ContextD3D10DeviceKhr = 0x4014,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        D3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_CONTEXT_D3D11_DEVICE_KHR")]
        D3D11DeviceKhr = 0x401D,
        [NativeName("Name", "CL_CONTEXT_D3D11_DEVICE_KHR")]
        ContextD3D11DeviceKhr = 0x401D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        D3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9_KHR")]
        AdapterD3D9Khr = 0x2025,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9_KHR")]
        ContextAdapterD3D9Khr = 0x2025,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
        AdapterD3D9EXKhr = 0x2026,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
        ContextAdapterD3D9EXKhr = 0x2026,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_DXVA_KHR")]
        AdapterDxvaKhr = 0x2027,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_DXVA_KHR")]
        ContextAdapterDxvaKhr = 0x2027,
        [NativeName("Name", "CL_CONTEXT_VA_API_DISPLAY_INTEL")]
        VAApiDisplayIntel = 0x4097,
        [NativeName("Name", "CL_CONTEXT_VA_API_DISPLAY_INTEL")]
        ContextVAApiDisplayIntel = 0x4097,
        [NativeName("Name", "CL_CONTEXT_D3D9_DEVICE_INTEL")]
        D3D9DeviceIntel = 0x4026,
        [NativeName("Name", "CL_CONTEXT_D3D9_DEVICE_INTEL")]
        ContextD3D9DeviceIntel = 0x4026,
        [NativeName("Name", "CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
        D3D9EXDeviceIntel = 0x4072,
        [NativeName("Name", "CL_CONTEXT_D3D9EX_DEVICE_INTEL")]
        ContextD3D9EXDeviceIntel = 0x4072,
        [NativeName("Name", "CL_CONTEXT_DXVA_DEVICE_INTEL")]
        DxvaDeviceIntel = 0x4073,
        [NativeName("Name", "CL_CONTEXT_DXVA_DEVICE_INTEL")]
        ContextDxvaDeviceIntel = 0x4073,
        [NativeName("Name", "CL_CONTEXT_PLATFORM")]
        Platform = 0x1084,
        [NativeName("Name", "CL_CONTEXT_PLATFORM")]
        ContextPlatform = 0x1084,
        [NativeName("Name", "CL_CONTEXT_INTEROP_USER_SYNC")]
        InteropUserSync = 0x1085,
        [NativeName("Name", "CL_CONTEXT_INTEROP_USER_SYNC")]
        ContextInteropUserSync = 0x1085,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
        MemoryInitializeKhr = 0x2030,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
        ContextMemoryInitializeKhr = 0x2030,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        TerminateKhr = 0x2032,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        ContextTerminateKhr = 0x2032,
        [NativeName("Name", "CL_PRINTF_CALLBACK_ARM")]
        PrintfCallbackArm = 0x40B0,
        [NativeName("Name", "CL_PRINTF_BUFFERSIZE_ARM")]
        PrintfBuffersizeArm = 0x40B1,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
        ContextShowDiagnosticsIntel = 0x4106,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NUMA")]
        Numa = 0x1,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NUMA")]
        DeviceAffinityDomainNuma = 0x1,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE")]
        L4Cache = 0x2,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE")]
        DeviceAffinityDomainL4Cache = 0x2,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE")]
        L3Cache = 0x4,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE")]
        DeviceAffinityDomainL3Cache = 0x4,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE")]
        L2Cache = 0x8,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE")]
        DeviceAffinityDomainL2Cache = 0x8,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE")]
        L1Cache = 0x10,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE")]
        DeviceAffinityDomainL1Cache = 0x10,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE")]
        NextPartitionable = 0x20,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE")]
        DeviceAffinityDomainNextPartitionable = 0x20,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_RELAXED")]
        OrderRelaxed = 0x1,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_RELAXED")]
        DeviceAtomicOrderRelaxed = 0x1,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
        OrderAcqRel = 0x2,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
        DeviceAtomicOrderAcqRel = 0x2,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
        OrderSeqCst = 0x4,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
        DeviceAtomicOrderSeqCst = 0x4,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
        ScopeWorkItem = 0x8,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
        DeviceAtomicScopeWorkItem = 0x8,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
        ScopeWorkGroup = 0x10,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
        DeviceAtomicScopeWorkGroup = 0x10,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
        ScopeDevice = 0x20,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
        DeviceAtomicScopeDevice = 0x20,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
        ScopeAllDevices = 0x40,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
        DeviceAtomicScopeAllDevices = 0x40,
        [NativeName("Name", "CL_DEVICE_QUEUE_SUPPORTED")]
        Supported = 0x1,
        [NativeName("Name", "CL_DEVICE_QUEUE_SUPPORTED")]
        DeviceQueueSupported = 0x1,
        [NativeName("Name", "CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT")]
        ReplaceableDefault = 0x2,
        [NativeName("Name", "CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT")]
        DeviceQueueReplaceableDefault = 0x2,
        [NativeName("Name", "CL_EXEC_KERNEL")]
        Kernel = 0x1,
        [NativeName("Name", "CL_EXEC_KERNEL")]
        ExecKernel = 0x1,
        [NativeName("Name", "CL_EXEC_NATIVE_KERNEL")]
        ExecNativeKernel = 0x2,
        [NativeName("Name", "CL_FP_DENORM")]
        Denorm = 0x1,
        [NativeName("Name", "CL_FP_DENORM")]
        FPDenorm = 0x1,
        [NativeName("Name", "CL_FP_INF_NAN")]
        InfNan = 0x2,
        [NativeName("Name", "CL_FP_INF_NAN")]
        FPInfNan = 0x2,
        [NativeName("Name", "CL_FP_ROUND_TO_NEAREST")]
        RoundToNearest = 0x4,
        [NativeName("Name", "CL_FP_ROUND_TO_NEAREST")]
        FPRoundToNearest = 0x4,
        [NativeName("Name", "CL_FP_ROUND_TO_ZERO")]
        RoundToZero = 0x8,
        [NativeName("Name", "CL_FP_ROUND_TO_ZERO")]
        FPRoundToZero = 0x8,
        [NativeName("Name", "CL_FP_ROUND_TO_INF")]
        RoundToInf = 0x10,
        [NativeName("Name", "CL_FP_ROUND_TO_INF")]
        FPRoundToInf = 0x10,
        [NativeName("Name", "CL_FP_FMA")]
        Fma = 0x20,
        [NativeName("Name", "CL_FP_FMA")]
        FPFma = 0x20,
        [NativeName("Name", "CL_FP_SOFT_FLOAT")]
        SoftFloat = 0x40,
        [NativeName("Name", "CL_FP_SOFT_FLOAT")]
        FPSoftFloat = 0x40,
        [NativeName("Name", "CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
        CorrectlyRoundedDivideSqrt = 0x80,
        [NativeName("Name", "CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
        FPCorrectlyRoundedDivideSqrt = 0x80,
        [NativeName("Name", "CL_DEVICE_TYPE")]
        Type = 0x1000,
        [NativeName("Name", "CL_DEVICE_TYPE")]
        DeviceType = 0x1000,
        [NativeName("Name", "CL_DEVICE_VENDOR_ID")]
        VendorID = 0x1001,
        [NativeName("Name", "CL_DEVICE_VENDOR_ID")]
        DeviceVendorID = 0x1001,
        [NativeName("Name", "CL_DEVICE_MAX_COMPUTE_UNITS")]
        MaxComputeUnits = 0x1002,
        [NativeName("Name", "CL_DEVICE_MAX_COMPUTE_UNITS")]
        DeviceMaxComputeUnits = 0x1002,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
        MaxWorkItemDimensions = 0x1003,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
        DeviceMaxWorkItemDimensions = 0x1003,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE")]
        MaxWorkGroupSize = 0x1004,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE")]
        DeviceMaxWorkGroupSize = 0x1004,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_SIZES")]
        MaxWorkItemSizes = 0x1005,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_SIZES")]
        DeviceMaxWorkItemSizes = 0x1005,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
        PreferredVectorWidthChar = 0x1006,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
        DevicePreferredVectorWidthChar = 0x1006,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
        PreferredVectorWidthShort = 0x1007,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
        DevicePreferredVectorWidthShort = 0x1007,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
        PreferredVectorWidthInt = 0x1008,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
        DevicePreferredVectorWidthInt = 0x1008,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
        PreferredVectorWidthLong = 0x1009,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
        DevicePreferredVectorWidthLong = 0x1009,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
        PreferredVectorWidthFloat = 0x100A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
        DevicePreferredVectorWidthFloat = 0x100A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
        PreferredVectorWidthDouble = 0x100B,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
        DevicePreferredVectorWidthDouble = 0x100B,
        [NativeName("Name", "CL_DEVICE_MAX_CLOCK_FREQUENCY")]
        MaxClockFrequency = 0x100C,
        [NativeName("Name", "CL_DEVICE_MAX_CLOCK_FREQUENCY")]
        DeviceMaxClockFrequency = 0x100C,
        [NativeName("Name", "CL_DEVICE_ADDRESS_BITS")]
        AddressBits = 0x100D,
        [NativeName("Name", "CL_DEVICE_ADDRESS_BITS")]
        DeviceAddressBits = 0x100D,
        [NativeName("Name", "CL_DEVICE_MAX_READ_IMAGE_ARGS")]
        MaxReadImageArgs = 0x100E,
        [NativeName("Name", "CL_DEVICE_MAX_READ_IMAGE_ARGS")]
        DeviceMaxReadImageArgs = 0x100E,
        [NativeName("Name", "CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
        MaxWriteImageArgs = 0x100F,
        [NativeName("Name", "CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
        DeviceMaxWriteImageArgs = 0x100F,
        [NativeName("Name", "CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
        MaxMemAllocSize = 0x1010,
        [NativeName("Name", "CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
        DeviceMaxMemAllocSize = 0x1010,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_WIDTH")]
        Image2DMaxWidth = 0x1011,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_WIDTH")]
        DeviceImage2DMaxWidth = 0x1011,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
        Image2DMaxHeight = 0x1012,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
        DeviceImage2DMaxHeight = 0x1012,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_WIDTH")]
        Image3DMaxWidth = 0x1013,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_WIDTH")]
        DeviceImage3DMaxWidth = 0x1013,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
        Image3DMaxHeight = 0x1014,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
        DeviceImage3DMaxHeight = 0x1014,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_DEPTH")]
        Image3DMaxDepth = 0x1015,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_DEPTH")]
        DeviceImage3DMaxDepth = 0x1015,
        [NativeName("Name", "CL_DEVICE_IMAGE_SUPPORT")]
        ImageSupport = 0x1016,
        [NativeName("Name", "CL_DEVICE_IMAGE_SUPPORT")]
        DeviceImageSupport = 0x1016,
        [NativeName("Name", "CL_DEVICE_MAX_PARAMETER_SIZE")]
        MaxParameterSize = 0x1017,
        [NativeName("Name", "CL_DEVICE_MAX_PARAMETER_SIZE")]
        DeviceMaxParameterSize = 0x1017,
        [NativeName("Name", "CL_DEVICE_MAX_SAMPLERS")]
        MaxSamplers = 0x1018,
        [NativeName("Name", "CL_DEVICE_MAX_SAMPLERS")]
        DeviceMaxSamplers = 0x1018,
        [NativeName("Name", "CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
        MemBaseAddrAlign = 0x1019,
        [NativeName("Name", "CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
        DeviceMemBaseAddrAlign = 0x1019,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_CONFIG")]
        SingleFPConfig = 0x101B,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_CONFIG")]
        DeviceSingleFPConfig = 0x101B,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
        GlobalMemCacheType = 0x101C,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
        DeviceGlobalMemCacheType = 0x101C,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
        GlobalMemCachelineSize = 0x101D,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
        DeviceGlobalMemCachelineSize = 0x101D,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
        GlobalMemCacheSize = 0x101E,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
        DeviceGlobalMemCacheSize = 0x101E,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_SIZE")]
        GlobalMemSize = 0x101F,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_SIZE")]
        DeviceGlobalMemSize = 0x101F,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
        MaxConstantBufferSize = 0x1020,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
        DeviceMaxConstantBufferSize = 0x1020,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_ARGS")]
        MaxConstantArgs = 0x1021,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_ARGS")]
        DeviceMaxConstantArgs = 0x1021,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_TYPE")]
        LocalMemType = 0x1022,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_TYPE")]
        DeviceLocalMemType = 0x1022,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE")]
        LocalMemSize = 0x1023,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE")]
        DeviceLocalMemSize = 0x1023,
        [NativeName("Name", "CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
        ErrorCorrectionSupport = 0x1024,
        [NativeName("Name", "CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
        DeviceErrorCorrectionSupport = 0x1024,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
        ProfilingTimerResolution = 0x1025,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
        DeviceProfilingTimerResolution = 0x1025,
        [NativeName("Name", "CL_DEVICE_ENDIAN_LITTLE")]
        EndianLittle = 0x1026,
        [NativeName("Name", "CL_DEVICE_ENDIAN_LITTLE")]
        DeviceEndianLittle = 0x1026,
        [NativeName("Name", "CL_DEVICE_AVAILABLE")]
        Available = 0x1027,
        [NativeName("Name", "CL_DEVICE_AVAILABLE")]
        DeviceAvailable = 0x1027,
        [NativeName("Name", "CL_DEVICE_COMPILER_AVAILABLE")]
        CompilerAvailable = 0x1028,
        [NativeName("Name", "CL_DEVICE_COMPILER_AVAILABLE")]
        DeviceCompilerAvailable = 0x1028,
        [NativeName("Name", "CL_DEVICE_EXECUTION_CAPABILITIES")]
        ExecutionCapabilities = 0x1029,
        [NativeName("Name", "CL_DEVICE_EXECUTION_CAPABILITIES")]
        DeviceExecutionCapabilities = 0x1029,
        [NativeName("Name", "CL_DEVICE_NAME")]
        Name = 0x102B,
        [NativeName("Name", "CL_DEVICE_NAME")]
        DeviceName = 0x102B,
        [NativeName("Name", "CL_DEVICE_VENDOR")]
        Vendor = 0x102C,
        [NativeName("Name", "CL_DEVICE_VENDOR")]
        DeviceVendor = 0x102C,
        [NativeName("Name", "CL_DRIVER_VERSION")]
        DriverVersion = 0x102D,
        [NativeName("Name", "CL_DEVICE_PROFILE")]
        Profile = 0x102E,
        [NativeName("Name", "CL_DEVICE_PROFILE")]
        DeviceProfile = 0x102E,
        [NativeName("Name", "CL_DEVICE_VERSION")]
        Version = 0x102F,
        [NativeName("Name", "CL_DEVICE_VERSION")]
        DeviceVersion = 0x102F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS")]
        Extensions = 0x1030,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS")]
        DeviceExtensions = 0x1030,
        [NativeName("Name", "CL_DEVICE_PLATFORM")]
        DevicePlatform = 0x1031,
        [System.Obsolete("Deprecated in version 1.2")]
        [NativeName("Name", "CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
        MinDataTypeAlignSize = 0x101A,
        [System.Obsolete("Deprecated in version 1.2")]
        [NativeName("Name", "CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
        DeviceMinDataTypeAlignSize = 0x101A,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_QUEUE_PROPERTIES")]
        DeviceQueueProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
        PreferredVectorWidthHalf = 0x1034,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
        DevicePreferredVectorWidthHalf = 0x1034,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
        NativeVectorWidthChar = 0x1036,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
        DeviceNativeVectorWidthChar = 0x1036,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
        NativeVectorWidthShort = 0x1037,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
        DeviceNativeVectorWidthShort = 0x1037,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
        NativeVectorWidthInt = 0x1038,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
        DeviceNativeVectorWidthInt = 0x1038,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
        NativeVectorWidthLong = 0x1039,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
        DeviceNativeVectorWidthLong = 0x1039,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
        NativeVectorWidthFloat = 0x103A,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
        DeviceNativeVectorWidthFloat = 0x103A,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
        NativeVectorWidthDouble = 0x103B,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
        DeviceNativeVectorWidthDouble = 0x103B,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
        NativeVectorWidthHalf = 0x103C,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
        DeviceNativeVectorWidthHalf = 0x103C,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_HOST_UNIFIED_MEMORY")]
        HostUnifiedMemory = 0x1035,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_HOST_UNIFIED_MEMORY")]
        DeviceHostUnifiedMemory = 0x1035,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_DEVICE_OPENCL_C_VERSION")]
        OpenclCVersion = 0x103D,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_DEVICE_OPENCL_C_VERSION")]
        DeviceOpenclCVersion = 0x103D,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DeviceDoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEVICE_LINKER_AVAILABLE")]
        LinkerAvailable = 0x103E,
        [NativeName("Name", "CL_DEVICE_LINKER_AVAILABLE")]
        DeviceLinkerAvailable = 0x103E,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS")]
        BuiltInKernels = 0x103F,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS")]
        DeviceBuiltInKernels = 0x103F,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
        ImageMaxBufferSize = 0x1040,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
        DeviceImageMaxBufferSize = 0x1040,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
        ImageMaxArraySize = 0x1041,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
        DeviceImageMaxArraySize = 0x1041,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE")]
        ParentDevice = 0x1042,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE")]
        DeviceParentDevice = 0x1042,
        [NativeName("Name", "CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
        PartitionMaxSubDevices = 0x1043,
        [NativeName("Name", "CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
        DevicePartitionMaxSubDevices = 0x1043,
        [NativeName("Name", "CL_DEVICE_PARTITION_PROPERTIES")]
        PartitionProperties = 0x1044,
        [NativeName("Name", "CL_DEVICE_PARTITION_PROPERTIES")]
        DevicePartitionProperties = 0x1044,
        [NativeName("Name", "CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
        PartitionAffinityDomain = 0x1045,
        [NativeName("Name", "CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
        DevicePartitionAffinityDomain = 0x1045,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPE")]
        PartitionType = 0x1046,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPE")]
        DevicePartitionType = 0x1046,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT")]
        DeviceReferenceCount = 0x1047,
        [NativeName("Name", "CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
        PreferredInteropUserSync = 0x1048,
        [NativeName("Name", "CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
        DevicePreferredInteropUserSync = 0x1048,
        [NativeName("Name", "CL_DEVICE_PRINTF_BUFFER_SIZE")]
        PrintfBufferSize = 0x1049,
        [NativeName("Name", "CL_DEVICE_PRINTF_BUFFER_SIZE")]
        DevicePrintfBufferSize = 0x1049,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
        QueueOnHostProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
        DeviceQueueOnHostProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
        ImagePitchAlignment = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
        DeviceImagePitchAlignment = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
        ImageBaseAddressAlignment = 0x104B,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
        DeviceImageBaseAddressAlignment = 0x104B,
        [NativeName("Name", "CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
        MaxReadWriteImageArgs = 0x104C,
        [NativeName("Name", "CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
        DeviceMaxReadWriteImageArgs = 0x104C,
        [NativeName("Name", "CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
        MaxGlobalVariableSize = 0x104D,
        [NativeName("Name", "CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
        DeviceMaxGlobalVariableSize = 0x104D,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
        QueueOnDeviceProperties = 0x104E,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
        DeviceQueueOnDeviceProperties = 0x104E,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
        QueueOnDevicePreferredSize = 0x104F,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
        DeviceQueueOnDevicePreferredSize = 0x104F,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
        QueueOnDeviceMaxSize = 0x1050,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
        DeviceQueueOnDeviceMaxSize = 0x1050,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
        MaxOnDeviceQueues = 0x1051,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
        DeviceMaxOnDeviceQueues = 0x1051,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
        MaxOnDeviceEvents = 0x1052,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
        DeviceMaxOnDeviceEvents = 0x1052,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES")]
        SvmCapabilities = 0x1053,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES")]
        DeviceSvmCapabilities = 0x1053,
        [NativeName("Name", "CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
        GlobalVariablePreferredTotalSize = 0x1054,
        [NativeName("Name", "CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
        DeviceGlobalVariablePreferredTotalSize = 0x1054,
        [NativeName("Name", "CL_DEVICE_MAX_PIPE_ARGS")]
        MaxPipeArgs = 0x1055,
        [NativeName("Name", "CL_DEVICE_MAX_PIPE_ARGS")]
        DeviceMaxPipeArgs = 0x1055,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
        PipeMaxActiveReservations = 0x1056,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
        DevicePipeMaxActiveReservations = 0x1056,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
        PipeMaxPacketSize = 0x1057,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
        DevicePipeMaxPacketSize = 0x1057,
        [NativeName("Name", "CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
        PreferredPlatformAtomicAlignment = 0x1058,
        [NativeName("Name", "CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
        DevicePreferredPlatformAtomicAlignment = 0x1058,
        [NativeName("Name", "CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
        PreferredGlobalAtomicAlignment = 0x1059,
        [NativeName("Name", "CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
        DevicePreferredGlobalAtomicAlignment = 0x1059,
        [NativeName("Name", "CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
        PreferredLocalAtomicAlignment = 0x105A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
        DevicePreferredLocalAtomicAlignment = 0x105A,
        [NativeName("Name", "CL_DEVICE_IL_VERSION")]
        ILVersion = 0x105B,
        [NativeName("Name", "CL_DEVICE_IL_VERSION")]
        DeviceILVersion = 0x105B,
        [NativeName("Name", "CL_DEVICE_MAX_NUM_SUB_GROUPS")]
        MaxNumSubGroups = 0x105C,
        [NativeName("Name", "CL_DEVICE_MAX_NUM_SUB_GROUPS")]
        DeviceMaxNumSubGroups = 0x105C,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
        SubGroupIndependentForwardProgress = 0x105D,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
        DeviceSubGroupIndependentForwardProgress = 0x105D,
        [NativeName("Name", "CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
        AtomicMemoryCapabilities = 0x1063,
        [NativeName("Name", "CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
        DeviceAtomicMemoryCapabilities = 0x1063,
        [NativeName("Name", "CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
        AtomicFenceCapabilities = 0x1064,
        [NativeName("Name", "CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
        DeviceAtomicFenceCapabilities = 0x1064,
        [NativeName("Name", "CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
        NonUniformWorkGroupSupport = 0x1065,
        [NativeName("Name", "CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
        DeviceNonUniformWorkGroupSupport = 0x1065,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
        OpenclCAllVersions = 0x1066,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
        DeviceOpenclCAllVersions = 0x1066,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
        WorkGroupCollectiveFunctionsSupport = 0x1068,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
        DeviceWorkGroupCollectiveFunctionsSupport = 0x1068,
        [NativeName("Name", "CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
        GenericAddressSpaceSupport = 0x1069,
        [NativeName("Name", "CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
        DeviceGenericAddressSpaceSupport = 0x1069,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_FEATURES")]
        OpenclCFeatures = 0x106F,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_FEATURES")]
        DeviceOpenclCFeatures = 0x106F,
        [NativeName("Name", "CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
        DeviceEnqueueCapabilities = 0x1070,
        [NativeName("Name", "CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
        DeviceDeviceEnqueueCapabilities = 0x1070,
        [NativeName("Name", "CL_DEVICE_PIPE_SUPPORT")]
        PipeSupport = 0x1071,
        [NativeName("Name", "CL_DEVICE_PIPE_SUPPORT")]
        DevicePipeSupport = 0x1071,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION")]
        NumericVersion = 0x105E,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION")]
        DeviceNumericVersion = 0x105E,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION")]
        ExtensionsWithVersion = 0x1060,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION")]
        DeviceExtensionsWithVersion = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION")]
        IlsWithVersion = 0x1061,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION")]
        DeviceIlsWithVersion = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
        BuiltInKernelsWithVersion = 0x1062,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
        DeviceBuiltInKernelsWithVersion = 0x1062,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        PreferredWorkGroupSizeMultiple = 0x1067,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        DevicePreferredWorkGroupSizeMultiple = 0x1067,
        [NativeName("Name", "CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
        LatestConformanceVersionPassed = 0x1072,
        [NativeName("Name", "CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
        DeviceLatestConformanceVersionPassed = 0x1072,
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        HalfFPConfig = 0x1033,
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        DeviceHalfFPConfig = 0x1033,
        [NativeName("Name", "CL_DEVICE_IL_VERSION_KHR")]
        ILVersionKhr = 0x105B,
        [NativeName("Name", "CL_DEVICE_IL_VERSION_KHR")]
        DeviceILVersionKhr = 0x105B,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
        ImagePitchAlignmentKhr = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
        DeviceImagePitchAlignmentKhr = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
        ImageBaseAddressAlignmentKhr = 0x104B,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
        DeviceImageBaseAddressAlignmentKhr = 0x104B,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
        TerminateCapabilityKhr = 0x2031,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
        DeviceTerminateCapabilityKhr = 0x2031,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        SpirVersions = 0x40E0,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        DeviceSpirVersions = 0x40E0,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
        ComputeCapabilityMajorNV = 0x4000,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
        DeviceComputeCapabilityMajorNV = 0x4000,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
        ComputeCapabilityMinorNV = 0x4001,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
        DeviceComputeCapabilityMinorNV = 0x4001,
        [NativeName("Name", "CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
        RegistersPerBlockNV = 0x4002,
        [NativeName("Name", "CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
        DeviceRegistersPerBlockNV = 0x4002,
        [NativeName("Name", "CL_DEVICE_WARP_SIZE_NV")]
        WarpSizeNV = 0x4003,
        [NativeName("Name", "CL_DEVICE_WARP_SIZE_NV")]
        DeviceWarpSizeNV = 0x4003,
        [NativeName("Name", "CL_DEVICE_GPU_OVERLAP_NV")]
        GpuOverlapNV = 0x4004,
        [NativeName("Name", "CL_DEVICE_GPU_OVERLAP_NV")]
        DeviceGpuOverlapNV = 0x4004,
        [NativeName("Name", "CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
        KernelExecTimeoutNV = 0x4005,
        [NativeName("Name", "CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
        DeviceKernelExecTimeoutNV = 0x4005,
        [NativeName("Name", "CL_DEVICE_INTEGRATED_MEMORY_NV")]
        IntegratedMemoryNV = 0x4006,
        [NativeName("Name", "CL_DEVICE_INTEGRATED_MEMORY_NV")]
        DeviceIntegratedMemoryNV = 0x4006,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
        ProfilingTimerOffsetAmd = 0x4036,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
        DeviceProfilingTimerOffsetAmd = 0x4036,
        [NativeName("Name", "CL_DEVICE_TOPOLOGY_AMD")]
        TopologyAmd = 0x4037,
        [NativeName("Name", "CL_DEVICE_TOPOLOGY_AMD")]
        DeviceTopologyAmd = 0x4037,
        [NativeName("Name", "CL_DEVICE_BOARD_NAME_AMD")]
        BoardNameAmd = 0x4038,
        [NativeName("Name", "CL_DEVICE_BOARD_NAME_AMD")]
        DeviceBoardNameAmd = 0x4038,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
        GlobalFreeMemoryAmd = 0x4039,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
        DeviceGlobalFreeMemoryAmd = 0x4039,
        [NativeName("Name", "CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
        SimdPerComputeUnitAmd = 0x4040,
        [NativeName("Name", "CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
        DeviceSimdPerComputeUnitAmd = 0x4040,
        [NativeName("Name", "CL_DEVICE_SIMD_WIDTH_AMD")]
        SimdWidthAmd = 0x4041,
        [NativeName("Name", "CL_DEVICE_SIMD_WIDTH_AMD")]
        DeviceSimdWidthAmd = 0x4041,
        [NativeName("Name", "CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
        SimdInstructionWidthAmd = 0x4042,
        [NativeName("Name", "CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
        DeviceSimdInstructionWidthAmd = 0x4042,
        [NativeName("Name", "CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
        WavefrontWidthAmd = 0x4043,
        [NativeName("Name", "CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
        DeviceWavefrontWidthAmd = 0x4043,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
        GlobalMemChannelsAmd = 0x4044,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
        DeviceGlobalMemChannelsAmd = 0x4044,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
        GlobalMemChannelBanksAmd = 0x4045,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
        DeviceGlobalMemChannelBanksAmd = 0x4045,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
        GlobalMemChannelBankWidthAmd = 0x4046,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
        DeviceGlobalMemChannelBankWidthAmd = 0x4046,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
        LocalMemSizePerComputeUnitAmd = 0x4047,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
        DeviceLocalMemSizePerComputeUnitAmd = 0x4047,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
        LocalMemBanksAmd = 0x4048,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
        DeviceLocalMemBanksAmd = 0x4048,
        [NativeName("Name", "CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
        ThreadTraceSupportedAmd = 0x4049,
        [NativeName("Name", "CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
        DeviceThreadTraceSupportedAmd = 0x4049,
        [NativeName("Name", "CL_DEVICE_GFXIP_MAJOR_AMD")]
        GfxipMajorAmd = 0x404A,
        [NativeName("Name", "CL_DEVICE_GFXIP_MAJOR_AMD")]
        DeviceGfxipMajorAmd = 0x404A,
        [NativeName("Name", "CL_DEVICE_GFXIP_MINOR_AMD")]
        GfxipMinorAmd = 0x404B,
        [NativeName("Name", "CL_DEVICE_GFXIP_MINOR_AMD")]
        DeviceGfxipMinorAmd = 0x404B,
        [NativeName("Name", "CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
        AvailableAsyncQueuesAmd = 0x404C,
        [NativeName("Name", "CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
        DeviceAvailableAsyncQueuesAmd = 0x404C,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
        PreferredWorkGroupSizeAmd = 0x4030,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
        DevicePreferredWorkGroupSizeAmd = 0x4030,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
        MaxWorkGroupSizeAmd = 0x4031,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
        DeviceMaxWorkGroupSizeAmd = 0x4031,
        [NativeName("Name", "CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
        PreferredConstantBufferSizeAmd = 0x4033,
        [NativeName("Name", "CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
        DevicePreferredConstantBufferSizeAmd = 0x4033,
        [NativeName("Name", "CL_DEVICE_PCIE_ID_AMD")]
        PcieIDAmd = 0x4034,
        [NativeName("Name", "CL_DEVICE_PCIE_ID_AMD")]
        DevicePcieIDAmd = 0x4034,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE_EXT")]
        ParentDeviceExt = 0x4054,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE_EXT")]
        DeviceParentDeviceExt = 0x4054,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPES_EXT")]
        PartitionTypesExt = 0x4055,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPES_EXT")]
        DevicePartitionTypesExt = 0x4055,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAINS_EXT")]
        AffinityDomainsExt = 0x4056,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAINS_EXT")]
        DeviceAffinityDomainsExt = 0x4056,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT_EXT")]
        ReferenceCountExt = 0x4057,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT_EXT")]
        DeviceReferenceCountExt = 0x4057,
        [NativeName("Name", "CL_DEVICE_PARTITION_STYLE_EXT")]
        PartitionStyleExt = 0x4058,
        [NativeName("Name", "CL_DEVICE_PARTITION_STYLE_EXT")]
        DevicePartitionStyleExt = 0x4058,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        ExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        DeviceExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        PageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        DevicePageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        MaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        DeviceMaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES_ARM")]
        SvmCapabilitiesArm = 0x40B6,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES_ARM")]
        DeviceSvmCapabilitiesArm = 0x40B6,
        [NativeName("Name", "CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
        ComputeUnitsBitfieldArm = 0x40BF,
        [NativeName("Name", "CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
        DeviceComputeUnitsBitfieldArm = 0x40BF,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        MEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        DeviceMEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        SimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceSimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        NumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceNumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        SubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        DeviceSubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        PlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        DevicePlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        PlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        DevicePlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        AvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        DeviceAvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        AvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        DeviceAvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        AvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        DeviceAvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        HostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        DeviceHostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceDeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        SingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceSingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        CrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceCrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        SharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        DeviceSharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_UUID_KHR")]
        UuidKhr = 0x106A,
        [NativeName("Name", "CL_DEVICE_UUID_KHR")]
        DeviceUuidKhr = 0x106A,
        [NativeName("Name", "CL_DRIVER_UUID_KHR")]
        DriverUuidKhr = 0x106B,
        [NativeName("Name", "CL_DEVICE_LUID_VALID_KHR")]
        LuidValidKhr = 0x106C,
        [NativeName("Name", "CL_DEVICE_LUID_VALID_KHR")]
        DeviceLuidValidKhr = 0x106C,
        [NativeName("Name", "CL_DEVICE_LUID_KHR")]
        LuidKhr = 0x106D,
        [NativeName("Name", "CL_DEVICE_LUID_KHR")]
        DeviceLuidKhr = 0x106D,
        [NativeName("Name", "CL_DEVICE_NODE_MASK_KHR")]
        NodeMaskKhr = 0x106E,
        [NativeName("Name", "CL_DEVICE_NODE_MASK_KHR")]
        DeviceNodeMaskKhr = 0x106E,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        SchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        DeviceSchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
        SupportedRegisterAllocationsArm = 0x41EB,
        [NativeName("Name", "CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
        DeviceSupportedRegisterAllocationsArm = 0x41EB,
        [NativeName("Name", "CL_DEVICE_MAX_WARP_COUNT_ARM")]
        MaxWarpCountArm = 0x41EA,
        [NativeName("Name", "CL_DEVICE_MAX_WARP_COUNT_ARM")]
        DeviceMaxWarpCountArm = 0x41EA,
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        CxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        DeviceCxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION_KHR")]
        NumericVersionKhr = 0x105E,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION_KHR")]
        DeviceNumericVersionKhr = 0x105E,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
        OpenclCNumericVersionKhr = 0x105F,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
        DeviceOpenclCNumericVersionKhr = 0x105F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
        ExtensionsWithVersionKhr = 0x1060,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
        DeviceExtensionsWithVersionKhr = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION_KHR")]
        IlsWithVersionKhr = 0x1061,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION_KHR")]
        DeviceIlsWithVersionKhr = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
        BuiltInKernelsWithVersionKhr = 0x1062,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
        DeviceBuiltInKernelsWithVersionKhr = 0x1062,
        [NativeName("Name", "CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
        MemoryCapabilitiesImg = 0x40D8,
        [NativeName("Name", "CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
        DeviceMemoryCapabilitiesImg = 0x40D8,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
        ControlledTerminationCapabilitiesArm = 0x41EE,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
        DeviceControlledTerminationCapabilitiesArm = 0x41EE,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        QueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        DeviceQueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        PciBusInfoKhr = 0x410F,
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        DevicePciBusInfoKhr = 0x410F,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        IPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        DeviceIPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        IDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        DeviceIDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        NumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        DeviceNumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        NumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        DeviceNumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        NumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        DeviceNumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        NumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        DeviceNumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        FeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        DeviceFeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
        IntegerDotProductCapabilitiesKhr = 0x1073,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
        DeviceIntegerDotProductCapabilitiesKhr = 0x1073,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
        IntegerDotProductAccelerationProperties8BitKhr = 0x1074,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
        DeviceIntegerDotProductAccelerationProperties8BitKhr = 0x1074,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
        IntegerDotProductAccelerationProperties4x8BitPackedKhr = 0x1075,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
        DeviceIntegerDotProductAccelerationProperties4x8BitPackedKhr = 0x1075,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_TYPES_KHR")]
        SemaphoreTypesKhr = 0x204C,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_TYPES_KHR")]
        DeviceSemaphoreTypesKhr = 0x204C,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        SemaphoreImportHandleTypesKhr = 0x204D,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        DeviceSemaphoreImportHandleTypesKhr = 0x204D,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        SemaphoreExportHandleTypesKhr = 0x204E,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        DeviceSemaphoreExportHandleTypesKhr = 0x204E,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        ExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        DeviceExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR")]
        ExternalMemoryImportAssumeLinearImagesHandleTypesKhr = 0x2052,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR")]
        DeviceExternalMemoryImportAssumeLinearImagesHandleTypesKhr = 0x2052,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        CommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        DeviceCommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        CommandBufferRequiredQueuePropertiesKhr = 0x12AA,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        DeviceCommandBufferRequiredQueuePropertiesKhr = 0x12AA,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
        SingleFPAtomicCapabilitiesExt = 0x4231,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceSingleFPAtomicCapabilitiesExt = 0x4231,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DoubleFPAtomicCapabilitiesExt = 0x4232,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceDoubleFPAtomicCapabilitiesExt = 0x4232,
        [NativeName("Name", "CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
        HalfFPAtomicCapabilitiesExt = 0x4233,
        [NativeName("Name", "CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceHalfFPAtomicCapabilitiesExt = 0x4233,
        [NativeName("Name", "CL_DEVICE_JOB_SLOTS_ARM")]
        JobSlotsArm = 0x41E0,
        [NativeName("Name", "CL_DEVICE_JOB_SLOTS_ARM")]
        DeviceJobSlotsArm = 0x41E0,
        [NativeName("Name", "CL_DEVICE_MUTABLE_DISPATCH_CAPABILITIES_KHR")]
        MutableDispatchCapabilitiesKhr = 0x12B0,
        [NativeName("Name", "CL_DEVICE_MUTABLE_DISPATCH_CAPABILITIES_KHR")]
        DeviceMutableDispatchCapabilitiesKhr = 0x12B0,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_NUM_SYNC_DEVICES_KHR")]
        CommandBufferNumSyncDevicesKhr = 0x12AB,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_NUM_SYNC_DEVICES_KHR")]
        DeviceCommandBufferNumSyncDevicesKhr = 0x12AB,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_SYNC_DEVICES_KHR")]
        CommandBufferSyncDevicesKhr = 0x12AC,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_SYNC_DEVICES_KHR")]
        DeviceCommandBufferSyncDevicesKhr = 0x12AC,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_CAPABILITIES_KHR")]
        KernelClockCapabilitiesKhr = 0x1076,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_CAPABILITIES_KHR")]
        DeviceKernelClockCapabilitiesKhr = 0x1076,
        [NativeName("Name", "CL_LOCAL")]
        Local = 0x1,
        [NativeName("Name", "CL_GLOBAL")]
        Global = 0x2,
        [NativeName("Name", "CL_READ_ONLY_CACHE")]
        ReadOnlyCache = 0x1,
        [NativeName("Name", "CL_READ_WRITE_CACHE")]
        ReadWriteCache = 0x2,
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY")]
        Equally = 0x1086,
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY")]
        DevicePartitionEqually = 0x1086,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS")]
        ByCounts = 0x1087,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS")]
        DevicePartitionByCounts = 0x1087,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN")]
        ByAffinityDomain = 0x1088,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN")]
        DevicePartitionByAffinityDomain = 0x1088,
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER")]
        CoarseGrainBuffer = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER")]
        DeviceSvmCoarseGrainBuffer = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER")]
        FineGrainBuffer = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER")]
        DeviceSvmFineGrainBuffer = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM")]
        FineGrainSystem = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM")]
        DeviceSvmFineGrainSystem = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS")]
        Atomics = 0x8,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS")]
        DeviceSvmAtomics = 0x8,
        [NativeName("Name", "CL_DEVICE_TYPE_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "CL_DEVICE_TYPE_DEFAULT")]
        DeviceTypeDefault = 0x1,
        [NativeName("Name", "CL_DEVICE_TYPE_CPU")]
        Cpu = 0x2,
        [NativeName("Name", "CL_DEVICE_TYPE_CPU")]
        DeviceTypeCpu = 0x2,
        [NativeName("Name", "CL_DEVICE_TYPE_GPU")]
        Gpu = 0x4,
        [NativeName("Name", "CL_DEVICE_TYPE_GPU")]
        DeviceTypeGpu = 0x4,
        [NativeName("Name", "CL_DEVICE_TYPE_ACCELERATOR")]
        Accelerator = 0x8,
        [NativeName("Name", "CL_DEVICE_TYPE_ACCELERATOR")]
        DeviceTypeAccelerator = 0x8,
        [NativeName("Name", "CL_DEVICE_TYPE_ALL")]
        All = unchecked((int) 0xFFFFFFFF),
        [NativeName("Name", "CL_DEVICE_TYPE_ALL")]
        DeviceTypeAll = unchecked((int) 0xFFFFFFFF),
        [NativeName("Name", "CL_DEVICE_TYPE_CUSTOM")]
        Custom = 0x10,
        [NativeName("Name", "CL_DEVICE_TYPE_CUSTOM")]
        DeviceTypeCustom = 0x10,
        [NativeName("Name", "CL_DEVICE_NOT_FOUND")]
        DeviceNotFound = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "CL_DEVICE_NOT_AVAILABLE")]
        DeviceNotAvailable = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_COMPILER_NOT_AVAILABLE")]
        CompilerNotAvailable = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "CL_MEM_OBJECT_ALLOCATION_FAILURE")]
        MemObjectAllocationFailure = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "CL_OUT_OF_RESOURCES")]
        OutOfResources = unchecked((int) 0xFFFFFFFFFFFFFFFB),
        [NativeName("Name", "CL_OUT_OF_HOST_MEMORY")]
        OutOfHostMemory = unchecked((int) 0xFFFFFFFFFFFFFFFA),
        [NativeName("Name", "CL_PROFILING_INFO_NOT_AVAILABLE")]
        ProfilingInfoNotAvailable = unchecked((int) 0xFFFFFFFFFFFFFFF9),
        [NativeName("Name", "CL_MEM_COPY_OVERLAP")]
        MemCopyOverlap = unchecked((int) 0xFFFFFFFFFFFFFFF8),
        [NativeName("Name", "CL_IMAGE_FORMAT_MISMATCH")]
        ImageFormatMismatch = unchecked((int) 0xFFFFFFFFFFFFFFF7),
        [NativeName("Name", "CL_IMAGE_FORMAT_NOT_SUPPORTED")]
        ImageFormatNotSupported = unchecked((int) 0xFFFFFFFFFFFFFFF6),
        [NativeName("Name", "CL_BUILD_PROGRAM_FAILURE")]
        BuildProgramFailure = unchecked((int) 0xFFFFFFFFFFFFFFF5),
        [NativeName("Name", "CL_MAP_FAILURE")]
        MapFailure = unchecked((int) 0xFFFFFFFFFFFFFFF4),
        [NativeName("Name", "CL_INVALID_VALUE")]
        InvalidValue = unchecked((int) 0xFFFFFFFFFFFFFFE2),
        [NativeName("Name", "CL_INVALID_DEVICE_TYPE")]
        InvalidDeviceType = unchecked((int) 0xFFFFFFFFFFFFFFE1),
        [NativeName("Name", "CL_INVALID_PLATFORM")]
        InvalidPlatform = unchecked((int) 0xFFFFFFFFFFFFFFE0),
        [NativeName("Name", "CL_INVALID_DEVICE")]
        InvalidDevice = unchecked((int) 0xFFFFFFFFFFFFFFDF),
        [NativeName("Name", "CL_INVALID_CONTEXT")]
        InvalidContext = unchecked((int) 0xFFFFFFFFFFFFFFDE),
        [NativeName("Name", "CL_INVALID_QUEUE_PROPERTIES")]
        InvalidQueueProperties = unchecked((int) 0xFFFFFFFFFFFFFFDD),
        [NativeName("Name", "CL_INVALID_COMMAND_QUEUE")]
        InvalidCommandQueue = unchecked((int) 0xFFFFFFFFFFFFFFDC),
        [NativeName("Name", "CL_INVALID_HOST_PTR")]
        InvalidHostPtr = unchecked((int) 0xFFFFFFFFFFFFFFDB),
        [NativeName("Name", "CL_INVALID_MEM_OBJECT")]
        InvalidMemObject = unchecked((int) 0xFFFFFFFFFFFFFFDA),
        [NativeName("Name", "CL_INVALID_IMAGE_FORMAT_DESCRIPTOR")]
        InvalidImageFormatDescriptor = unchecked((int) 0xFFFFFFFFFFFFFFD9),
        [NativeName("Name", "CL_INVALID_IMAGE_SIZE")]
        InvalidImageSize = unchecked((int) 0xFFFFFFFFFFFFFFD8),
        [NativeName("Name", "CL_INVALID_SAMPLER")]
        InvalidSampler = unchecked((int) 0xFFFFFFFFFFFFFFD7),
        [NativeName("Name", "CL_INVALID_BINARY")]
        InvalidBinary = unchecked((int) 0xFFFFFFFFFFFFFFD6),
        [NativeName("Name", "CL_INVALID_BUILD_OPTIONS")]
        InvalidBuildOptions = unchecked((int) 0xFFFFFFFFFFFFFFD5),
        [NativeName("Name", "CL_INVALID_PROGRAM")]
        InvalidProgram = unchecked((int) 0xFFFFFFFFFFFFFFD4),
        [NativeName("Name", "CL_INVALID_PROGRAM_EXECUTABLE")]
        InvalidProgramExecutable = unchecked((int) 0xFFFFFFFFFFFFFFD3),
        [NativeName("Name", "CL_INVALID_KERNEL_NAME")]
        InvalidKernelName = unchecked((int) 0xFFFFFFFFFFFFFFD2),
        [NativeName("Name", "CL_INVALID_KERNEL_DEFINITION")]
        InvalidKernelDefinition = unchecked((int) 0xFFFFFFFFFFFFFFD1),
        [NativeName("Name", "CL_INVALID_KERNEL")]
        InvalidKernel = unchecked((int) 0xFFFFFFFFFFFFFFD0),
        [NativeName("Name", "CL_INVALID_ARG_INDEX")]
        InvalidArgIndex = unchecked((int) 0xFFFFFFFFFFFFFFCF),
        [NativeName("Name", "CL_INVALID_ARG_VALUE")]
        InvalidArgValue = unchecked((int) 0xFFFFFFFFFFFFFFCE),
        [NativeName("Name", "CL_INVALID_ARG_SIZE")]
        InvalidArgSize = unchecked((int) 0xFFFFFFFFFFFFFFCD),
        [NativeName("Name", "CL_INVALID_KERNEL_ARGS")]
        InvalidKernelArgs = unchecked((int) 0xFFFFFFFFFFFFFFCC),
        [NativeName("Name", "CL_INVALID_WORK_DIMENSION")]
        InvalidWorkDimension = unchecked((int) 0xFFFFFFFFFFFFFFCB),
        [NativeName("Name", "CL_INVALID_WORK_GROUP_SIZE")]
        InvalidWorkGroupSize = unchecked((int) 0xFFFFFFFFFFFFFFCA),
        [NativeName("Name", "CL_INVALID_WORK_ITEM_SIZE")]
        InvalidWorkItemSize = unchecked((int) 0xFFFFFFFFFFFFFFC9),
        [NativeName("Name", "CL_INVALID_GLOBAL_OFFSET")]
        InvalidGlobalOffset = unchecked((int) 0xFFFFFFFFFFFFFFC8),
        [NativeName("Name", "CL_INVALID_EVENT_WAIT_LIST")]
        InvalidEventWaitList = unchecked((int) 0xFFFFFFFFFFFFFFC7),
        [NativeName("Name", "CL_INVALID_EVENT")]
        InvalidEvent = unchecked((int) 0xFFFFFFFFFFFFFFC6),
        [NativeName("Name", "CL_INVALID_OPERATION")]
        InvalidOperation = unchecked((int) 0xFFFFFFFFFFFFFFC5),
        [NativeName("Name", "CL_INVALID_GL_OBJECT")]
        InvalidGLObject = unchecked((int) 0xFFFFFFFFFFFFFFC4),
        [NativeName("Name", "CL_INVALID_BUFFER_SIZE")]
        InvalidBufferSize = unchecked((int) 0xFFFFFFFFFFFFFFC3),
        [NativeName("Name", "CL_INVALID_MIP_LEVEL")]
        InvalidMipLevel = unchecked((int) 0xFFFFFFFFFFFFFFC2),
        [NativeName("Name", "CL_INVALID_GLOBAL_WORK_SIZE")]
        InvalidGlobalWorkSize = unchecked((int) 0xFFFFFFFFFFFFFFC1),
        [NativeName("Name", "CL_MISALIGNED_SUB_BUFFER_OFFSET")]
        MisalignedSubBufferOffset = unchecked((int) 0xFFFFFFFFFFFFFFF3),
        [NativeName("Name", "CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST")]
        ExecStatusErrorForEventsInWaitList = unchecked((int) 0xFFFFFFFFFFFFFFF2),
        [NativeName("Name", "CL_INVALID_PROPERTY")]
        InvalidProperty = unchecked((int) 0xFFFFFFFFFFFFFFC0),
        [NativeName("Name", "CL_COMPILE_PROGRAM_FAILURE")]
        CompileProgramFailure = unchecked((int) 0xFFFFFFFFFFFFFFF1),
        [NativeName("Name", "CL_LINKER_NOT_AVAILABLE")]
        LinkerNotAvailable = unchecked((int) 0xFFFFFFFFFFFFFFF0),
        [NativeName("Name", "CL_LINK_PROGRAM_FAILURE")]
        LinkProgramFailure = unchecked((int) 0xFFFFFFFFFFFFFFEF),
        [NativeName("Name", "CL_DEVICE_PARTITION_FAILED")]
        DevicePartitionFailed = unchecked((int) 0xFFFFFFFFFFFFFFEE),
        [NativeName("Name", "CL_KERNEL_ARG_INFO_NOT_AVAILABLE")]
        KernelArgInfoNotAvailable = unchecked((int) 0xFFFFFFFFFFFFFFED),
        [NativeName("Name", "CL_INVALID_IMAGE_DESCRIPTOR")]
        InvalidImageDescriptor = unchecked((int) 0xFFFFFFFFFFFFFFBF),
        [NativeName("Name", "CL_INVALID_COMPILER_OPTIONS")]
        InvalidCompilerOptions = unchecked((int) 0xFFFFFFFFFFFFFFBE),
        [NativeName("Name", "CL_INVALID_LINKER_OPTIONS")]
        InvalidLinkerOptions = unchecked((int) 0xFFFFFFFFFFFFFFBD),
        [NativeName("Name", "CL_INVALID_DEVICE_PARTITION_COUNT")]
        InvalidDevicePartitionCount = unchecked((int) 0xFFFFFFFFFFFFFFBC),
        [NativeName("Name", "CL_INVALID_PIPE_SIZE")]
        InvalidPipeSize = unchecked((int) 0xFFFFFFFFFFFFFFBB),
        [NativeName("Name", "CL_INVALID_DEVICE_QUEUE")]
        InvalidDeviceQueue = unchecked((int) 0xFFFFFFFFFFFFFFBA),
        [NativeName("Name", "CL_INVALID_SPEC_ID")]
        InvalidSpecID = unchecked((int) 0xFFFFFFFFFFFFFFB9),
        [NativeName("Name", "CL_MAX_SIZE_RESTRICTION_EXCEEDED")]
        MaxSizeRestrictionExceeded = unchecked((int) 0xFFFFFFFFFFFFFFB8),
        [NativeName("Name", "CL_INVALID_D3D10_DEVICE_KHR")]
        InvalidD3D10DeviceKhr = unchecked((int) 0xFFFFFFFFFFFFFC16),
        [NativeName("Name", "CL_INVALID_D3D10_RESOURCE_KHR")]
        InvalidD3D10ResourceKhr = unchecked((int) 0xFFFFFFFFFFFFFC15),
        [NativeName("Name", "CL_D3D10_RESOURCE_ALREADY_ACQUIRED_KHR")]
        D3D10ResourceAlreadyAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC14),
        [NativeName("Name", "CL_D3D10_RESOURCE_NOT_ACQUIRED_KHR")]
        D3D10ResourceNotAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC13),
        [NativeName("Name", "CL_INVALID_D3D11_DEVICE_KHR")]
        InvalidD3D11DeviceKhr = unchecked((int) 0xFFFFFFFFFFFFFC12),
        [NativeName("Name", "CL_INVALID_D3D11_RESOURCE_KHR")]
        InvalidD3D11ResourceKhr = unchecked((int) 0xFFFFFFFFFFFFFC11),
        [NativeName("Name", "CL_D3D11_RESOURCE_ALREADY_ACQUIRED_KHR")]
        D3D11ResourceAlreadyAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC10),
        [NativeName("Name", "CL_D3D11_RESOURCE_NOT_ACQUIRED_KHR")]
        D3D11ResourceNotAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC0F),
        [NativeName("Name", "CL_INVALID_DX9_MEDIA_ADAPTER_KHR")]
        InvalidDX9MediaAdapterKhr = unchecked((int) 0xFFFFFFFFFFFFFC0E),
        [NativeName("Name", "CL_INVALID_DX9_MEDIA_SURFACE_KHR")]
        InvalidDX9MediaSurfaceKhr = unchecked((int) 0xFFFFFFFFFFFFFC0D),
        [NativeName("Name", "CL_DX9_MEDIA_SURFACE_ALREADY_ACQUIRED_KHR")]
        DX9MediaSurfaceAlreadyAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC0C),
        [NativeName("Name", "CL_DX9_MEDIA_SURFACE_NOT_ACQUIRED_KHR")]
        DX9MediaSurfaceNotAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFC0B),
        [NativeName("Name", "CL_INVALID_EGL_OBJECT_KHR")]
        InvalidEglObjectKhr = unchecked((int) 0xFFFFFFFFFFFFFBBB),
        [NativeName("Name", "CL_EGL_RESOURCE_NOT_ACQUIRED_KHR")]
        EglResourceNotAcquiredKhr = unchecked((int) 0xFFFFFFFFFFFFFBBC),
        [NativeName("Name", "CL_PLATFORM_NOT_FOUND_KHR")]
        PlatformNotFoundKhr = unchecked((int) 0xFFFFFFFFFFFFFC17),
        [NativeName("Name", "CL_CONTEXT_TERMINATED_KHR")]
        ContextTerminatedKhr = unchecked((int) 0xFFFFFFFFFFFFFB9F),
        [NativeName("Name", "CL_DEVICE_PARTITION_FAILED_EXT")]
        DevicePartitionFailedExt = unchecked((int) 0xFFFFFFFFFFFFFBDF),
        [NativeName("Name", "CL_INVALID_PARTITION_COUNT_EXT")]
        InvalidPartitionCountExt = unchecked((int) 0xFFFFFFFFFFFFFBDE),
        [NativeName("Name", "CL_INVALID_PARTITION_NAME_EXT")]
        InvalidPartitionNameExt = unchecked((int) 0xFFFFFFFFFFFFFBDD),
        [NativeName("Name", "CL_GRALLOC_RESOURCE_NOT_ACQUIRED_IMG")]
        GrallocResourceNotAcquiredImg = 0x40D4,
        [NativeName("Name", "CL_INVALID_GRALLOC_OBJECT_IMG")]
        InvalidGrallocObjectImg = 0x40D5,
        [NativeName("Name", "CL_INVALID_ACCELERATOR_INTEL")]
        InvalidAcceleratorIntel = unchecked((int) 0xFFFFFFFFFFFFFBBA),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_TYPE_INTEL")]
        InvalidAcceleratorTypeIntel = unchecked((int) 0xFFFFFFFFFFFFFBB9),
        [NativeName("Name", "CL_INVALID_ACCELERATOR_DESCRIPTOR_INTEL")]
        InvalidAcceleratorDescriptorIntel = unchecked((int) 0xFFFFFFFFFFFFFBB8),
        [NativeName("Name", "CL_ACCELERATOR_TYPE_NOT_SUPPORTED_INTEL")]
        AcceleratorTypeNotSupportedIntel = unchecked((int) 0xFFFFFFFFFFFFFBB7),
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_ADAPTER_INTEL")]
        InvalidVAApiMediaAdapterIntel = unchecked((int) 0xFFFFFFFFFFFFFBB6),
        [NativeName("Name", "CL_INVALID_VA_API_MEDIA_SURFACE_INTEL")]
        InvalidVAApiMediaSurfaceIntel = unchecked((int) 0xFFFFFFFFFFFFFBB5),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_ALREADY_ACQUIRED_INTEL")]
        VAApiMediaSurfaceAlreadyAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFBB4),
        [NativeName("Name", "CL_VA_API_MEDIA_SURFACE_NOT_ACQUIRED_INTEL")]
        VAApiMediaSurfaceNotAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFBB3),
        [NativeName("Name", "CL_INVALID_DX9_DEVICE_INTEL")]
        InvalidDX9DeviceIntel = unchecked((int) 0xFFFFFFFFFFFFFC0E),
        [NativeName("Name", "CL_INVALID_DX9_RESOURCE_INTEL")]
        InvalidDX9ResourceIntel = unchecked((int) 0xFFFFFFFFFFFFFC0D),
        [NativeName("Name", "CL_DX9_RESOURCE_ALREADY_ACQUIRED_INTEL")]
        DX9ResourceAlreadyAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFC0C),
        [NativeName("Name", "CL_DX9_RESOURCE_NOT_ACQUIRED_INTEL")]
        DX9ResourceNotAcquiredIntel = unchecked((int) 0xFFFFFFFFFFFFFC0B),
        [NativeName("Name", "CL_INVALID_GL_SHAREGROUP_REFERENCE_KHR")]
        InvalidGLSharegroupReferenceKhr = unchecked((int) 0xFFFFFFFFFFFFFC18),
        [NativeName("Name", "CL_COMMAND_TERMINATED_ITSELF_WITH_FAILURE_ARM")]
        CommandTerminatedItselfWithFailureArm = unchecked((int) 0xFFFFFFFFFFFFFBAC),
        [NativeName("Name", "CL_INVALID_SEMAPHORE_KHR")]
        InvalidSemaphoreKhr = unchecked((int) 0xFFFFFFFFFFFFFB8A),
        [NativeName("Name", "CL_INVALID_COMMAND_BUFFER_KHR")]
        InvalidCommandBufferKhr = unchecked((int) 0xFFFFFFFFFFFFFB8E),
        [NativeName("Name", "CL_INVALID_SYNC_POINT_WAIT_LIST_KHR")]
        InvalidSyncPointWaitListKhr = unchecked((int) 0xFFFFFFFFFFFFFB8D),
        [NativeName("Name", "CL_INCOMPATIBLE_COMMAND_QUEUE_KHR")]
        IncompatibleCommandQueueKhr = unchecked((int) 0xFFFFFFFFFFFFFB8C),
        [NativeName("Name", "CL_INVALID_MUTABLE_COMMAND_KHR")]
        InvalidMutableCommandKhr = unchecked((int) 0xFFFFFFFFFFFFFB8B),
        [NativeName("Name", "CL_CANCELLED_IMG")]
        CancelledImg = unchecked((int) 0xFFFFFFFFFFFFFB9A),
        [NativeName("Name", "CL_EVENT_COMMAND_QUEUE")]
        CommandQueue = 0x11D0,
        [NativeName("Name", "CL_EVENT_COMMAND_QUEUE")]
        EventCommandQueue = 0x11D0,
        [NativeName("Name", "CL_EVENT_COMMAND_TYPE")]
        CommandType = 0x11D1,
        [NativeName("Name", "CL_EVENT_COMMAND_TYPE")]
        EventCommandType = 0x11D1,
        [NativeName("Name", "CL_EVENT_REFERENCE_COUNT")]
        EventReferenceCount = 0x11D2,
        [NativeName("Name", "CL_EVENT_COMMAND_EXECUTION_STATUS")]
        CommandExecutionStatus = 0x11D3,
        [NativeName("Name", "CL_EVENT_COMMAND_EXECUTION_STATUS")]
        EventCommandExecutionStatus = 0x11D3,
        [NativeName("Name", "CL_EVENT_CONTEXT")]
        EventContext = 0x11D4,
        [NativeName("Name", "CL_EVENT_COMMAND_TERMINATION_REASON_ARM")]
        CommandTerminationReasonArm = 0x41ED,
        [NativeName("Name", "CL_EVENT_COMMAND_TERMINATION_REASON_ARM")]
        EventCommandTerminationReasonArm = 0x41ED,
        [NativeName("Name", "CL_FILTER_NEAREST")]
        Nearest = 0x1140,
        [NativeName("Name", "CL_FILTER_NEAREST")]
        FilterNearest = 0x1140,
        [NativeName("Name", "CL_FILTER_LINEAR")]
        Linear = 0x1141,
        [NativeName("Name", "CL_FILTER_LINEAR")]
        FilterLinear = 0x1141,
        [NativeName("Name", "CL_PLATFORM_PROFILE")]
        PlatformProfile = 0x900,
        [NativeName("Name", "CL_PLATFORM_VERSION")]
        PlatformVersion = 0x901,
        [NativeName("Name", "CL_PLATFORM_NAME")]
        PlatformName = 0x902,
        [NativeName("Name", "CL_PLATFORM_VENDOR")]
        PlatformVendor = 0x903,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS")]
        PlatformExtensions = 0x904,
        [NativeName("Name", "CL_DRIVER_VERSION")]
        DeviceDriverVersion = 0x102D,
        [NativeName("Name", "CL_MEM_READ_WRITE")]
        MemReadWrite = 0x1,
        [NativeName("Name", "CL_MEM_WRITE_ONLY")]
        MemWriteOnly = 0x2,
        [NativeName("Name", "CL_MEM_READ_ONLY")]
        MemReadOnly = 0x4,
        [NativeName("Name", "CL_MEM_USE_HOST_PTR")]
        MemUseHostPtr = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_HOST_PTR")]
        MemAllocHostPtr = 0x10,
        [NativeName("Name", "CL_MEM_COPY_HOST_PTR")]
        MemCopyHostPtr = 0x20,
        [NativeName("Name", "CL_PROFILING_COMMAND_QUEUED")]
        ProfilingCommandQueued = 0x1280,
        [NativeName("Name", "CL_PROFILING_COMMAND_SUBMIT")]
        ProfilingCommandSubmit = 0x1281,
        [NativeName("Name", "CL_PROFILING_COMMAND_START")]
        ProfilingCommandStart = 0x1282,
        [NativeName("Name", "CL_PROFILING_COMMAND_END")]
        ProfilingCommandEnd = 0x1283,
        [NativeName("Name", "CL_MEM_OBJECT_BUFFER")]
        MemObjectBuffer = 0x10F0,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D")]
        MemObjectImage2D = 0x10F1,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE3D")]
        MemObjectImage3D = 0x10F2,
        [NativeName("Name", "CL_MEM_TYPE")]
        MemType = 0x1100,
        [NativeName("Name", "CL_MEM_FLAGS")]
        MemFlags = 0x1101,
        [NativeName("Name", "CL_MEM_SIZE")]
        MemSize = 0x1102,
        [NativeName("Name", "CL_MEM_HOST_PTR")]
        MemHostPtr = 0x1103,
        [NativeName("Name", "CL_MEM_MAP_COUNT")]
        MemMapCount = 0x1104,
        [NativeName("Name", "CL_MEM_REFERENCE_COUNT")]
        MemReferenceCount = 0x1105,
        [NativeName("Name", "CL_MEM_CONTEXT")]
        MemContext = 0x1106,
        [NativeName("Name", "CL_IMAGE_FORMAT")]
        ImageFormat = 0x1110,
        [NativeName("Name", "CL_IMAGE_ELEMENT_SIZE")]
        ImageElementSize = 0x1111,
        [NativeName("Name", "CL_IMAGE_ROW_PITCH")]
        ImageRowPitch = 0x1112,
        [NativeName("Name", "CL_IMAGE_SLICE_PITCH")]
        ImageSlicePitch = 0x1113,
        [NativeName("Name", "CL_IMAGE_WIDTH")]
        ImageWidth = 0x1114,
        [NativeName("Name", "CL_IMAGE_HEIGHT")]
        ImageHeight = 0x1115,
        [NativeName("Name", "CL_IMAGE_DEPTH")]
        ImageDepth = 0x1116,
        [NativeName("Name", "CL_SAMPLER_REFERENCE_COUNT")]
        SamplerReferenceCount = 0x1150,
        [NativeName("Name", "CL_SAMPLER_CONTEXT")]
        SamplerContext = 0x1151,
        [NativeName("Name", "CL_SAMPLER_NORMALIZED_COORDS")]
        SamplerNormalizedCoords = 0x1152,
        [NativeName("Name", "CL_SAMPLER_ADDRESSING_MODE")]
        SamplerAddressingMode = 0x1153,
        [NativeName("Name", "CL_SAMPLER_FILTER_MODE")]
        SamplerFilterMode = 0x1154,
        [NativeName("Name", "CL_MAP_READ")]
        MapRead = 0x1,
        [NativeName("Name", "CL_MAP_WRITE")]
        MapWrite = 0x2,
        [NativeName("Name", "CL_PROGRAM_REFERENCE_COUNT")]
        ProgramReferenceCount = 0x1160,
        [NativeName("Name", "CL_PROGRAM_CONTEXT")]
        ProgramContext = 0x1161,
        [NativeName("Name", "CL_PROGRAM_NUM_DEVICES")]
        ProgramNumDevices = 0x1162,
        [NativeName("Name", "CL_PROGRAM_DEVICES")]
        ProgramDevices = 0x1163,
        [NativeName("Name", "CL_PROGRAM_SOURCE")]
        ProgramSource = 0x1164,
        [NativeName("Name", "CL_PROGRAM_BINARY_SIZES")]
        ProgramBinarySizes = 0x1165,
        [NativeName("Name", "CL_PROGRAM_BINARIES")]
        ProgramBinaries = 0x1166,
        [NativeName("Name", "CL_PROGRAM_BUILD_STATUS")]
        ProgramBuildStatus = 0x1181,
        [NativeName("Name", "CL_PROGRAM_BUILD_OPTIONS")]
        ProgramBuildOptions = 0x1182,
        [NativeName("Name", "CL_PROGRAM_BUILD_LOG")]
        ProgramBuildLog = 0x1183,
        [NativeName("Name", "CL_KERNEL_FUNCTION_NAME")]
        KernelFunctionName = 0x1190,
        [NativeName("Name", "CL_KERNEL_NUM_ARGS")]
        KernelNumArgs = 0x1191,
        [NativeName("Name", "CL_KERNEL_REFERENCE_COUNT")]
        KernelReferenceCount = 0x1192,
        [NativeName("Name", "CL_KERNEL_CONTEXT")]
        KernelContext = 0x1193,
        [NativeName("Name", "CL_KERNEL_PROGRAM")]
        KernelProgram = 0x1194,
        [NativeName("Name", "CL_KERNEL_WORK_GROUP_SIZE")]
        KernelWorkGroupSize = 0x11B0,
        [NativeName("Name", "CL_KERNEL_COMPILE_WORK_GROUP_SIZE")]
        KernelCompileWorkGroupSize = 0x11B1,
        [NativeName("Name", "CL_KERNEL_LOCAL_MEM_SIZE")]
        KernelLocalMemSize = 0x11B2,
        [NativeName("Name", "CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        KernelPreferredWorkGroupSizeMultiple = 0x11B3,
        [NativeName("Name", "CL_KERNEL_PRIVATE_MEM_SIZE")]
        KernelPrivateMemSize = 0x11B4,
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_CODEPLAY")]
        KhronosVendorIDCodeplay = 0x10004,
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_POCL")]
        KhronosVendorIDPocl = 0x10006,
        [NativeName("Name", "CL_IMAGE_FORMAT")]
        Format = 0x1110,
        [NativeName("Name", "CL_IMAGE_ELEMENT_SIZE")]
        ElementSize = 0x1111,
        [NativeName("Name", "CL_IMAGE_ROW_PITCH")]
        RowPitch = 0x1112,
        [NativeName("Name", "CL_IMAGE_SLICE_PITCH")]
        SlicePitch = 0x1113,
        [NativeName("Name", "CL_IMAGE_WIDTH")]
        Width = 0x1114,
        [NativeName("Name", "CL_IMAGE_HEIGHT")]
        Height = 0x1115,
        [NativeName("Name", "CL_IMAGE_ARRAY_SIZE")]
        ArraySize = 0x1117,
        [NativeName("Name", "CL_IMAGE_ARRAY_SIZE")]
        ImageArraySize = 0x1117,
        [NativeName("Name", "CL_IMAGE_NUM_MIP_LEVELS")]
        NumMipLevels = 0x1119,
        [NativeName("Name", "CL_IMAGE_NUM_MIP_LEVELS")]
        ImageNumMipLevels = 0x1119,
        [NativeName("Name", "CL_IMAGE_NUM_SAMPLES")]
        NumSamples = 0x111A,
        [NativeName("Name", "CL_IMAGE_NUM_SAMPLES")]
        ImageNumSamples = 0x111A,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_IMAGE_BUFFER")]
        Buffer = 0x1118,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_IMAGE_BUFFER")]
        ImageBuffer = 0x1118,
        [NativeName("Name", "CL_IMAGE_D3D10_SUBRESOURCE_KHR")]
        D3D10SubresourceKhr = 0x4016,
        [NativeName("Name", "CL_IMAGE_D3D10_SUBRESOURCE_KHR")]
        ImageD3D10SubresourceKhr = 0x4016,
        [NativeName("Name", "CL_IMAGE_D3D11_SUBRESOURCE_KHR")]
        D3D11SubresourceKhr = 0x401F,
        [NativeName("Name", "CL_IMAGE_D3D11_SUBRESOURCE_KHR")]
        ImageD3D11SubresourceKhr = 0x401F,
        [NativeName("Name", "CL_IMAGE_DX9_MEDIA_PLANE_KHR")]
        DX9MediaPlaneKhr = 0x202A,
        [NativeName("Name", "CL_IMAGE_DX9_MEDIA_PLANE_KHR")]
        ImageDX9MediaPlaneKhr = 0x202A,
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        VAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        ImageVAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        DX9PlaneIntel = 0x4075,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        ImageDX9PlaneIntel = 0x4075,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_ONLY")]
        ReadOnly = 0x11A0,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_ONLY")]
        KernelArgAccessReadOnly = 0x11A0,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_WRITE_ONLY")]
        WriteOnly = 0x11A1,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_WRITE_ONLY")]
        KernelArgAccessWriteOnly = 0x11A1,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_WRITE")]
        ReadWrite = 0x11A2,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_WRITE")]
        KernelArgAccessReadWrite = 0x11A2,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_NONE")]
        KernelArgAccessNone = 0x11A3,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_GLOBAL")]
        KernelArgAddressGlobal = 0x119B,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_LOCAL")]
        KernelArgAddressLocal = 0x119C,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_CONSTANT")]
        Constant = 0x119D,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_CONSTANT")]
        KernelArgAddressConstant = 0x119D,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_PRIVATE")]
        Private = 0x119E,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_PRIVATE")]
        KernelArgAddressPrivate = 0x119E,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_QUALIFIER")]
        AddressQualifier = 0x1196,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_QUALIFIER")]
        KernelArgAddressQualifier = 0x1196,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_QUALIFIER")]
        AccessQualifier = 0x1197,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_QUALIFIER")]
        KernelArgAccessQualifier = 0x1197,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NAME")]
        TypeName = 0x1198,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NAME")]
        KernelArgTypeName = 0x1198,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_QUALIFIER")]
        TypeQualifier = 0x1199,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_QUALIFIER")]
        KernelArgTypeQualifier = 0x1199,
        [NativeName("Name", "CL_KERNEL_ARG_NAME")]
        KernelArgName = 0x119A,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NONE")]
        KernelArgTypeNone = 0x0,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_CONST")]
        Const = 0x1,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_CONST")]
        KernelArgTypeConst = 0x1,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_RESTRICT")]
        Restrict = 0x2,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_RESTRICT")]
        KernelArgTypeRestrict = 0x2,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_VOLATILE")]
        Volatile = 0x4,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_VOLATILE")]
        KernelArgTypeVolatile = 0x4,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_PIPE")]
        Pipe = 0x8,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_PIPE")]
        KernelArgTypePipe = 0x8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS")]
        SvmPtrs = 0x11B6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS")]
        KernelExecInfoSvmPtrs = 0x11B6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM")]
        SvmFineGrainSystem = 0x11B7,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM")]
        KernelExecInfoSvmFineGrainSystem = 0x11B7,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        IndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        KernelExecInfoIndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        IndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        KernelExecInfoIndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        IndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        KernelExecInfoIndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        UsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        KernelExecInfoUsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
        WorkgroupBatchSizeArm = 0x41E5,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
        KernelExecInfoWorkgroupBatchSizeArm = 0x41E5,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        WorkgroupBatchSizeModifierArm = 0x41E6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        KernelExecInfoWorkgroupBatchSizeModifierArm = 0x41E6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WARP_COUNT_LIMIT_ARM")]
        WarpCountLimitArm = 0x41E8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WARP_COUNT_LIMIT_ARM")]
        KernelExecInfoWarpCountLimitArm = 0x41E8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_COMPUTE_UNIT_MAX_QUEUED_BATCHES_ARM")]
        ComputeUnitMaxQueuedBatchesArm = 0x41F1,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_COMPUTE_UNIT_MAX_QUEUED_BATCHES_ARM")]
        KernelExecInfoComputeUnitMaxQueuedBatchesArm = 0x41F1,
        [NativeName("Name", "CL_KERNEL_FUNCTION_NAME")]
        FunctionName = 0x1190,
        [NativeName("Name", "CL_KERNEL_NUM_ARGS")]
        NumArgs = 0x1191,
        [NativeName("Name", "CL_KERNEL_PROGRAM")]
        Program = 0x1194,
        [NativeName("Name", "CL_KERNEL_ATTRIBUTES")]
        Attributes = 0x1195,
        [NativeName("Name", "CL_KERNEL_ATTRIBUTES")]
        KernelAttributes = 0x1195,
        [NativeName("Name", "CL_KERNEL_MAX_WARP_COUNT_ARM")]
        KernelMaxWarpCountArm = 0x41E9,
        [NativeName("Name", "CL_KERNEL_MAX_NUM_SUB_GROUPS")]
        KernelMaxNumSubGroups = 0x11B9,
        [NativeName("Name", "CL_KERNEL_COMPILE_NUM_SUB_GROUPS")]
        CompileNumSubGroups = 0x11BA,
        [NativeName("Name", "CL_KERNEL_COMPILE_NUM_SUB_GROUPS")]
        KernelCompileNumSubGroups = 0x11BA,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE")]
        MaxSubGroupSizeForNdrange = 0x2033,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE")]
        KernelMaxSubGroupSizeForNdrange = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE")]
        SubGroupCountForNdrange = 0x2034,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE")]
        KernelSubGroupCountForNdrange = 0x2034,
        [NativeName("Name", "CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT")]
        LocalSizeForSubGroupCount = 0x11B8,
        [NativeName("Name", "CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT")]
        KernelLocalSizeForSubGroupCount = 0x11B8,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        MaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        KernelMaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        SubGroupCountForNdrangeKhr = 0x2034,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        KernelSubGroupCountForNdrangeKhr = 0x2034,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        CompileSubGroupSizeIntel = 0x410A,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        KernelCompileSubGroupSizeIntel = 0x410A,
        [NativeName("Name", "CL_KERNEL_WORK_GROUP_SIZE")]
        WorkGroupSize = 0x11B0,
        [NativeName("Name", "CL_KERNEL_COMPILE_WORK_GROUP_SIZE")]
        CompileWorkGroupSize = 0x11B1,
        [NativeName("Name", "CL_KERNEL_PRIVATE_MEM_SIZE")]
        PrivateMemSize = 0x11B4,
        [NativeName("Name", "CL_KERNEL_GLOBAL_WORK_SIZE")]
        GlobalWorkSize = 0x11B5,
        [NativeName("Name", "CL_KERNEL_GLOBAL_WORK_SIZE")]
        KernelGlobalWorkSize = 0x11B5,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        SpillMemSizeIntel = 0x4109,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        KernelSpillMemSizeIntel = 0x4109,
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_CODEPLAY")]
        Codeplay = 0x10004,
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_POCL")]
        Pocl = 0x10006,
        [NativeName("Name", "CL_MAP_READ")]
        Read = 0x1,
        [NativeName("Name", "CL_MAP_WRITE")]
        Write = 0x2,
        [NativeName("Name", "CL_MAP_WRITE_INVALIDATE_REGION")]
        WriteInvalidateRegion = 0x4,
        [NativeName("Name", "CL_MAP_WRITE_INVALIDATE_REGION")]
        MapWriteInvalidateRegion = 0x4,
        [NativeName("Name", "CL_MEM_USE_HOST_PTR")]
        UseHostPtr = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_HOST_PTR")]
        AllocHostPtr = 0x10,
        [NativeName("Name", "CL_MEM_COPY_HOST_PTR")]
        CopyHostPtr = 0x20,
        [NativeName("Name", "CL_MEM_HOST_WRITE_ONLY")]
        HostWriteOnly = 0x80,
        [NativeName("Name", "CL_MEM_HOST_WRITE_ONLY")]
        MemHostWriteOnly = 0x80,
        [NativeName("Name", "CL_MEM_HOST_READ_ONLY")]
        HostReadOnly = 0x100,
        [NativeName("Name", "CL_MEM_HOST_READ_ONLY")]
        MemHostReadOnly = 0x100,
        [NativeName("Name", "CL_MEM_HOST_NO_ACCESS")]
        HostNoAccess = 0x200,
        [NativeName("Name", "CL_MEM_HOST_NO_ACCESS")]
        MemHostNoAccess = 0x200,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER")]
        SvmFineGrainBuffer = 0x400,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER")]
        MemSvmFineGrainBuffer = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS")]
        SvmAtomics = 0x800,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS")]
        MemSvmAtomics = 0x800,
        [NativeName("Name", "CL_MEM_KERNEL_READ_AND_WRITE")]
        KernelReadAndWrite = 0x1000,
        [NativeName("Name", "CL_MEM_KERNEL_READ_AND_WRITE")]
        MemKernelReadAndWrite = 0x1000,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        ExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        MemExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        UseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        MemUseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        UseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        MemUseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        UseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        MemUseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        NoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        MemNoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        AccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        MemAccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        ForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        MemForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_PROTECTED_ALLOC_ARM")]
        ProtectedAllocArm = unchecked((int) 0x1000000000),
        [NativeName("Name", "CL_MEM_PROTECTED_ALLOC_ARM")]
        MemProtectedAllocArm = unchecked((int) 0x1000000000),
        [NativeName("Name", "CL_MEM_FLAGS")]
        Flags = 0x1101,
        [NativeName("Name", "CL_MEM_HOST_PTR")]
        HostPtr = 0x1103,
        [NativeName("Name", "CL_MEM_MAP_COUNT")]
        MapCount = 0x1104,
        [NativeName("Name", "CL_MEM_ASSOCIATED_MEMOBJECT")]
        AssociatedMemobject = 0x1107,
        [NativeName("Name", "CL_MEM_ASSOCIATED_MEMOBJECT")]
        MemAssociatedMemobject = 0x1107,
        [NativeName("Name", "CL_MEM_OFFSET")]
        Offset = 0x1108,
        [NativeName("Name", "CL_MEM_OFFSET")]
        MemOffset = 0x1108,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER")]
        UsesSvmPointer = 0x1109,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER")]
        MemUsesSvmPointer = 0x1109,
        [NativeName("Name", "CL_MEM_PROPERTIES")]
        MemProperties = 0x110A,
        [NativeName("Name", "CL_MEM_D3D10_RESOURCE_KHR")]
        D3D10ResourceKhr = 0x4015,
        [NativeName("Name", "CL_MEM_D3D10_RESOURCE_KHR")]
        MemD3D10ResourceKhr = 0x4015,
        [NativeName("Name", "CL_MEM_D3D11_RESOURCE_KHR")]
        D3D11ResourceKhr = 0x401E,
        [NativeName("Name", "CL_MEM_D3D11_RESOURCE_KHR")]
        MemD3D11ResourceKhr = 0x401E,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR")]
        DX9MediaAdapterTypeKhr = 0x2028,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR")]
        MemDX9MediaAdapterTypeKhr = 0x2028,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR")]
        DX9MediaSurfaceInfoKhr = 0x2029,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR")]
        MemDX9MediaSurfaceInfoKhr = 0x2029,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER_ARM")]
        UsesSvmPointerArm = 0x40B7,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER_ARM")]
        MemUsesSvmPointerArm = 0x40B7,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        VAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        MemVAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        DX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        MemDX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        DX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        MemDX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST")]
        Host = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST")]
        MigrateMemObjectHost = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED")]
        ContentUndefined = 0x2,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED")]
        MigrateMemObjectContentUndefined = 0x2,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D")]
        Image2D = 0x10F1,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE3D")]
        Image3D = 0x10F2,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D_ARRAY")]
        Image2DArray = 0x10F3,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D_ARRAY")]
        MemObjectImage2DArray = 0x10F3,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D")]
        Image1D = 0x10F4,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D")]
        MemObjectImage1D = 0x10F4,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_ARRAY")]
        Image1DArray = 0x10F5,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_ARRAY")]
        MemObjectImage1DArray = 0x10F5,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_BUFFER")]
        Image1DBuffer = 0x10F6,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_BUFFER")]
        MemObjectImage1DBuffer = 0x10F6,
        [NativeName("Name", "CL_MEM_OBJECT_PIPE")]
        MemObjectPipe = 0x10F7,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        AllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        MemAllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_MEM_DEVICE_HANDLE_LIST_KHR")]
        DeviceHandleListKhr = 0x2051,
        [NativeName("Name", "CL_MEM_DEVICE_HANDLE_LIST_KHR")]
        MemDeviceHandleListKhr = 0x2051,
        [NativeName("Name", "CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
        LocallyUncachedResourceIntel = 0x4218,
        [NativeName("Name", "CL_MEM_LOCALLY_UNCACHED_RESOURCE_INTEL")]
        MemLocallyUncachedResourceIntel = 0x4218,
        [NativeName("Name", "CL_MEM_DEVICE_ID_INTEL")]
        MemDeviceIDIntel = 0x4219,
        [NativeName("Name", "CL_PIPE_PACKET_SIZE")]
        PacketSize = 0x1120,
        [NativeName("Name", "CL_PIPE_PACKET_SIZE")]
        PipePacketSize = 0x1120,
        [NativeName("Name", "CL_PIPE_MAX_PACKETS")]
        MaxPackets = 0x1121,
        [NativeName("Name", "CL_PIPE_MAX_PACKETS")]
        PipeMaxPackets = 0x1121,
        [NativeName("Name", "CL_PIPE_PROPERTIES")]
        PipeProperties = 0x1122,
        [NativeName("Name", "CL_PLATFORM_HOST_TIMER_RESOLUTION")]
        HostTimerResolution = 0x905,
        [NativeName("Name", "CL_PLATFORM_HOST_TIMER_RESOLUTION")]
        PlatformHostTimerResolution = 0x905,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION")]
        PlatformNumericVersion = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION")]
        PlatformExtensionsWithVersion = 0x907,
        [NativeName("Name", "CL_PLATFORM_ICD_SUFFIX_KHR")]
        IcdSuffixKhr = 0x920,
        [NativeName("Name", "CL_PLATFORM_ICD_SUFFIX_KHR")]
        PlatformIcdSuffixKhr = 0x920,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION_KHR")]
        PlatformNumericVersionKhr = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION_KHR")]
        PlatformExtensionsWithVersionKhr = 0x907,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_TYPES_KHR")]
        PlatformSemaphoreTypesKhr = 0x2036,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        PlatformSemaphoreImportHandleTypesKhr = 0x2037,
        [NativeName("Name", "CL_PLATFORM_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        PlatformSemaphoreExportHandleTypesKhr = 0x2038,
        [NativeName("Name", "CL_PLATFORM_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        PlatformExternalMemoryImportHandleTypesKhr = 0x2044,
        [NativeName("Name", "CL_PLATFORM_COMMAND_BUFFER_CAPABILITIES_KHR")]
        PlatformCommandBufferCapabilitiesKhr = 0x908,
        [NativeName("Name", "CL_PROFILING_COMMAND_SUBMIT")]
        Submit = 0x1281,
        [NativeName("Name", "CL_PROFILING_COMMAND_START")]
        Start = 0x1282,
        [NativeName("Name", "CL_PROFILING_COMMAND_END")]
        End = 0x1283,
        [NativeName("Name", "CL_PROFILING_COMMAND_COMPLETE")]
        ProfilingCommandComplete = 0x1284,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_NONE")]
        ProgramBinaryTypeNone = 0x0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
        CompiledObject = 0x1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
        ProgramBinaryTypeCompiledObject = 0x1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_LIBRARY")]
        Library = 0x2,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_LIBRARY")]
        ProgramBinaryTypeLibrary = 0x2,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
        Executable = 0x4,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
        ProgramBinaryTypeExecutable = 0x4,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        Intermediate = 0x40E1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        ProgramBinaryTypeIntermediate = 0x40E1,
        [NativeName("Name", "CL_PROGRAM_BUILD_STATUS")]
        BuildStatus = 0x1181,
        [NativeName("Name", "CL_PROGRAM_BUILD_OPTIONS")]
        BuildOptions = 0x1182,
        [NativeName("Name", "CL_PROGRAM_BUILD_LOG")]
        BuildLog = 0x1183,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE")]
        BinaryType = 0x1184,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE")]
        ProgramBinaryType = 0x1184,
        [NativeName("Name", "CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE")]
        BuildGlobalVariableTotalSize = 0x1185,
        [NativeName("Name", "CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE")]
        ProgramBuildGlobalVariableTotalSize = 0x1185,
        [NativeName("Name", "CL_PROGRAM_SOURCE")]
        Source = 0x1164,
        [NativeName("Name", "CL_PROGRAM_BINARY_SIZES")]
        BinarySizes = 0x1165,
        [NativeName("Name", "CL_PROGRAM_BINARIES")]
        Binaries = 0x1166,
        [NativeName("Name", "CL_PROGRAM_NUM_KERNELS")]
        NumKernels = 0x1167,
        [NativeName("Name", "CL_PROGRAM_NUM_KERNELS")]
        ProgramNumKernels = 0x1167,
        [NativeName("Name", "CL_PROGRAM_KERNEL_NAMES")]
        KernelNames = 0x1168,
        [NativeName("Name", "CL_PROGRAM_KERNEL_NAMES")]
        ProgramKernelNames = 0x1168,
        [NativeName("Name", "CL_PROGRAM_IL")]
        IL = 0x1169,
        [NativeName("Name", "CL_PROGRAM_IL")]
        ProgramIL = 0x1169,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
        ScopeGlobalCtorsPresent = 0x116A,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
        ProgramScopeGlobalCtorsPresent = 0x116A,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
        ScopeGlobalDtorsPresent = 0x116B,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
        ProgramScopeGlobalDtorsPresent = 0x116B,
        [NativeName("Name", "CL_PROGRAM_IL_KHR")]
        ILKhr = 0x1169,
        [NativeName("Name", "CL_PROGRAM_IL_KHR")]
        ProgramILKhr = 0x1169,
        [NativeName("Name", "CL_QUEUE_PRIORITY_KHR")]
        PriorityKhr = 0x1096,
        [NativeName("Name", "CL_QUEUE_PRIORITY_KHR")]
        QueuePriorityKhr = 0x1096,
        [NativeName("Name", "CL_QUEUE_THROTTLE_KHR")]
        ThrottleKhr = 0x1097,
        [NativeName("Name", "CL_QUEUE_THROTTLE_KHR")]
        QueueThrottleKhr = 0x1097,
        [NativeName("Name", "CL_QUEUE_KERNEL_BATCHING_ARM")]
        KernelBatchingArm = 0x41E7,
        [NativeName("Name", "CL_QUEUE_KERNEL_BATCHING_ARM")]
        QueueKernelBatchingArm = 0x41E7,
        [NativeName("Name", "CL_QUEUE_DEFERRED_FLUSH_ARM")]
        DeferredFlushArm = 0x41EC,
        [NativeName("Name", "CL_QUEUE_DEFERRED_FLUSH_ARM")]
        QueueDeferredFlushArm = 0x41EC,
        [NativeName("Name", "CL_QUEUE_COMPUTE_UNIT_LIMIT_ARM")]
        ComputeUnitLimitArm = 0x41F3,
        [NativeName("Name", "CL_QUEUE_COMPUTE_UNIT_LIMIT_ARM")]
        QueueComputeUnitLimitArm = 0x41F3,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        FamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_FAMILY_INTEL")]
        QueueFamilyIntel = 0x418C,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        IndexIntel = 0x418D,
        [NativeName("Name", "CL_QUEUE_INDEX_INTEL")]
        QueueIndexIntel = 0x418D,
        [NativeName("Name", "CL_QUEUE_JOB_SLOT_ARM")]
        JobSlotArm = 0x41E1,
        [NativeName("Name", "CL_QUEUE_JOB_SLOT_ARM")]
        QueueJobSlotArm = 0x41E1,
        [NativeName("Name", "CL_SAMPLER_NORMALIZED_COORDS")]
        NormalizedCoords = 0x1152,
        [NativeName("Name", "CL_SAMPLER_ADDRESSING_MODE")]
        AddressingMode = 0x1153,
        [NativeName("Name", "CL_SAMPLER_FILTER_MODE")]
        FilterMode = 0x1154,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE")]
        MipFilterMode = 0x1155,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE")]
        SamplerMipFilterMode = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN")]
        LodMin = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN")]
        SamplerLodMin = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX")]
        LodMax = 0x1157,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX")]
        SamplerLodMax = 0x1157,
        [NativeName("Name", "CL_SAMPLER_PROPERTIES")]
        SamplerProperties = 0x1158,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE_KHR")]
        MipFilterModeKhr = 0x1155,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE_KHR")]
        SamplerMipFilterModeKhr = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN_KHR")]
        LodMinKhr = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN_KHR")]
        SamplerLodMinKhr = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX_KHR")]
        LodMaxKhr = 0x1157,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX_KHR")]
        SamplerLodMaxKhr = 0x1157,
        [NativeName("Name", "CL_GL_OBJECT_BUFFER")]
        GLObjectBuffer = 0x2000,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D")]
        Texture2D = 0x2001,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D")]
        GLObjectTexture2D = 0x2001,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE3D")]
        Texture3D = 0x2002,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE3D")]
        GLObjectTexture3D = 0x2002,
        [NativeName("Name", "CL_GL_OBJECT_RENDERBUFFER")]
        Renderbuffer = 0x2003,
        [NativeName("Name", "CL_GL_OBJECT_RENDERBUFFER")]
        GLObjectRenderbuffer = 0x2003,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D_ARRAY")]
        Texture2DArray = 0x200E,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE2D_ARRAY")]
        GLObjectTexture2DArray = 0x200E,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D")]
        Texture1D = 0x200F,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D")]
        GLObjectTexture1D = 0x200F,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D_ARRAY")]
        Texture1DArray = 0x2010,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE1D_ARRAY")]
        GLObjectTexture1DArray = 0x2010,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE_BUFFER")]
        TextureBuffer = 0x2011,
        [NativeName("Name", "CL_GL_OBJECT_TEXTURE_BUFFER")]
        GLObjectTextureBuffer = 0x2011,
        [NativeName("Name", "CL_GL_NUM_SAMPLES")]
        GLNumSamples = 0x2012,
        [NativeName("Name", "CL_GL_TEXTURE_TARGET")]
        TextureTarget = 0x2004,
        [NativeName("Name", "CL_GL_TEXTURE_TARGET")]
        GLTextureTarget = 0x2004,
        [NativeName("Name", "CL_GL_MIPMAP_LEVEL")]
        MipmapLevel = 0x2005,
        [NativeName("Name", "CL_GL_MIPMAP_LEVEL")]
        GLMipmapLevel = 0x2005,
        [NativeName("Name", "CL_ICDL_OCL_VERSION")]
        OclVersion = 0x1,
        [NativeName("Name", "CL_ICDL_OCL_VERSION")]
        IcdlOclVersion = 0x1,
        [NativeName("Name", "CL_ICDL_VERSION")]
        IcdlVersion = 0x2,
        [NativeName("Name", "CL_ICDL_NAME")]
        IcdlName = 0x3,
        [NativeName("Name", "CL_ICDL_VENDOR")]
        IcdlVendor = 0x4,
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        ApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        LayerApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_NAME")]
        LayerName = 0x4241,
    }
}
