// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "ErrorCodes.0")]
    public enum ErrorCodes : int
    {
        [NativeName("Name", "CL_SUCCESS")]
        Success = 0x0,
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
    }
}
