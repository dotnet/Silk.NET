// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("ErrorCodes")]
public enum ErrorCodes : int
{
    [NativeName("CL_SUCCESS")]
    Success = 0,

    [NativeName("CL_DEVICE_NOT_FOUND")]
    DeviceNotFound = -1,

    [NativeName("CL_DEVICE_NOT_AVAILABLE")]
    DeviceNotAvailable = -2,

    [NativeName("CL_COMPILER_NOT_AVAILABLE")]
    CompilerNotAvailable = -3,

    [NativeName("CL_MEM_OBJECT_ALLOCATION_FAILURE")]
    MemObjectAllocationFailure = -4,

    [NativeName("CL_OUT_OF_RESOURCES")]
    OutOfResources = -5,

    [NativeName("CL_OUT_OF_HOST_MEMORY")]
    OutOfHostMemory = -6,

    [NativeName("CL_PROFILING_INFO_NOT_AVAILABLE")]
    ProfilingInfoNotAvailable = -7,

    [NativeName("CL_MEM_COPY_OVERLAP")]
    MemCopyOverlap = -8,

    [NativeName("CL_IMAGE_FORMAT_MISMATCH")]
    ImageFormatMismatch = -9,

    [NativeName("CL_IMAGE_FORMAT_NOT_SUPPORTED")]
    ImageFormatNotSupported = -10,

    [NativeName("CL_BUILD_PROGRAM_FAILURE")]
    BuildProgramFailure = -11,

    [NativeName("CL_MAP_FAILURE")]
    MapFailure = -12,

    [NativeName("CL_MISALIGNED_SUB_BUFFER_OFFSET")]
    MisalignedSubBufferOffset = -13,

    [NativeName("CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST")]
    ExecStatusErrorForEventsInWaitList = -14,

    [NativeName("CL_COMPILE_PROGRAM_FAILURE")]
    CompileProgramFailure = -15,

    [NativeName("CL_LINKER_NOT_AVAILABLE")]
    LinkerNotAvailable = -16,

    [NativeName("CL_LINK_PROGRAM_FAILURE")]
    LinkProgramFailure = -17,

    [NativeName("CL_DEVICE_PARTITION_FAILED")]
    DevicePartitionFailed = -18,

    [NativeName("CL_KERNEL_ARG_INFO_NOT_AVAILABLE")]
    KernelArgInfoNotAvailable = -19,

    [NativeName("CL_INVALID_VALUE")]
    InvalidValue = -30,

    [NativeName("CL_INVALID_DEVICE_TYPE")]
    InvalidDeviceType = -31,

    [NativeName("CL_INVALID_PLATFORM")]
    InvalidPlatform = -32,

    [NativeName("CL_INVALID_DEVICE")]
    InvalidDevice = -33,

    [NativeName("CL_INVALID_CONTEXT")]
    InvalidContext = -34,

    [NativeName("CL_INVALID_QUEUE_PROPERTIES")]
    InvalidQueueProperties = -35,

    [NativeName("CL_INVALID_COMMAND_QUEUE")]
    InvalidCommandQueue = -36,

    [NativeName("CL_INVALID_HOST_PTR")]
    InvalidHostPtr = -37,

    [NativeName("CL_INVALID_MEM_OBJECT")]
    InvalidMemObject = -38,

    [NativeName("CL_INVALID_IMAGE_FORMAT_DESCRIPTOR")]
    InvalidImageFormatDescriptor = -39,

    [NativeName("CL_INVALID_IMAGE_SIZE")]
    InvalidImageSize = -40,

    [NativeName("CL_INVALID_SAMPLER")]
    InvalidSampler = -41,

    [NativeName("CL_INVALID_BINARY")]
    InvalidBinary = -42,

    [NativeName("CL_INVALID_BUILD_OPTIONS")]
    InvalidBuildOptions = -43,

    [NativeName("CL_INVALID_PROGRAM")]
    InvalidProgram = -44,

    [NativeName("CL_INVALID_PROGRAM_EXECUTABLE")]
    InvalidProgramExecutable = -45,

    [NativeName("CL_INVALID_KERNEL_NAME")]
    InvalidKernelName = -46,

    [NativeName("CL_INVALID_KERNEL_DEFINITION")]
    InvalidKernelDefinition = -47,

    [NativeName("CL_INVALID_KERNEL")]
    InvalidKernel = -48,

    [NativeName("CL_INVALID_ARG_INDEX")]
    InvalidArgIndex = -49,

    [NativeName("CL_INVALID_ARG_VALUE")]
    InvalidArgValue = -50,

    [NativeName("CL_INVALID_ARG_SIZE")]
    InvalidArgSize = -51,

    [NativeName("CL_INVALID_KERNEL_ARGS")]
    InvalidKernelArgs = -52,

    [NativeName("CL_INVALID_WORK_DIMENSION")]
    InvalidWorkDimension = -53,

    [NativeName("CL_INVALID_WORK_GROUP_SIZE")]
    InvalidWorkGroupSize = -54,

    [NativeName("CL_INVALID_WORK_ITEM_SIZE")]
    InvalidWorkItemSize = -55,

    [NativeName("CL_INVALID_GLOBAL_OFFSET")]
    InvalidGlobalOffset = -56,

    [NativeName("CL_INVALID_EVENT_WAIT_LIST")]
    InvalidEventWaitList = -57,

    [NativeName("CL_INVALID_EVENT")]
    InvalidEvent = -58,

    [NativeName("CL_INVALID_OPERATION")]
    InvalidOperation = -59,

    [NativeName("CL_INVALID_GL_OBJECT")]
    InvalidGlObject = -60,

    [NativeName("CL_INVALID_BUFFER_SIZE")]
    InvalidBufferSize = -61,

    [NativeName("CL_INVALID_MIP_LEVEL")]
    InvalidMipLevel = -62,

    [NativeName("CL_INVALID_GLOBAL_WORK_SIZE")]
    InvalidGlobalWorkSize = -63,

    [NativeName("CL_INVALID_PROPERTY")]
    InvalidProperty = -64,

    [NativeName("CL_INVALID_IMAGE_DESCRIPTOR")]
    InvalidImageDescriptor = -65,

    [NativeName("CL_INVALID_COMPILER_OPTIONS")]
    InvalidCompilerOptions = -66,

    [NativeName("CL_INVALID_LINKER_OPTIONS")]
    InvalidLinkerOptions = -67,

    [NativeName("CL_INVALID_DEVICE_PARTITION_COUNT")]
    InvalidDevicePartitionCount = -68,

    [NativeName("CL_INVALID_PIPE_SIZE")]
    InvalidPipeSize = -69,

    [NativeName("CL_INVALID_DEVICE_QUEUE")]
    InvalidDeviceQueue = -70,

    [NativeName("CL_INVALID_SPEC_ID")]
    InvalidSpecId = -71,

    [NativeName("CL_MAX_SIZE_RESTRICTION_EXCEEDED")]
    MaxSizeRestrictionExceeded = -72,

    [NativeName("CL_PLATFORM_NOT_FOUND_KHR")]
    PlatformNotFoundKHR = -1001,

    [NativeName("CL_CONTEXT_TERMINATED_KHR")]
    ContextTerminatedKHR = -1121,

    [NativeName("CL_DEVICE_PARTITION_FAILED_EXT")]
    DevicePartitionFailedEXT = -1057,

    [NativeName("CL_INVALID_PARTITION_COUNT_EXT")]
    InvalidPartitionCountEXT = -1058,

    [NativeName("CL_INVALID_PARTITION_NAME_EXT")]
    InvalidPartitionNameEXT = -1059,

    [NativeName("CL_GRALLOC_RESOURCE_NOT_ACQUIRED_IMG")]
    GrallocResourceNotAcquiredIMG = 16596,

    [NativeName("CL_INVALID_GRALLOC_OBJECT_IMG")]
    InvalidGrallocObjectIMG = 16597,

    [NativeName("CL_INVALID_SEMAPHORE_KHR")]
    InvalidSemaphoreKHR = -1142,

    [NativeName("CL_COMMAND_TERMINATED_ITSELF_WITH_FAILURE_ARM")]
    CommandTerminatedItselfWithFailureARM = -1108,

    [NativeName("CL_INVALID_ACCELERATOR_INTEL")]
    InvalidAcceleratorINTEL = -1094,

    [NativeName("CL_INVALID_ACCELERATOR_TYPE_INTEL")]
    InvalidAcceleratorTypeINTEL = -1095,

    [NativeName("CL_INVALID_ACCELERATOR_DESCRIPTOR_INTEL")]
    InvalidAcceleratorDescriptorINTEL = -1096,

    [NativeName("CL_ACCELERATOR_TYPE_NOT_SUPPORTED_INTEL")]
    AcceleratorTypeNotSupportedINTEL = -1097,

    [NativeName("CL_CANCELLED_IMG")]
    CancelledIMG = -1126,

    [NativeName("CL_ECC_RECOVERED_IMG")]
    EccRecoveredIMG = 16605,

    [NativeName("CL_PAGE_FAULT_IMG")]
    PageFaultIMG = -1127,

    [NativeName("CL_SAFETY_FAULT_IMG")]
    SafetyFaultIMG = -1128,

    [NativeName("CL_GENERAL_FAULT_IMG")]
    GeneralFaultIMG = -1129,

    [NativeName("CL_ECC_UNRECOVERED_IMG")]
    EccUnrecoveredIMG = -1130,
}
