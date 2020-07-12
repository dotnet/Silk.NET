// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "GLenum")]
    public enum CLEnum
    {
        [NativeName("Name", "CL_SUCCESS")]
        Success = 0x0,
        [NativeName("Name", "CL_DEVICE_NOT_FOUND")]
        DeviceNotFound = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "CL_DEVICE_NOT_AVAILABLE")]
        DeviceNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_COMPILER_NOT_AVAILABLE")]
        CompilerNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "CL_MEM_OBJECT_ALLOCATION_FAILURE")]
        MemObjectAllocationFailure = unchecked((int)0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "CL_OUT_OF_RESOURCES")]
        OutOfResources = unchecked((int)0xFFFFFFFFFFFFFFFB),
        [NativeName("Name", "CL_OUT_OF_HOST_MEMORY")]
        OutOfHostMemory = unchecked((int)0xFFFFFFFFFFFFFFFA),
        [NativeName("Name", "CL_PROFILING_INFO_NOT_AVAILABLE")]
        ProfilingInfoNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFF9),
        [NativeName("Name", "CL_MEM_COPY_OVERLAP")]
        MemCopyOverlap = unchecked((int)0xFFFFFFFFFFFFFFF8),
        [NativeName("Name", "CL_IMAGE_FORMAT_MISMATCH")]
        ImageFormatMismatch = unchecked((int)0xFFFFFFFFFFFFFFF7),
        [NativeName("Name", "CL_IMAGE_FORMAT_NOT_SUPPORTED")]
        ImageFormatNotSupported = unchecked((int)0xFFFFFFFFFFFFFFF6),
        [NativeName("Name", "CL_BUILD_PROGRAM_FAILURE")]
        BuildProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFF5),
        [NativeName("Name", "CL_MAP_FAILURE")]
        MapFailure = unchecked((int)0xFFFFFFFFFFFFFFF4),
        [NativeName("Name", "CL_INVALID_VALUE")]
        InvalidValue = unchecked((int)0xFFFFFFFFFFFFFFE2),
        [NativeName("Name", "CL_INVALID_DEVICE_TYPE")]
        InvalidDeviceType = unchecked((int)0xFFFFFFFFFFFFFFE1),
        [NativeName("Name", "CL_INVALID_PLATFORM")]
        InvalidPlatform = unchecked((int)0xFFFFFFFFFFFFFFE0),
        [NativeName("Name", "CL_INVALID_DEVICE")]
        InvalidDevice = unchecked((int)0xFFFFFFFFFFFFFFDF),
        [NativeName("Name", "CL_INVALID_CONTEXT")]
        InvalidContext = unchecked((int)0xFFFFFFFFFFFFFFDE),
        [NativeName("Name", "CL_INVALID_QUEUE_PROPERTIES")]
        InvalidQueueProperties = unchecked((int)0xFFFFFFFFFFFFFFDD),
        [NativeName("Name", "CL_INVALID_COMMAND_QUEUE")]
        InvalidCommandQueue = unchecked((int)0xFFFFFFFFFFFFFFDC),
        [NativeName("Name", "CL_INVALID_HOST_PTR")]
        InvalidHostPtr = unchecked((int)0xFFFFFFFFFFFFFFDB),
        [NativeName("Name", "CL_INVALID_MEM_OBJECT")]
        InvalidMemObject = unchecked((int)0xFFFFFFFFFFFFFFDA),
        [NativeName("Name", "CL_INVALID_IMAGE_FORMAT_DESCRIPTOR")]
        InvalidImageFormatDescriptor = unchecked((int)0xFFFFFFFFFFFFFFD9),
        [NativeName("Name", "CL_INVALID_IMAGE_SIZE")]
        InvalidImageSize = unchecked((int)0xFFFFFFFFFFFFFFD8),
        [NativeName("Name", "CL_INVALID_SAMPLER")]
        InvalidSampler = unchecked((int)0xFFFFFFFFFFFFFFD7),
        [NativeName("Name", "CL_INVALID_BINARY")]
        InvalidBinary = unchecked((int)0xFFFFFFFFFFFFFFD6),
        [NativeName("Name", "CL_INVALID_BUILD_OPTIONS")]
        InvalidBuildOptions = unchecked((int)0xFFFFFFFFFFFFFFD5),
        [NativeName("Name", "CL_INVALID_PROGRAM")]
        InvalidProgram = unchecked((int)0xFFFFFFFFFFFFFFD4),
        [NativeName("Name", "CL_INVALID_PROGRAM_EXECUTABLE")]
        InvalidProgramExecutable = unchecked((int)0xFFFFFFFFFFFFFFD3),
        [NativeName("Name", "CL_INVALID_KERNEL_NAME")]
        InvalidKernelName = unchecked((int)0xFFFFFFFFFFFFFFD2),
        [NativeName("Name", "CL_INVALID_KERNEL_DEFINITION")]
        InvalidKernelDefinition = unchecked((int)0xFFFFFFFFFFFFFFD1),
        [NativeName("Name", "CL_INVALID_KERNEL")]
        InvalidKernel = unchecked((int)0xFFFFFFFFFFFFFFD0),
        [NativeName("Name", "CL_INVALID_ARG_INDEX")]
        InvalidArgIndex = unchecked((int)0xFFFFFFFFFFFFFFCF),
        [NativeName("Name", "CL_INVALID_ARG_VALUE")]
        InvalidArgValue = unchecked((int)0xFFFFFFFFFFFFFFCE),
        [NativeName("Name", "CL_INVALID_ARG_SIZE")]
        InvalidArgSize = unchecked((int)0xFFFFFFFFFFFFFFCD),
        [NativeName("Name", "CL_INVALID_KERNEL_ARGS")]
        InvalidKernelArgs = unchecked((int)0xFFFFFFFFFFFFFFCC),
        [NativeName("Name", "CL_INVALID_WORK_DIMENSION")]
        InvalidWorkDimension = unchecked((int)0xFFFFFFFFFFFFFFCB),
        [NativeName("Name", "CL_INVALID_WORK_GROUP_SIZE")]
        InvalidWorkGroupSize = unchecked((int)0xFFFFFFFFFFFFFFCA),
        [NativeName("Name", "CL_INVALID_WORK_ITEM_SIZE")]
        InvalidWorkItemSize = unchecked((int)0xFFFFFFFFFFFFFFC9),
        [NativeName("Name", "CL_INVALID_GLOBAL_OFFSET")]
        InvalidGlobalOffset = unchecked((int)0xFFFFFFFFFFFFFFC8),
        [NativeName("Name", "CL_INVALID_EVENT_WAIT_LIST")]
        InvalidEventWaitList = unchecked((int)0xFFFFFFFFFFFFFFC7),
        [NativeName("Name", "CL_INVALID_EVENT")]
        InvalidEvent = unchecked((int)0xFFFFFFFFFFFFFFC6),
        [NativeName("Name", "CL_INVALID_OPERATION")]
        InvalidOperation = unchecked((int)0xFFFFFFFFFFFFFFC5),
        [NativeName("Name", "CL_INVALID_GL_OBJECT")]
        InvalidGLObject = unchecked((int)0xFFFFFFFFFFFFFFC4),
        [NativeName("Name", "CL_INVALID_BUFFER_SIZE")]
        InvalidBufferSize = unchecked((int)0xFFFFFFFFFFFFFFC3),
        [NativeName("Name", "CL_INVALID_MIP_LEVEL")]
        InvalidMipLevel = unchecked((int)0xFFFFFFFFFFFFFFC2),
        [NativeName("Name", "CL_INVALID_GLOBAL_WORK_SIZE")]
        InvalidGlobalWorkSize = unchecked((int)0xFFFFFFFFFFFFFFC1),
        [NativeName("Name", "CL_FALSE")]
        False = 0x0,
        [NativeName("Name", "CL_TRUE")]
        True = 0x1,
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
        [NativeName("Name", "CL_DEVICE_TYPE_DEFAULT")]
        DeviceTypeDefault = 0x1,
        [NativeName("Name", "CL_DEVICE_TYPE_CPU")]
        DeviceTypeCpu = 0x2,
        [NativeName("Name", "CL_DEVICE_TYPE_GPU")]
        DeviceTypeGpu = 0x4,
        [NativeName("Name", "CL_DEVICE_TYPE_ACCELERATOR")]
        DeviceTypeAccelerator = 0x8,
        [NativeName("Name", "CL_DEVICE_TYPE_ALL")]
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "CL_DEVICE_TYPE")]
        DeviceType = 0x1000,
        [NativeName("Name", "CL_DEVICE_VENDOR_ID")]
        DeviceVendorID = 0x1001,
        [NativeName("Name", "CL_DEVICE_MAX_COMPUTE_UNITS")]
        DeviceMaxComputeUnits = 0x1002,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
        DeviceMaxWorkItemDimensions = 0x1003,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE")]
        DeviceMaxWorkGroupSize = 0x1004,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_SIZES")]
        DeviceMaxWorkItemSizes = 0x1005,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
        DevicePreferredVectorWidthChar = 0x1006,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
        DevicePreferredVectorWidthShort = 0x1007,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
        DevicePreferredVectorWidthInt = 0x1008,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
        DevicePreferredVectorWidthLong = 0x1009,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
        DevicePreferredVectorWidthFloat = 0x100A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
        DevicePreferredVectorWidthDouble = 0x100B,
        [NativeName("Name", "CL_DEVICE_MAX_CLOCK_FREQUENCY")]
        DeviceMaxClockFrequency = 0x100C,
        [NativeName("Name", "CL_DEVICE_ADDRESS_BITS")]
        DeviceAddressBits = 0x100D,
        [NativeName("Name", "CL_DEVICE_MAX_READ_IMAGE_ARGS")]
        DeviceMaxReadImageArgs = 0x100E,
        [NativeName("Name", "CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
        DeviceMaxWriteImageArgs = 0x100F,
        [NativeName("Name", "CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
        DeviceMaxMemAllocSize = 0x1010,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_WIDTH")]
        DeviceImage2DMaxWidth = 0x1011,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
        DeviceImage2DMaxHeight = 0x1012,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_WIDTH")]
        DeviceImage3DMaxWidth = 0x1013,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
        DeviceImage3DMaxHeight = 0x1014,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_DEPTH")]
        DeviceImage3DMaxDepth = 0x1015,
        [NativeName("Name", "CL_DEVICE_IMAGE_SUPPORT")]
        DeviceImageSupport = 0x1016,
        [NativeName("Name", "CL_DEVICE_MAX_PARAMETER_SIZE")]
        DeviceMaxParameterSize = 0x1017,
        [NativeName("Name", "CL_DEVICE_MAX_SAMPLERS")]
        DeviceMaxSamplers = 0x1018,
        [NativeName("Name", "CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
        DeviceMemBaseAddrAlign = 0x1019,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_CONFIG")]
        DeviceSingleFPConfig = 0x101B,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
        DeviceGlobalMemCacheType = 0x101C,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
        DeviceGlobalMemCachelineSize = 0x101D,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
        DeviceGlobalMemCacheSize = 0x101E,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_SIZE")]
        DeviceGlobalMemSize = 0x101F,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
        DeviceMaxConstantBufferSize = 0x1020,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_ARGS")]
        DeviceMaxConstantArgs = 0x1021,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_TYPE")]
        DeviceLocalMemType = 0x1022,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE")]
        DeviceLocalMemSize = 0x1023,
        [NativeName("Name", "CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
        DeviceErrorCorrectionSupport = 0x1024,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
        DeviceProfilingTimerResolution = 0x1025,
        [NativeName("Name", "CL_DEVICE_ENDIAN_LITTLE")]
        DeviceEndianLittle = 0x1026,
        [NativeName("Name", "CL_DEVICE_AVAILABLE")]
        DeviceAvailable = 0x1027,
        [NativeName("Name", "CL_DEVICE_COMPILER_AVAILABLE")]
        DeviceCompilerAvailable = 0x1028,
        [NativeName("Name", "CL_DEVICE_EXECUTION_CAPABILITIES")]
        DeviceExecutionCapabilities = 0x1029,
        [NativeName("Name", "CL_DEVICE_NAME")]
        DeviceName = 0x102B,
        [NativeName("Name", "CL_DEVICE_VENDOR")]
        DeviceVendor = 0x102C,
        [NativeName("Name", "CL_DRIVER_VERSION")]
        DriverVersion = 0x102D,
        [NativeName("Name", "CL_DEVICE_PROFILE")]
        DeviceProfile = 0x102E,
        [NativeName("Name", "CL_DEVICE_VERSION")]
        DeviceVersion = 0x102F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS")]
        DeviceExtensions = 0x1030,
        [NativeName("Name", "CL_DEVICE_PLATFORM")]
        DevicePlatform = 0x1031,
        [NativeName("Name", "CL_FP_DENORM")]
        FPDenorm = 0x1,
        [NativeName("Name", "CL_FP_INF_NAN")]
        FPInfNan = 0x2,
        [NativeName("Name", "CL_FP_ROUND_TO_NEAREST")]
        FPRoundToNearest = 0x4,
        [NativeName("Name", "CL_FP_ROUND_TO_ZERO")]
        FPRoundToZero = 0x8,
        [NativeName("Name", "CL_FP_ROUND_TO_INF")]
        FPRoundToInf = 0x16,
        [NativeName("Name", "CL_FP_FMA")]
        FPFma = 0x32,
        [NativeName("Name", "CL_NONE")]
        None = 0x0,
        [NativeName("Name", "CL_READ_ONLY_CACHE")]
        ReadOnlyCache = 0x1,
        [NativeName("Name", "CL_READ_WRITE_CACHE")]
        ReadWriteCache = 0x2,
        [NativeName("Name", "CL_LOCAL")]
        Local = 0x1,
        [NativeName("Name", "CL_GLOBAL")]
        Global = 0x2,
        [NativeName("Name", "CL_EXEC_KERNEL")]
        ExecKernel = 0x1,
        [NativeName("Name", "CL_EXEC_NATIVE_KERNEL")]
        ExecNativeKernel = 0x2,
        [NativeName("Name", "CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE")]
        QueueOutOfOrderExecModeEnable = 0x1,
        [NativeName("Name", "CL_QUEUE_PROFILING_ENABLE")]
        QueueProfilingEnable = 0x2,
        [NativeName("Name", "CL_CONTEXT_REFERENCE_COUNT")]
        ContextReferenceCount = 0x1080,
        [NativeName("Name", "CL_CONTEXT_DEVICES")]
        ContextDevices = 0x1081,
        [NativeName("Name", "CL_CONTEXT_PROPERTIES")]
        ContextProperties = 0x1082,
        [NativeName("Name", "CL_CONTEXT_PLATFORM")]
        ContextPlatform = 0x1084,
        [NativeName("Name", "CL_QUEUE_CONTEXT")]
        QueueContext = 0x1090,
        [NativeName("Name", "CL_QUEUE_DEVICE")]
        QueueDevice = 0x1091,
        [NativeName("Name", "CL_QUEUE_REFERENCE_COUNT")]
        QueueReferenceCount = 0x1092,
        [NativeName("Name", "CL_QUEUE_PROPERTIES")]
        QueueProperties = 0x1093,
        [NativeName("Name", "CL_MEM_READ_WRITE")]
        MemReadWrite = 0x1,
        [NativeName("Name", "CL_MEM_WRITE_ONLY")]
        MemWriteOnly = 0x2,
        [NativeName("Name", "CL_MEM_READ_ONLY")]
        MemReadOnly = 0x4,
        [NativeName("Name", "CL_MEM_USE_HOST_PTR")]
        MemUseHostPtr = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_HOST_PTR")]
        MemAllocHostPtr = 0x16,
        [NativeName("Name", "CL_MEM_COPY_HOST_PTR")]
        MemCopyHostPtr = 0x32,
        [NativeName("Name", "CL_PROFILING_COMMAND_QUEUED")]
        ProfilingCommandQueued = 0x1280,
        [NativeName("Name", "CL_PROFILING_COMMAND_SUBMIT")]
        ProfilingCommandSubmit = 0x1281,
        [NativeName("Name", "CL_PROFILING_COMMAND_START")]
        ProfilingCommandStart = 0x1282,
        [NativeName("Name", "CL_PROFILING_COMMAND_END")]
        ProfilingCommandEnd = 0x1283,
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
        [NativeName("Name", "CL_ADDRESS_NONE")]
        AddressNone = 0x1130,
        [NativeName("Name", "CL_ADDRESS_CLAMP_TO_EDGE")]
        AddressClampToEdge = 0x1131,
        [NativeName("Name", "CL_ADDRESS_CLAMP")]
        AddressClamp = 0x1132,
        [NativeName("Name", "CL_ADDRESS_REPEAT")]
        AddressRepeat = 0x1133,
        [NativeName("Name", "CL_FILTER_NEAREST")]
        FilterNearest = 0x1140,
        [NativeName("Name", "CL_FILTER_LINEAR")]
        FilterLinear = 0x1141,
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
        [NativeName("Name", "CL_BUILD_SUCCESS")]
        BuildSuccess = 0x0,
        [NativeName("Name", "CL_BUILD_NONE")]
        BuildNone = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "CL_BUILD_ERROR")]
        BuildError = unchecked((int)0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_BUILD_IN_PROGRESS")]
        BuildInProgress = unchecked((int)0xFFFFFFFFFFFFFFFD),
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
        [NativeName("Name", "CL_EVENT_COMMAND_QUEUE")]
        EventCommandQueue = 0x11D0,
        [NativeName("Name", "CL_EVENT_COMMAND_TYPE")]
        EventCommandType = 0x11D1,
        [NativeName("Name", "CL_EVENT_REFERENCE_COUNT")]
        EventReferenceCount = 0x11D2,
        [NativeName("Name", "CL_EVENT_COMMAND_EXECUTION_STATUS")]
        EventCommandExecutionStatus = 0x11D3,
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
        [NativeName("Name", "CL_COMPLETE")]
        Complete = 0x0,
        [NativeName("Name", "CL_RUNNING")]
        Running = 0x1,
        [NativeName("Name", "CL_SUBMITTED")]
        Submitted = 0x2,
        [NativeName("Name", "CL_QUEUED")]
        Queued = 0x3,
        [NativeName("Name", "CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
        DeviceMinDataTypeAlignSize = 0x101A,
        [NativeName("Name", "CL_DEVICE_QUEUE_PROPERTIES")]
        DeviceQueueProperties = 0x102A,
        [NativeName("Name", "CL_MISALIGNED_SUB_BUFFER_OFFSET")]
        MisalignedSubBufferOffset = unchecked((int)0xFFFFFFFFFFFFFFF3),
        [NativeName("Name", "CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST")]
        ExecStatusErrorForEventsInWaitList = unchecked((int)0xFFFFFFFFFFFFFFF2),
        [NativeName("Name", "CL_INVALID_PROPERTY")]
        InvalidProperty = unchecked((int)0xFFFFFFFFFFFFFFC0),
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
        DevicePreferredVectorWidthHalf = 0x1034,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
        DeviceNativeVectorWidthChar = 0x1036,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
        DeviceNativeVectorWidthShort = 0x1037,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
        DeviceNativeVectorWidthInt = 0x1038,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
        DeviceNativeVectorWidthLong = 0x1039,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
        DeviceNativeVectorWidthFloat = 0x103A,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
        DeviceNativeVectorWidthDouble = 0x103B,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
        DeviceNativeVectorWidthHalf = 0x103C,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_VERSION")]
        DeviceOpenclCVersion = 0x103D,
        [NativeName("Name", "CL_FP_SOFT_FLOAT")]
        FPSoftFloat = 0x64,
        [NativeName("Name", "CL_CONTEXT_NUM_DEVICES")]
        ContextNumDevices = 0x1083,
        [NativeName("Name", "CL_Rx")]
        Rx = 0x10BA,
        [NativeName("Name", "CL_RGx")]
        RGx = 0x10BB,
        [NativeName("Name", "CL_RGBx")]
        Rgbx = 0x10BC,
        [NativeName("Name", "CL_MEM_ASSOCIATED_MEMOBJECT")]
        MemAssociatedMemobject = 0x1107,
        [NativeName("Name", "CL_MEM_OFFSET")]
        MemOffset = 0x1108,
        [NativeName("Name", "CL_ADDRESS_MIRRORED_REPEAT")]
        AddressMirroredRepeat = 0x1134,
        [NativeName("Name", "CL_EVENT_CONTEXT")]
        EventContext = 0x11D4,
        [NativeName("Name", "CL_COMMAND_READ_BUFFER_RECT")]
        CommandReadBufferRect = 0x1201,
        [NativeName("Name", "CL_COMMAND_WRITE_BUFFER_RECT")]
        CommandWriteBufferRect = 0x1202,
        [NativeName("Name", "CL_COMMAND_COPY_BUFFER_RECT")]
        CommandCopyBufferRect = 0x1203,
        [NativeName("Name", "CL_COMMAND_USER")]
        CommandUser = 0x1204,
        [NativeName("Name", "CL_BUFFER_CREATE_TYPE_REGION")]
        BufferCreateTypeRegion = 0x1220,
        [NativeName("Name", "CL_DEVICE_HOST_UNIFIED_MEMORY")]
        DeviceHostUnifiedMemory = 0x1035,
        [NativeName("Name", "CL_COMPILE_PROGRAM_FAILURE")]
        CompileProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFF1),
        [NativeName("Name", "CL_LINKER_NOT_AVAILABLE")]
        LinkerNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFF0),
        [NativeName("Name", "CL_LINK_PROGRAM_FAILURE")]
        LinkProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFEF),
        [NativeName("Name", "CL_DEVICE_PARTITION_FAILED")]
        DevicePartitionFailed = unchecked((int)0xFFFFFFFFFFFFFFEE),
        [NativeName("Name", "CL_KERNEL_ARG_INFO_NOT_AVAILABLE")]
        KernelArgInfoNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFED),
        [NativeName("Name", "CL_INVALID_IMAGE_DESCRIPTOR")]
        InvalidImageDescriptor = unchecked((int)0xFFFFFFFFFFFFFFBF),
        [NativeName("Name", "CL_INVALID_COMPILER_OPTIONS")]
        InvalidCompilerOptions = unchecked((int)0xFFFFFFFFFFFFFFBE),
        [NativeName("Name", "CL_INVALID_LINKER_OPTIONS")]
        InvalidLinkerOptions = unchecked((int)0xFFFFFFFFFFFFFFBD),
        [NativeName("Name", "CL_INVALID_DEVICE_PARTITION_COUNT")]
        InvalidDevicePartitionCount = unchecked((int)0xFFFFFFFFFFFFFFBC),
        [NativeName("Name", "CL_COMMAND_BARRIER")]
        CommandBarrier = 0x1205,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECTS")]
        CommandMigrateMemObjects = 0x1206,
        [NativeName("Name", "CL_COMMAND_FILL_BUFFER")]
        CommandFillBuffer = 0x1207,
        [NativeName("Name", "CL_COMMAND_FILL_IMAGE")]
        CommandFillImage = 0x1208,
        [NativeName("Name", "CL_BLOCKING")]
        Blocking = 1,
        [NativeName("Name", "CL_NON_BLOCKING")]
        NonBlocking = 0,
        [NativeName("Name", "CL_DEVICE_TYPE_CUSTOM")]
        DeviceTypeCustom = 0x16,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DeviceDoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEVICE_LINKER_AVAILABLE")]
        DeviceLinkerAvailable = 0x103E,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS")]
        DeviceBuiltInKernels = 0x103F,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
        DeviceImageMaxBufferSize = 0x1040,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
        DeviceImageMaxArraySize = 0x1041,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE")]
        DeviceParentDevice = 0x1042,
        [NativeName("Name", "CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
        DevicePartitionMaxSubDevices = 0x1043,
        [NativeName("Name", "CL_DEVICE_PARTITION_PROPERTIES")]
        DevicePartitionProperties = 0x1044,
        [NativeName("Name", "CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
        DevicePartitionAffinityDomain = 0x1045,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPE")]
        DevicePartitionType = 0x1046,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT")]
        DeviceReferenceCount = 0x1047,
        [NativeName("Name", "CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
        DevicePreferredInteropUserSync = 0x1048,
        [NativeName("Name", "CL_DEVICE_PRINTF_BUFFER_SIZE")]
        DevicePrintfBufferSize = 0x1049,
        [NativeName("Name", "CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
        FPCorrectlyRoundedDivideSqrt = 0x128,
        [NativeName("Name", "CL_CONTEXT_INTEROP_USER_SYNC")]
        ContextInteropUserSync = 0x1085,
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY")]
        DevicePartitionEqually = 0x1086,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS")]
        DevicePartitionByCounts = 0x1087,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN")]
        DevicePartitionByAffinityDomain = 0x1088,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NUMA")]
        DeviceAffinityDomainNuma = 0x1,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE")]
        DeviceAffinityDomainL4Cache = 0x2,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE")]
        DeviceAffinityDomainL3Cache = 0x4,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE")]
        DeviceAffinityDomainL2Cache = 0x8,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE")]
        DeviceAffinityDomainL1Cache = 0x16,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE")]
        DeviceAffinityDomainNextPartitionable = 0x32,
        [NativeName("Name", "CL_MEM_HOST_WRITE_ONLY")]
        MemHostWriteOnly = 0x128,
        [NativeName("Name", "CL_MEM_HOST_READ_ONLY")]
        MemHostReadOnly = 0x256,
        [NativeName("Name", "CL_MEM_HOST_NO_ACCESS")]
        MemHostNoAccess = 0x512,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST")]
        MigrateMemObjectHost = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED")]
        MigrateMemObjectContentUndefined = 0x2,
        [NativeName("Name", "CL_DEPTH")]
        Depth = 0x10BD,
        [NativeName("Name", "CL_DEPTH_STENCIL")]
        DepthStencil = 0x10BE,
        [NativeName("Name", "CL_UNORM_INT24")]
        UnormInt24 = 0x10DF,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D_ARRAY")]
        MemObjectImage2DArray = 0x10F3,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D")]
        MemObjectImage1D = 0x10F4,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_ARRAY")]
        MemObjectImage1DArray = 0x10F5,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_BUFFER")]
        MemObjectImage1DBuffer = 0x10F6,
        [NativeName("Name", "CL_IMAGE_ARRAY_SIZE")]
        ImageArraySize = 0x1117,
        [NativeName("Name", "CL_IMAGE_NUM_MIP_LEVELS")]
        ImageNumMipLevels = 0x1119,
        [NativeName("Name", "CL_IMAGE_NUM_SAMPLES")]
        ImageNumSamples = 0x111A,
        [NativeName("Name", "CL_MAP_WRITE_INVALIDATE_REGION")]
        MapWriteInvalidateRegion = 0x4,
        [NativeName("Name", "CL_PROGRAM_NUM_KERNELS")]
        ProgramNumKernels = 0x1167,
        [NativeName("Name", "CL_PROGRAM_KERNEL_NAMES")]
        ProgramKernelNames = 0x1168,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE")]
        ProgramBinaryType = 0x1184,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_NONE")]
        ProgramBinaryTypeNone = 0x0,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
        ProgramBinaryTypeCompiledObject = 0x1,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_LIBRARY")]
        ProgramBinaryTypeLibrary = 0x2,
        [NativeName("Name", "CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
        ProgramBinaryTypeExecutable = 0x4,
        [NativeName("Name", "CL_KERNEL_ATTRIBUTES")]
        KernelAttributes = 0x1195,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_QUALIFIER")]
        KernelArgAddressQualifier = 0x1196,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_QUALIFIER")]
        KernelArgAccessQualifier = 0x1197,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NAME")]
        KernelArgTypeName = 0x1198,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_QUALIFIER")]
        KernelArgTypeQualifier = 0x1199,
        [NativeName("Name", "CL_KERNEL_ARG_NAME")]
        KernelArgName = 0x119A,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_GLOBAL")]
        KernelArgAddressGlobal = 0x119B,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_LOCAL")]
        KernelArgAddressLocal = 0x119C,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_CONSTANT")]
        KernelArgAddressConstant = 0x119D,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_PRIVATE")]
        KernelArgAddressPrivate = 0x119E,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_ONLY")]
        KernelArgAccessReadOnly = 0x11A0,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_WRITE_ONLY")]
        KernelArgAccessWriteOnly = 0x11A1,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_WRITE")]
        KernelArgAccessReadWrite = 0x11A2,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_NONE")]
        KernelArgAccessNone = 0x11A3,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NONE")]
        KernelArgTypeNone = 0x0,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_CONST")]
        KernelArgTypeConst = 0x1,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_RESTRICT")]
        KernelArgTypeRestrict = 0x2,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_VOLATILE")]
        KernelArgTypeVolatile = 0x4,
        [NativeName("Name", "CL_KERNEL_GLOBAL_WORK_SIZE")]
        KernelGlobalWorkSize = 0x11B5,
        [NativeName("Name", "CL_IMAGE_BUFFER")]
        ImageBuffer = 0x1118,
        [NativeName("Name", "CL_INVALID_PIPE_SIZE")]
        InvalidPipeSize = unchecked((int)0xFFFFFFFFFFFFFFBB),
        [NativeName("Name", "CL_INVALID_DEVICE_QUEUE")]
        InvalidDeviceQueue = unchecked((int)0xFFFFFFFFFFFFFFBA),
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
        DeviceQueueOnHostProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
        DeviceImagePitchAlignment = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
        DeviceImageBaseAddressAlignment = 0x104B,
        [NativeName("Name", "CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
        DeviceMaxReadWriteImageArgs = 0x104C,
        [NativeName("Name", "CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
        DeviceMaxGlobalVariableSize = 0x104D,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
        DeviceQueueOnDeviceProperties = 0x104E,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
        DeviceQueueOnDevicePreferredSize = 0x104F,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
        DeviceQueueOnDeviceMaxSize = 0x1050,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
        DeviceMaxOnDeviceQueues = 0x1051,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
        DeviceMaxOnDeviceEvents = 0x1052,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES")]
        DeviceSvmCapabilities = 0x1053,
        [NativeName("Name", "CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
        DeviceGlobalVariablePreferredTotalSize = 0x1054,
        [NativeName("Name", "CL_DEVICE_MAX_PIPE_ARGS")]
        DeviceMaxPipeArgs = 0x1055,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
        DevicePipeMaxActiveReservations = 0x1056,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
        DevicePipeMaxPacketSize = 0x1057,
        [NativeName("Name", "CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
        DevicePreferredPlatformAtomicAlignment = 0x1058,
        [NativeName("Name", "CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
        DevicePreferredGlobalAtomicAlignment = 0x1059,
        [NativeName("Name", "CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
        DevicePreferredLocalAtomicAlignment = 0x105A,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE")]
        QueueOnDevice = 0x4,
        [NativeName("Name", "CL_QUEUE_ON_DEVICE_DEFAULT")]
        QueueOnDeviceDefault = 0x8,
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER")]
        DeviceSvmCoarseGrainBuffer = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER")]
        DeviceSvmFineGrainBuffer = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM")]
        DeviceSvmFineGrainSystem = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS")]
        DeviceSvmAtomics = 0x8,
        [NativeName("Name", "CL_QUEUE_SIZE")]
        QueueSize = 0x1094,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER")]
        MemSvmFineGrainBuffer = 0x1024,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS")]
        MemSvmAtomics = 0x2048,
        [NativeName("Name", "CL_MEM_KERNEL_READ_AND_WRITE")]
        MemKernelReadAndWrite = 0x4096,
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
        [NativeName("Name", "CL_MEM_OBJECT_PIPE")]
        MemObjectPipe = 0x10F7,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER")]
        MemUsesSvmPointer = 0x1109,
        [NativeName("Name", "CL_PIPE_PACKET_SIZE")]
        PipePacketSize = 0x1120,
        [NativeName("Name", "CL_PIPE_MAX_PACKETS")]
        PipeMaxPackets = 0x1121,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE")]
        SamplerMipFilterMode = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN")]
        SamplerLodMin = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX")]
        SamplerLodMax = 0x1157,
        [NativeName("Name", "CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE")]
        ProgramBuildGlobalVariableTotalSize = 0x1185,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_PIPE")]
        KernelArgTypePipe = 0x8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS")]
        KernelExecInfoSvmPtrs = 0x11B6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM")]
        KernelExecInfoSvmFineGrainSystem = 0x11B7,
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
        [NativeName("Name", "CL_PROFILING_COMMAND_COMPLETE")]
        ProfilingCommandComplete = 0x1284,
        [NativeName("Name", "CL_PLATFORM_HOST_TIMER_RESOLUTION")]
        PlatformHostTimerResolution = 0x905,
        [NativeName("Name", "CL_DEVICE_IL_VERSION")]
        DeviceILVersion = 0x105B,
        [NativeName("Name", "CL_DEVICE_MAX_NUM_SUB_GROUPS")]
        DeviceMaxNumSubGroups = 0x105C,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
        DeviceSubGroupIndependentForwardProgress = 0x105D,
        [NativeName("Name", "CL_QUEUE_DEVICE_DEFAULT")]
        QueueDeviceDefault = 0x1095,
        [NativeName("Name", "CL_UNORM_INT_101010_2")]
        UnormInt1010102 = 0x10E0,
        [NativeName("Name", "CL_PROGRAM_IL")]
        ProgramIL = 0x1169,
        [NativeName("Name", "CL_KERNEL_MAX_NUM_SUB_GROUPS")]
        KernelMaxNumSubGroups = 0x11B9,
        [NativeName("Name", "CL_KERNEL_COMPILE_NUM_SUB_GROUPS")]
        KernelCompileNumSubGroups = 0x11BA,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE")]
        KernelMaxSubGroupSizeForNdrange = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE")]
        KernelSubGroupCountForNdrange = 0x2034,
        [NativeName("Name", "CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT")]
        KernelLocalSizeForSubGroupCount = 0x11B8,
        [NativeName("Name", "CL_INVALID_SPEC_ID")]
        InvalidSpecID = unchecked((int)0xFFFFFFFFFFFFFFB9),
        [NativeName("Name", "CL_MAX_SIZE_RESTRICTION_EXCEEDED")]
        MaxSizeRestrictionExceeded = unchecked((int)0xFFFFFFFFFFFFFFB8),
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
        ProgramScopeGlobalCtorsPresent = 0x116A,
        [NativeName("Name", "CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
        ProgramScopeGlobalDtorsPresent = 0x116B,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_RELAXED")]
        DeviceAtomicOrderRelaxed = 0x1,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
        DeviceAtomicOrderAcqRel = 0x2,
        [NativeName("Name", "CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
        DeviceAtomicOrderSeqCst = 0x4,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
        DeviceAtomicScopeWorkItem = 0x8,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
        DeviceAtomicScopeWorkGroup = 0x16,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
        DeviceAtomicScopeDevice = 0x32,
        [NativeName("Name", "CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
        DeviceAtomicScopeAllDevices = 0x64,
        [NativeName("Name", "CL_PLATFORM_NUMERIC_VERSION")]
        PlatformNumericVersion = 0x906,
        [NativeName("Name", "CL_PLATFORM_EXTENSIONS_WITH_VERSION")]
        PlatformExtensionsWithVersion = 0x907,
        [NativeName("Name", "CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
        DeviceAtomicMemoryCapabilities = 0x1063,
        [NativeName("Name", "CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
        DeviceAtomicFenceCapabilities = 0x1064,
        [NativeName("Name", "CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
        DeviceNonUniformWorkGroupSupport = 0x1065,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
        DeviceOpenclCAllVersions = 0x1066,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
        DeviceWorkGroupCollectiveFunctionsSupport = 0x1068,
        [NativeName("Name", "CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
        DeviceGenericAddressSpaceSupport = 0x1069,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_FEATURES")]
        DeviceOpenclCFeatures = 0x106F,
        [NativeName("Name", "CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
        DeviceDeviceEnqueueCapabilities = 0x1070,
        [NativeName("Name", "CL_DEVICE_PIPE_SUPPORT")]
        DevicePipeSupport = 0x1071,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION")]
        DeviceNumericVersion = 0x105E,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION")]
        DeviceExtensionsWithVersion = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION")]
        DeviceIlsWithVersion = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
        DeviceBuiltInKernelsWithVersion = 0x1062,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        DevicePreferredWorkGroupSizeMultiple = 0x1067,
        [NativeName("Name", "CL_PIPE_PROPERTIES")]
        PipeProperties = 0x1122,
        [NativeName("Name", "CL_SAMPLER_PROPERTIES")]
        SamplerProperties = 0x1158,
        [NativeName("Name", "CL_QUEUE_PROPERTIES_ARRAY")]
        QueuePropertiesArray = 0x1098,
        [NativeName("Name", "CL_MEM_PROPERTIES")]
        MemProperties = 0x110A,
        [NativeName("Name", "CL_COMMAND_SVM_MIGRATE_MEM")]
        CommandSvmMigrateMem = 0x120E,
        [NativeName("Name", "CL_VERSION_MAJOR_BITS")]
        VersionMajorBits = 0x10,
        [NativeName("Name", "CL_VERSION_MINOR_BITS")]
        VersionMinorBits = 0x10,
        [NativeName("Name", "CL_VERSION_PATCH_BITS")]
        VersionPatchBits = 0x12,
        [NativeName("Name", "CL_NAME_VERSION_MAX_NAME_SIZE")]
        NameVersionMaxNameSize = 0x64,
        [NativeName("Name", "CL_DEVICE_QUEUE_SUPPORTED")]
        DeviceQueueSupported = 0x1,
        [NativeName("Name", "CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT")]
        DeviceQueueReplaceableDefault = 0x2,
    }
}
