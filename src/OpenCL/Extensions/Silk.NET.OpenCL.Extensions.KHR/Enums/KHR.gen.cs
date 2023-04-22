// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum KHR : int
    {
        [NativeName("Name", "CL_COMMAND_BUFFER_SIMULTANEOUS_USE_KHR")]
        SimultaneousUse = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_SIMULTANEOUS_USE_KHR")]
        CommandBufferSimultaneousUseKhr = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_MUTABLE_KHR")]
        Mutable = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_MUTABLE_KHR")]
        CommandBufferMutableKhr = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_DEVICE_SIDE_SYNC_KHR")]
        DeviceSideSync = 0x4,
        [NativeName("Name", "CL_COMMAND_BUFFER_DEVICE_SIDE_SYNC_KHR")]
        CommandBufferDeviceSideSyncKhr = 0x4,
        [NativeName("Name", "CL_COMMAND_BUFFER_QUEUES_KHR")]
        Queues = 0x1294,
        [NativeName("Name", "CL_COMMAND_BUFFER_QUEUES_KHR")]
        CommandBufferQueuesKhr = 0x1294,
        [NativeName("Name", "CL_COMMAND_BUFFER_NUM_QUEUES_KHR")]
        NumQueues = 0x1295,
        [NativeName("Name", "CL_COMMAND_BUFFER_NUM_QUEUES_KHR")]
        CommandBufferNumQueuesKhr = 0x1295,
        [NativeName("Name", "CL_COMMAND_BUFFER_REFERENCE_COUNT_KHR")]
        ReferenceCount = 0x1296,
        [NativeName("Name", "CL_COMMAND_BUFFER_REFERENCE_COUNT_KHR")]
        CommandBufferReferenceCountKhr = 0x1296,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_KHR")]
        State = 0x1297,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_KHR")]
        CommandBufferStateKhr = 0x1297,
        [NativeName("Name", "CL_COMMAND_BUFFER_PROPERTIES_ARRAY_KHR")]
        PropertiesArray = 0x1298,
        [NativeName("Name", "CL_COMMAND_BUFFER_PROPERTIES_ARRAY_KHR")]
        CommandBufferPropertiesArrayKhr = 0x1298,
        [NativeName("Name", "CL_COMMAND_BUFFER_CONTEXT_KHR")]
        Context = 0x1299,
        [NativeName("Name", "CL_COMMAND_BUFFER_CONTEXT_KHR")]
        CommandBufferContextKhr = 0x1299,
        [NativeName("Name", "CL_COMMAND_BUFFER_FLAGS_KHR")]
        Flags = 0x1293,
        [NativeName("Name", "CL_COMMAND_BUFFER_FLAGS_KHR")]
        CommandBufferFlagsKhr = 0x1293,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_RECORDING_KHR")]
        Recording = 0x0,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_RECORDING_KHR")]
        CommandBufferStateRecordingKhr = 0x0,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_EXECUTABLE_KHR")]
        Executable = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_EXECUTABLE_KHR")]
        CommandBufferStateExecutableKhr = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_PENDING_KHR")]
        Pending = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_PENDING_KHR")]
        CommandBufferStatePendingKhr = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_INVALID_KHR")]
        Invalid = 0x3,
        [NativeName("Name", "CL_COMMAND_BUFFER_STATE_INVALID_KHR")]
        CommandBufferStateInvalidKhr = 0x3,
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_BASE_CONFIG_KHR")]
        BaseConfig = 0x0,
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_BASE_CONFIG_KHR")]
        StructureTypeMutableBaseConfigKhr = 0x0,
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_DISPATCH_CONFIG_KHR")]
        DispatchConfig = 0x1,
        [NativeName("Name", "CL_STRUCTURE_TYPE_MUTABLE_DISPATCH_CONFIG_KHR")]
        StructureTypeMutableDispatchConfigKhr = 0x1,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D10_KHR")]
        PreferredDevicesForD3D10 = 0x4012,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D10_KHR")]
        PreferredDevicesForD3D10Khr = 0x4012,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D10_KHR")]
        AllDevicesForD3D10 = 0x4013,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D10_KHR")]
        AllDevicesForD3D10Khr = 0x4013,
        [NativeName("Name", "CL_D3D10_DEVICE_KHR")]
        Device = 0x4010,
        [NativeName("Name", "CL_D3D10_DEVICE_KHR")]
        D3D10DeviceKhr = 0x4010,
        [NativeName("Name", "CL_D3D10_DXGI_ADAPTER_KHR")]
        DxgiAdapter = 0x4011,
        [NativeName("Name", "CL_D3D10_DXGI_ADAPTER_KHR")]
        D3D10DxgiAdapterKhr = 0x4011,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D11_KHR")]
        PreferredDevicesForD3D11 = 0x401B,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_D3D11_KHR")]
        PreferredDevicesForD3D11Khr = 0x401B,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D11_KHR")]
        AllDevicesForD3D11 = 0x401C,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_D3D11_KHR")]
        AllDevicesForD3D11Khr = 0x401C,
        [NativeName("Name", "CL_D3D11_DEVICE_KHR")]
        D3D11DeviceKhr = 0x4019,
        [NativeName("Name", "CL_D3D11_DXGI_ADAPTER_KHR")]
        D3D11DxgiAdapterKhr = 0x401A,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_KERNEL_PRINTF_KHR")]
        KernelPrintf = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_KERNEL_PRINTF_KHR")]
        CommandBufferCapabilityKernelPrintfKhr = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_DEVICE_SIDE_ENQUEUE_KHR")]
        DeviceSideEnqueue = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_DEVICE_SIDE_ENQUEUE_KHR")]
        CommandBufferCapabilityDeviceSideEnqueueKhr = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_SIMULTANEOUS_USE_KHR")]
        CommandBufferCapabilitySimultaneousUseKhr = 0x4,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_OUT_OF_ORDER_KHR")]
        OutOfOrder = 0x8,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_OUT_OF_ORDER_KHR")]
        CommandBufferCapabilityOutOfOrderKhr = 0x8,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_MULTIPLE_QUEUE_KHR")]
        MultipleQueue = 0x10,
        [NativeName("Name", "CL_COMMAND_BUFFER_CAPABILITY_MULTIPLE_QUEUE_KHR")]
        CommandBufferCapabilityMultipleQueueKhr = 0x10,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_KHR")]
        Khr = 0x2,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_KHR")]
        DeviceIntegerDotProductInput4x8BitKhr = 0x2,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_PACKED_KHR")]
        Packed = 0x1,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_PACKED_KHR")]
        DeviceIntegerDotProductInput4x8BitPackedKhr = 0x1,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_CONTEXT_KHR")]
        DeviceTerminateCapabilityContextKhr = 0x1,
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        YuvPlaneIntel = 0x4107,
        [NativeName("Name", "CL_EGL_YUV_PLANE_INTEL")]
        EglYuvPlaneIntel = 0x4107,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_DMA_BUF_KHR")]
        DmaBuf = 0x2067,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_DMA_BUF_KHR")]
        ExternalMemoryHandleDmaBufKhr = 0x2067,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KHR")]
        D3D11Texture = 0x2063,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KHR")]
        ExternalMemoryHandleD3D11TextureKhr = 0x2063,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KMT_KHR")]
        D3D11TextureKmt = 0x2064,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KMT_KHR")]
        ExternalMemoryHandleD3D11TextureKmtKhr = 0x2064,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_HEAP_KHR")]
        D3D12Heap = 0x2065,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_HEAP_KHR")]
        ExternalMemoryHandleD3D12HeapKhr = 0x2065,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_RESOURCE_KHR")]
        D3D12Resource = 0x2066,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_RESOURCE_KHR")]
        ExternalMemoryHandleD3D12ResourceKhr = 0x2066,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_FD_KHR")]
        OpaqueFD = 0x2060,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_FD_KHR")]
        ExternalMemoryHandleOpaqueFDKhr = 0x2060,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KHR")]
        OpaqueWin32 = 0x2061,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KHR")]
        ExternalMemoryHandleOpaqueWin32Khr = 0x2061,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        OpaqueWin32Kmt = 0x2062,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        ExternalMemoryHandleOpaqueWin32KmtKhr = 0x2062,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_D3D12_FENCE_KHR")]
        D3D12Fence = 0x2059,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_D3D12_FENCE_KHR")]
        SemaphoreHandleD3D12FenceKhr = 0x2059,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_FD_KHR")]
        SemaphoreHandleOpaqueFDKhr = 0x2055,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_SYNC_FD_KHR")]
        SyncFD = 0x2058,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_SYNC_FD_KHR")]
        SemaphoreHandleSyncFDKhr = 0x2058,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_WIN32_KHR")]
        SemaphoreHandleOpaqueWin32Khr = 0x2056,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        SemaphoreHandleOpaqueWin32KmtKhr = 0x2057,
        [NativeName("Name", "CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR")]
        CurrentDeviceForGLContext = 0x2006,
        [NativeName("Name", "CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR")]
        CurrentDeviceForGLContextKhr = 0x2006,
        [NativeName("Name", "CL_DEVICES_FOR_GL_CONTEXT_KHR")]
        DevicesForGLContext = 0x2007,
        [NativeName("Name", "CL_DEVICES_FOR_GL_CONTEXT_KHR")]
        DevicesForGLContextKhr = 0x2007,
        [NativeName("Name", "CL_GL_OBJECT_BUFFER")]
        Buffer = 0x2000,
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
        NumSamples = 0x2012,
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
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        PreferredDevicesForDX9MediaAdapter = 0x2023,
        [NativeName("Name", "CL_PREFERRED_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        PreferredDevicesForDX9MediaAdapterKhr = 0x2023,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        AllDevicesForDX9MediaAdapter = 0x2024,
        [NativeName("Name", "CL_ALL_DEVICES_FOR_DX9_MEDIA_ADAPTER_KHR")]
        AllDevicesForDX9MediaAdapterKhr = 0x2024,
        [NativeName("Name", "CL_ADAPTER_D3D9_KHR")]
        D3D9 = 0x2020,
        [NativeName("Name", "CL_ADAPTER_D3D9_KHR")]
        AdapterD3D9Khr = 0x2020,
        [NativeName("Name", "CL_ADAPTER_D3D9EX_KHR")]
        D3D9EX = 0x2021,
        [NativeName("Name", "CL_ADAPTER_D3D9EX_KHR")]
        AdapterD3D9EXKhr = 0x2021,
        [NativeName("Name", "CL_ADAPTER_DXVA_KHR")]
        Dxva = 0x2022,
        [NativeName("Name", "CL_ADAPTER_DXVA_KHR")]
        AdapterDxvaKhr = 0x2022,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_QUEUE_KHR")]
        CommandCommandQueue = 0x12A0,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_QUEUE_KHR")]
        MutableCommandCommandQueueKhr = 0x12A0,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_BUFFER_KHR")]
        CommandCommandBuffer = 0x12A1,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_BUFFER_KHR")]
        MutableCommandCommandBufferKhr = 0x12A1,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_TYPE_KHR")]
        CommandCommandType = 0x12AD,
        [NativeName("Name", "CL_MUTABLE_COMMAND_COMMAND_TYPE_KHR")]
        MutableCommandCommandTypeKhr = 0x12AD,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_PROPERTIES_ARRAY_KHR")]
        DispatchPropertiesArray = 0x12A2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_PROPERTIES_ARRAY_KHR")]
        MutableDispatchPropertiesArrayKhr = 0x12A2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_KERNEL_KHR")]
        DispatchKernel = 0x12A3,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_KERNEL_KHR")]
        MutableDispatchKernelKhr = 0x12A3,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_DIMENSIONS_KHR")]
        DispatchDimensions = 0x12A4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_DIMENSIONS_KHR")]
        MutableDispatchDimensionsKhr = 0x12A4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_OFFSET_KHR")]
        DispatchGlobalWorkOffset = 0x12A5,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_OFFSET_KHR")]
        MutableDispatchGlobalWorkOffsetKhr = 0x12A5,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_SIZE_KHR")]
        DispatchGlobalWorkSize = 0x12A6,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_WORK_SIZE_KHR")]
        MutableDispatchGlobalWorkSizeKhr = 0x12A6,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_WORK_SIZE_KHR")]
        DispatchLocalWorkSize = 0x12A7,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_WORK_SIZE_KHR")]
        MutableDispatchLocalWorkSizeKhr = 0x12A7,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_OFFSET_KHR")]
        GlobalOffset = 0x1,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_OFFSET_KHR")]
        MutableDispatchGlobalOffsetKhr = 0x1,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_SIZE_KHR")]
        GlobalSize = 0x2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_GLOBAL_SIZE_KHR")]
        MutableDispatchGlobalSizeKhr = 0x2,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_SIZE_KHR")]
        LocalSize = 0x4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_LOCAL_SIZE_KHR")]
        MutableDispatchLocalSizeKhr = 0x4,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_ARGUMENTS_KHR")]
        Arguments = 0x8,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_ARGUMENTS_KHR")]
        MutableDispatchArgumentsKhr = 0x8,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_EXEC_INFO_KHR")]
        ExecInfo = 0x10,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_EXEC_INFO_KHR")]
        MutableDispatchExecInfoKhr = 0x10,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_UPDATABLE_FIELDS_KHR")]
        MutableDispatchUpdatableFields = 0x12B1,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_UPDATABLE_FIELDS_KHR")]
        MutableDispatchUpdatableFieldsKhr = 0x12B1,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_UNIVERSAL_SYNC_KHR")]
        UniversalSync = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_UNIVERSAL_SYNC_KHR")]
        CommandBufferPlatformUniversalSyncKhr = 0x1,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_REMAP_QUEUES_KHR")]
        RemapQueues = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_REMAP_QUEUES_KHR")]
        CommandBufferPlatformRemapQueuesKhr = 0x2,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_AUTOMATIC_REMAP_KHR")]
        AutomaticRemap = 0x4,
        [NativeName("Name", "CL_COMMAND_BUFFER_PLATFORM_AUTOMATIC_REMAP_KHR")]
        CommandBufferPlatformAutomaticRemapKhr = 0x4,
        [NativeName("Name", "CL_QUEUE_PRIORITY_HIGH_KHR")]
        High = 0x1,
        [NativeName("Name", "CL_QUEUE_PRIORITY_HIGH_KHR")]
        QueuePriorityHighKhr = 0x1,
        [NativeName("Name", "CL_QUEUE_PRIORITY_MED_KHR")]
        Med = 0x2,
        [NativeName("Name", "CL_QUEUE_PRIORITY_MED_KHR")]
        QueuePriorityMedKhr = 0x2,
        [NativeName("Name", "CL_QUEUE_PRIORITY_LOW_KHR")]
        Low = 0x4,
        [NativeName("Name", "CL_QUEUE_PRIORITY_LOW_KHR")]
        QueuePriorityLowKhr = 0x4,
        [NativeName("Name", "CL_QUEUE_THROTTLE_HIGH_KHR")]
        QueueThrottleHighKhr = 0x1,
        [NativeName("Name", "CL_QUEUE_THROTTLE_MED_KHR")]
        QueueThrottleMedKhr = 0x2,
        [NativeName("Name", "CL_QUEUE_THROTTLE_LOW_KHR")]
        QueueThrottleLowKhr = 0x4,
        [NativeName("Name", "CL_SEMAPHORE_CONTEXT_KHR")]
        SemaphoreContextKhr = 0x2039,
        [NativeName("Name", "CL_SEMAPHORE_REFERENCE_COUNT_KHR")]
        SemaphoreReferenceCountKhr = 0x203A,
        [NativeName("Name", "CL_SEMAPHORE_PROPERTIES_KHR")]
        Properties = 0x203B,
        [NativeName("Name", "CL_SEMAPHORE_PROPERTIES_KHR")]
        SemaphorePropertiesKhr = 0x203B,
        [NativeName("Name", "CL_SEMAPHORE_PAYLOAD_KHR")]
        Payload = 0x203C,
        [NativeName("Name", "CL_SEMAPHORE_PAYLOAD_KHR")]
        SemaphorePayloadKhr = 0x203C,
        [NativeName("Name", "CL_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        ExportHandleTypes = 0x203F,
        [NativeName("Name", "CL_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        SemaphoreExportHandleTypesKhr = 0x203F,
        [NativeName("Name", "CL_SEMAPHORE_TYPE_BINARY_KHR")]
        Binary = 0x1,
        [NativeName("Name", "CL_SEMAPHORE_TYPE_BINARY_KHR")]
        SemaphoreTypeBinaryKhr = 0x1,
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
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        GLFenceSyncObjectKhr = 0x200D,
        [NativeName("Name", "CL_COMMAND_GL_FENCE_SYNC_OBJECT_KHR")]
        CommandGLFenceSyncObjectKhr = 0x200D,
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
        [NativeName("Name", "CL_CONTEXT_D3D10_DEVICE_KHR")]
        ContextD3D10DeviceKhr = 0x4014,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        D3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_CONTEXT_D3D10_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D10PreferSharedResourcesKhr = 0x402C,
        [NativeName("Name", "CL_CONTEXT_D3D11_DEVICE_KHR")]
        ContextD3D11DeviceKhr = 0x401D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        D3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_CONTEXT_D3D11_PREFER_SHARED_RESOURCES_KHR")]
        ContextD3D11PreferSharedResourcesKhr = 0x402D,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9_KHR")]
        ContextAdapterD3D9Khr = 0x2025,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_D3D9EX_KHR")]
        ContextAdapterD3D9EXKhr = 0x2026,
        [NativeName("Name", "CL_CONTEXT_ADAPTER_DXVA_KHR")]
        ContextAdapterDxvaKhr = 0x2027,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        TerminateKhr = 0x2032,
        [NativeName("Name", "CL_CONTEXT_TERMINATE_KHR")]
        ContextTerminateKhr = 0x2032,
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
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        MaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        DeviceMaxNamedBarrierCountKhr = 0x2035,
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
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        PciBusInfoKhr = 0x410F,
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        DevicePciBusInfoKhr = 0x410F,
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
        DeviceSemaphoreExportHandleTypesKhr = 0x204E,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        ExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        DeviceExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        CommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        DeviceCommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        CommandBufferRequiredQueuePropertiesKhr = 0x12AA,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        DeviceCommandBufferRequiredQueuePropertiesKhr = 0x12AA,
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
        [NativeName("Name", "CL_INVALID_GL_SHAREGROUP_REFERENCE_KHR")]
        InvalidGLSharegroupReferenceKhr = unchecked((int) 0xFFFFFFFFFFFFFC18),
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
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        MaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        KernelMaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        SubGroupCountForNdrangeKhr = 0x2034,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        KernelSubGroupCountForNdrangeKhr = 0x2034,
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
        [NativeName("Name", "CL_DEVICE_HANDLE_LIST_KHR")]
        DeviceHandleListKhr = 0x2051,
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
        [NativeName("Name", "CL_COMMAND_EGL_FENCE_SYNC_OBJECT_KHR")]
        CommandEglFenceSyncObjectKhr = 0x202F,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_EGL_OBJECTS_KHR")]
        CommandAcquireEglObjectsKhr = 0x202D,
        [NativeName("Name", "CL_COMMAND_RELEASE_EGL_OBJECTS_KHR")]
        CommandReleaseEglObjectsKhr = 0x202E,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DeviceDoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        DeviceHalfFPConfig = 0x1033,
        [NativeName("Name", "CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
        ContextMemoryInitializeKhr = 0x2030,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        DeviceSpirVersions = 0x40E0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
        ProgramBinaryTypeIntermediate = 0x40E1,
        [NativeName("Name", "CL_DEPTH_STENCIL")]
        DepthStencil = 0x10BE,
        [NativeName("Name", "CL_UNORM_INT24")]
        UnormInt24 = 0x10DF,
        [NativeName("Name", "CL_GL_CONTEXT_KHR")]
        GLContextKhr = 0x2008,
        [NativeName("Name", "CL_EGL_DISPLAY_KHR")]
        EglDisplayKhr = 0x2009,
        [NativeName("Name", "CL_GLX_DISPLAY_KHR")]
        GlxDisplayKhr = 0x200A,
        [NativeName("Name", "CL_WGL_HDC_KHR")]
        WglHdcKhr = 0x200B,
        [NativeName("Name", "CL_CGL_SHAREGROUP_KHR")]
        CglSharegroupKhr = 0x200C,
        [NativeName("Name", "CL_DRIVER_UUID_KHR")]
        DeviceDriverUuidKhr = 0x106B,
        [NativeName("Name", "CL_DEPTH")]
        Depth = 0x10BD,
        [NativeName("Name", "CL_SEMAPHORE_TYPE_KHR")]
        SemaphoreTypeKhr = 0x203D,
    }
}
