// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_info")]
public enum DeviceInfo : uint
{
    [NativeName("CL_DEVICE_TYPE")]
    DeviceType = 4096,

    [NativeName("CL_DEVICE_VENDOR_ID")]
    DeviceVendorId = 4097,

    [NativeName("CL_DEVICE_MAX_COMPUTE_UNITS")]
    DeviceMaxComputeUnits = 4098,

    [NativeName("CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
    DeviceMaxWorkItemDimensions = 4099,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZE")]
    DeviceMaxWorkGroupSize = 4100,

    [NativeName("CL_DEVICE_MAX_WORK_ITEM_SIZES")]
    DeviceMaxWorkItemSizes = 4101,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZES")]
    DeviceMaxWorkGroupSizes = 4101,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
    DevicePreferredVectorWidthChar = 4102,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
    DevicePreferredVectorWidthShort = 4103,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
    DevicePreferredVectorWidthInt = 4104,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
    DevicePreferredVectorWidthLong = 4105,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
    DevicePreferredVectorWidthFloat = 4106,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
    DevicePreferredVectorWidthDouble = 4107,

    [NativeName("CL_DEVICE_MAX_CLOCK_FREQUENCY")]
    DeviceMaxClockFrequency = 4108,

    [NativeName("CL_DEVICE_ADDRESS_BITS")]
    DeviceAddressBits = 4109,

    [NativeName("CL_DEVICE_MAX_READ_IMAGE_ARGS")]
    DeviceMaxReadImageArgs = 4110,

    [NativeName("CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
    DeviceMaxWriteImageArgs = 4111,

    [NativeName("CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
    DeviceMaxMemAllocSize = 4112,

    [NativeName("CL_DEVICE_IMAGE2D_MAX_WIDTH")]
    DeviceImage2DMaxWidth = 4113,

    [NativeName("CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
    DeviceImage2DMaxHeight = 4114,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_WIDTH")]
    DeviceImage3DMaxWidth = 4115,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
    DeviceImage3DMaxHeight = 4116,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_DEPTH")]
    DeviceImage3DMaxDepth = 4117,

    [NativeName("CL_DEVICE_IMAGE_SUPPORT")]
    DeviceImageSupport = 4118,

    [NativeName("CL_DEVICE_MAX_PARAMETER_SIZE")]
    DeviceMaxParameterSize = 4119,

    [NativeName("CL_DEVICE_MAX_SAMPLERS")]
    DeviceMaxSamplers = 4120,

    [NativeName("CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
    DeviceMemBaseAddrAlign = 4121,

    [NativeName("CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
    DeviceMinDataTypeAlignSize = 4122,

    [NativeName("CL_DEVICE_SINGLE_FP_CONFIG")]
    DeviceSingleFpConfig = 4123,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
    DeviceGlobalMemCacheType = 4124,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
    DeviceGlobalMemCachelineSize = 4125,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
    DeviceGlobalMemCacheSize = 4126,

    [NativeName("CL_DEVICE_GLOBAL_MEM_SIZE")]
    DeviceGlobalMemSize = 4127,

    [NativeName("CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
    DeviceMaxConstantBufferSize = 4128,

    [NativeName("CL_DEVICE_MAX_CONSTANT_ARGS")]
    DeviceMaxConstantArgs = 4129,

    [NativeName("CL_DEVICE_LOCAL_MEM_TYPE")]
    DeviceLocalMemType = 4130,

    [NativeName("CL_DEVICE_LOCAL_MEM_SIZE")]
    DeviceLocalMemSize = 4131,

    [NativeName("CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
    DeviceErrorCorrectionSupport = 4132,

    [NativeName("CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
    DeviceProfilingTimerResolution = 4133,

    [NativeName("CL_DEVICE_ENDIAN_LITTLE")]
    DeviceEndianLittle = 4134,

    [NativeName("CL_DEVICE_AVAILABLE")]
    DeviceAvailable = 4135,

    [NativeName("CL_DEVICE_COMPILER_AVAILABLE")]
    DeviceCompilerAvailable = 4136,

    [NativeName("CL_DEVICE_EXECUTION_CAPABILITIES")]
    DeviceExecutionCapabilities = 4137,

    [NativeName("CL_DEVICE_QUEUE_PROPERTIES")]
    DeviceQueueProperties = 4138,

    [NativeName("CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
    DeviceQueueOnHostProperties = 4138,

    [NativeName("CL_DEVICE_NAME")]
    DeviceName = 4139,

    [NativeName("CL_DEVICE_VENDOR")]
    DeviceVendor = 4140,

    [NativeName("CL_DRIVER_VERSION")]
    DriverVersion = 4141,

    [NativeName("CL_DEVICE_PROFILE")]
    DeviceProfile = 4142,

    [NativeName("CL_DEVICE_VERSION")]
    DeviceVersion = 4143,

    [NativeName("CL_DEVICE_EXTENSIONS")]
    DeviceExtensions = 4144,

    [NativeName("CL_DEVICE_PLATFORM")]
    DevicePlatform = 4145,

    [NativeName("CL_DEVICE_DOUBLE_FP_CONFIG")]
    DeviceDoubleFpConfig = 4146,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
    DevicePreferredVectorWidthHalf = 4148,

    [NativeName("CL_DEVICE_HOST_UNIFIED_MEMORY")]
    DeviceHostUnifiedMemory = 4149,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
    DeviceNativeVectorWidthChar = 4150,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
    DeviceNativeVectorWidthShort = 4151,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
    DeviceNativeVectorWidthInt = 4152,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
    DeviceNativeVectorWidthLong = 4153,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
    DeviceNativeVectorWidthFloat = 4154,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
    DeviceNativeVectorWidthDouble = 4155,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
    DeviceNativeVectorWidthHalf = 4156,

    [NativeName("CL_DEVICE_OPENCL_C_VERSION")]
    DeviceOpenclCVersion = 4157,

    [NativeName("CL_DEVICE_LINKER_AVAILABLE")]
    DeviceLinkerAvailable = 4158,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS")]
    DeviceBuiltInKernels = 4159,

    [NativeName("CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
    DeviceImageMaxBufferSize = 4160,

    [NativeName("CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
    DeviceImageMaxArraySize = 4161,

    [NativeName("CL_DEVICE_PARENT_DEVICE")]
    DeviceParentDevice = 4162,

    [NativeName("CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
    DevicePartitionMaxSubDevices = 4163,

    [NativeName("CL_DEVICE_PARTITION_PROPERTIES")]
    DevicePartitionProperties = 4164,

    [NativeName("CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
    DevicePartitionAffinityDomain = 4165,

    [NativeName("CL_DEVICE_PARTITION_TYPE")]
    DevicePartitionType = 4166,

    [NativeName("CL_DEVICE_REFERENCE_COUNT")]
    DeviceReferenceCount = 4167,

    [NativeName("CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
    DevicePreferredInteropUserSync = 4168,

    [NativeName("CL_DEVICE_PRINTF_BUFFER_SIZE")]
    DevicePrintfBufferSize = 4169,

    [NativeName("CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
    DeviceImagePitchAlignment = 4170,

    [NativeName("CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
    DeviceImageBaseAddressAlignment = 4171,

    [NativeName("CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
    DeviceMaxReadWriteImageArgs = 4172,

    [NativeName("CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
    DeviceMaxGlobalVariableSize = 4173,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
    DeviceQueueOnDeviceProperties = 4174,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
    DeviceQueueOnDevicePreferredSize = 4175,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
    DeviceQueueOnDeviceMaxSize = 4176,

    [NativeName("CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
    DeviceMaxOnDeviceQueues = 4177,

    [NativeName("CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
    DeviceMaxOnDeviceEvents = 4178,

    [NativeName("CL_DEVICE_SVM_CAPABILITIES")]
    DeviceSvmCapabilities = 4179,

    [NativeName("CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
    DeviceGlobalVariablePreferredTotalSize = 4180,

    [NativeName("CL_DEVICE_MAX_PIPE_ARGS")]
    DeviceMaxPipeArgs = 4181,

    [NativeName("CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
    DevicePipeMaxActiveReservations = 4182,

    [NativeName("CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
    DevicePipeMaxPacketSize = 4183,

    [NativeName("CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
    DevicePreferredPlatformAtomicAlignment = 4184,

    [NativeName("CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
    DevicePreferredGlobalAtomicAlignment = 4185,

    [NativeName("CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
    DevicePreferredLocalAtomicAlignment = 4186,

    [NativeName("CL_DEVICE_IL_VERSION")]
    DeviceIlVersion = 4187,

    [NativeName("CL_DEVICE_MAX_NUM_SUB_GROUPS")]
    DeviceMaxNumSubGroups = 4188,

    [NativeName("CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
    DeviceSubGroupIndependentForwardProgress = 4189,

    [NativeName("CL_DEVICE_NUMERIC_VERSION")]
    DeviceNumericVersion = 4190,

    [NativeName("CL_DEVICE_EXTENSIONS_WITH_VERSION")]
    DeviceExtensionsWithVersion = 4192,

    [NativeName("CL_DEVICE_ILS_WITH_VERSION")]
    DeviceIlsWithVersion = 4193,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
    DeviceBuiltInKernelsWithVersion = 4194,

    [NativeName("CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
    DeviceAtomicMemoryCapabilities = 4195,

    [NativeName("CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
    DeviceAtomicFenceCapabilities = 4196,

    [NativeName("CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
    DeviceNonUniformWorkGroupSupport = 4197,

    [NativeName("CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
    DeviceOpenclCAllVersions = 4198,

    [NativeName("CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
    DevicePreferredWorkGroupSizeMultiple = 4199,

    [NativeName("CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
    DeviceWorkGroupCollectiveFunctionsSupport = 4200,

    [NativeName("CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
    DeviceGenericAddressSpaceSupport = 4201,

    [NativeName("CL_DEVICE_UUID")]
    DeviceUuid = 4202,

    [NativeName("CL_DRIVER_UUID")]
    DriverUuid = 4203,

    [NativeName("CL_DEVICE_LUID_VALID")]
    DeviceLuidValid = 4204,

    [NativeName("CL_DEVICE_LUID")]
    DeviceLuid = 4205,

    [NativeName("CL_DEVICE_NODE_MASK")]
    DeviceNodeMask = 4206,

    [NativeName("CL_DEVICE_OPENCL_C_FEATURES")]
    DeviceOpenclCFeatures = 4207,

    [NativeName("CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
    DeviceDeviceEnqueueCapabilities = 4208,

    [NativeName("CL_DEVICE_PIPE_SUPPORT")]
    DevicePipeSupport = 4209,

    [NativeName("CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
    DeviceLatestConformanceVersionPassed = 4210,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES")]
    DeviceIntegerDotProductCapabilities = 4211,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT")]
    DeviceIntegerDotProductAccelerationProperties8Bit = 4212,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED")]
    DeviceIntegerDotProductAccelerationProperties4x8BitPacked = 4213,

    [NativeName("CL_DEVICE_SPIRV_EXTENDED_INSTRUCTION_SETS")]
    DeviceSpirvExtendedInstructionSets = 4793,

    [NativeName("CL_DEVICE_SPIRV_EXTENSIONS")]
    DeviceSpirvExtensions = 4794,

    [NativeName("CL_DEVICE_SPIRV_CAPABILITIES")]
    DeviceSpirvCapabilities = 4795,

    [NativeName("CL_DEVICE_HALF_FP_CONFIG")]
    DeviceHalfFpConfig = 4147,

    [NativeName("CL_DEVICE_IL_VERSION_KHR")]
    DeviceIlVersionKHR = 4187,

    [NativeName("CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
    DeviceImagePitchAlignmentKHR = 4170,

    [NativeName("CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
    DeviceImageBaseAddressAlignmentKHR = 4171,

    [NativeName("CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
    DeviceTerminateCapabilityKHR = 8241,

    [NativeName("CL_DEVICE_SPIR_VERSIONS")]
    DeviceSpirVersions = 16608,

    [NativeName("CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
    DeviceComputeCapabilityMajorNV = 16384,

    [NativeName("CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
    DeviceComputeCapabilityMinorNV = 16385,

    [NativeName("CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
    DeviceRegistersPerBlockNV = 16386,

    [NativeName("CL_DEVICE_WARP_SIZE_NV")]
    DeviceWarpSizeNV = 16387,

    [NativeName("CL_DEVICE_GPU_OVERLAP_NV")]
    DeviceGpuOverlapNV = 16388,

    [NativeName("CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
    DeviceKernelExecTimeoutNV = 16389,

    [NativeName("CL_DEVICE_INTEGRATED_MEMORY_NV")]
    DeviceIntegratedMemoryNV = 16390,

    [NativeName("CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
    DeviceProfilingTimerOffsetAMD = 16438,

    [NativeName("CL_DEVICE_TOPOLOGY_AMD")]
    DeviceTopologyAMD = 16439,

    [NativeName("CL_DEVICE_BOARD_NAME_AMD")]
    DeviceBoardNameAMD = 16440,

    [NativeName("CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
    DeviceGlobalFreeMemoryAMD = 16441,

    [NativeName("CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
    DeviceSimdPerComputeUnitAMD = 16448,

    [NativeName("CL_DEVICE_SIMD_WIDTH_AMD")]
    DeviceSimdWidthAMD = 16449,

    [NativeName("CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
    DeviceSimdInstructionWidthAMD = 16450,

    [NativeName("CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
    DeviceWavefrontWidthAMD = 16451,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
    DeviceGlobalMemChannelsAMD = 16452,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
    DeviceGlobalMemChannelBanksAMD = 16453,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
    DeviceGlobalMemChannelBankWidthAMD = 16454,

    [NativeName("CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
    DeviceLocalMemSizePerComputeUnitAMD = 16455,

    [NativeName("CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
    DeviceLocalMemBanksAMD = 16456,

    [NativeName("CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
    DeviceThreadTraceSupportedAMD = 16457,

    [NativeName("CL_DEVICE_GFXIP_MAJOR_AMD")]
    DeviceGfxipMajorAMD = 16458,

    [NativeName("CL_DEVICE_GFXIP_MINOR_AMD")]
    DeviceGfxipMinorAMD = 16459,

    [NativeName("CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
    DeviceAvailableAsyncQueuesAMD = 16460,

    [NativeName("CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
    DevicePreferredWorkGroupSizeAMD = 16432,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
    DeviceMaxWorkGroupSizeAMD = 16433,

    [NativeName("CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
    DevicePreferredConstantBufferSizeAMD = 16435,

    [NativeName("CL_DEVICE_PCIE_ID_AMD")]
    DevicePcieIdAMD = 16436,

    [NativeName("CL_DEVICE_PARENT_DEVICE_EXT")]
    DeviceParentDeviceEXT = 16468,

    [NativeName("CL_DEVICE_PARTITION_TYPES_EXT")]
    DevicePartitionTypesEXT = 16469,

    [NativeName("CL_DEVICE_AFFINITY_DOMAINS_EXT")]
    DeviceAffinityDomainsEXT = 16470,

    [NativeName("CL_DEVICE_REFERENCE_COUNT_EXT")]
    DeviceReferenceCountEXT = 16471,

    [NativeName("CL_DEVICE_PARTITION_STYLE_EXT")]
    DevicePartitionStyleEXT = 16472,

    [NativeName("CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
    DeviceCxxForOpenclNumericVersionEXT = 16944,

    [NativeName("CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
    DeviceExtMemPaddingInBytesQCOM = 16544,

    [NativeName("CL_DEVICE_PAGE_SIZE_QCOM")]
    DevicePageSizeQCOM = 16545,

    [NativeName("CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
    DeviceMemoryCapabilitiesIMG = 16600,

    [NativeName("CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
    DeviceMaxNamedBarrierCountKHR = 8245,

    [NativeName("CL_DEVICE_NUMERIC_VERSION_KHR")]
    DeviceNumericVersionKHR = 4190,

    [NativeName("CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
    DeviceOpenclCNumericVersionKHR = 4191,

    [NativeName("CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
    DeviceExtensionsWithVersionKHR = 4192,

    [NativeName("CL_DEVICE_ILS_WITH_VERSION_KHR")]
    DeviceIlsWithVersionKHR = 4193,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
    DeviceBuiltInKernelsWithVersionKHR = 4194,

    [NativeName("CL_DEVICE_UUID_KHR")]
    DeviceUuidKHR = 4202,

    [NativeName("CL_DRIVER_UUID_KHR")]
    DriverUuidKHR = 4203,

    [NativeName("CL_DEVICE_LUID_VALID_KHR")]
    DeviceLuidValidKHR = 4204,

    [NativeName("CL_DEVICE_LUID_KHR")]
    DeviceLuidKHR = 4205,

    [NativeName("CL_DEVICE_NODE_MASK_KHR")]
    DeviceNodeMaskKHR = 4206,

    [NativeName("CL_DEVICE_PCI_BUS_INFO_KHR")]
    DevicePciBusInfoKHR = 16655,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
    DeviceIntegerDotProductCapabilitiesKHR = 4211,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
    DeviceIntegerDotProductAccelerationProperties8BitKHR = 4212,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
    DeviceIntegerDotProductAccelerationProperties4x8BitPackedKHR = 4213,

    [NativeName("CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
    DeviceExternalMemoryImportHandleTypesKHR = 8271,

    [NativeName("CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR")]
    DeviceExternalMemoryImportAssumeLinearImagesHandleTypesKHR = 8274,

    [NativeName("CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
    DeviceSemaphoreImportHandleTypesKHR = 8269,

    [NativeName("CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
    DeviceSemaphoreExportHandleTypesKHR = 8270,

    [NativeName("CL_DEVICE_SEMAPHORE_TYPES_KHR")]
    DeviceSemaphoreTypesKHR = 8268,

    [NativeName("CL_DEVICE_SVM_CAPABILITIES_ARM")]
    DeviceSvmCapabilitiesARM = 16566,

    [NativeName("CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
    DeviceComputeUnitsBitfieldARM = 16575,

    [NativeName("CL_DEVICE_JOB_SLOTS_ARM")]
    DeviceJobSlotsARM = 16864,

    [NativeName("CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
    DeviceSchedulingControlsCapabilitiesARM = 16868,

    [NativeName("CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
    DeviceSupportedRegisterAllocationsARM = 16875,

    [NativeName("CL_DEVICE_MAX_WARP_COUNT_ARM")]
    DeviceMaxWarpCountARM = 16874,

    [NativeName("CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
    DeviceControlledTerminationCapabilitiesARM = 16878,

    [NativeName("CL_DEVICE_IP_VERSION_INTEL")]
    DeviceIpVersionINTEL = 16976,

    [NativeName("CL_DEVICE_ID_INTEL")]
    DeviceIdINTEL = 16977,

    [NativeName("CL_DEVICE_NUM_SLICES_INTEL")]
    DeviceNumSlicesINTEL = 16978,

    [NativeName("CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
    DeviceNumSubSlicesPerSliceINTEL = 16979,

    [NativeName("CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
    DeviceNumEusPerSubSliceINTEL = 16980,

    [NativeName("CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
    DeviceNumThreadsPerEuINTEL = 16981,

    [NativeName("CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
    DeviceFeatureCapabilitiesINTEL = 16982,

    [NativeName("CL_DEVICE_ME_VERSION_INTEL")]
    DeviceMeVersionINTEL = 16510,

    [NativeName("CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
    DeviceSimultaneousInteropsINTEL = 16644,

    [NativeName("CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
    DeviceNumSimultaneousInteropsINTEL = 16645,

    [NativeName("CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
    DeviceSubGroupSizesINTEL = 16648,

    [NativeName("CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
    DevicePlanarYuvMaxWidthINTEL = 16766,

    [NativeName("CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
    DevicePlanarYuvMaxHeightINTEL = 16767,

    [NativeName("CL_DEVICE_AVC_ME_VERSION_INTEL")]
    DeviceAvcMeVersionINTEL = 16651,

    [NativeName("CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
    DeviceAvcMeSupportsTextureSamplerUseINTEL = 16652,

    [NativeName("CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
    DeviceAvcMeSupportsPreemptionINTEL = 16653,

    [NativeName("CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
    DeviceHostMemCapabilitiesINTEL = 16784,

    [NativeName("CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
    DeviceDeviceMemCapabilitiesINTEL = 16785,

    [NativeName("CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
    DeviceSingleDeviceSharedMemCapabilitiesINTEL = 16786,

    [NativeName("CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
    DeviceCrossDeviceSharedMemCapabilitiesINTEL = 16787,

    [NativeName("CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
    DeviceSharedSystemMemCapabilitiesINTEL = 16788,

    [NativeName("CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
    DeviceQueueFamilyPropertiesINTEL = 16779,

    [NativeName("CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
    DeviceSingleFpAtomicCapabilitiesEXT = 16945,

    [NativeName("CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
    DeviceDoubleFpAtomicCapabilitiesEXT = 16946,

    [NativeName("CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
    DeviceHalfFpAtomicCapabilitiesEXT = 16947,

    [NativeName("CL_DEVICE_KERNEL_CLOCK_CAPABILITIES_KHR")]
    DeviceKernelClockCapabilitiesKHR = 4214,

    [NativeName("CL_DEVICE_SPIRV_EXTENDED_INSTRUCTION_SETS_KHR")]
    DeviceSpirvExtendedInstructionSetsKHR = 4793,

    [NativeName("CL_DEVICE_SPIRV_EXTENSIONS_KHR")]
    DeviceSpirvExtensionsKHR = 4794,

    [NativeName("CL_DEVICE_SPIRV_CAPABILITIES_KHR")]
    DeviceSpirvCapabilitiesKHR = 4795,

    [NativeName("CL_DEVICE_WORKGROUP_PROTECTION_SVM_CAPABILITIES_IMG")]
    DeviceWorkgroupProtectionSvmCapabilitiesIMG = 16602,

    [NativeName("CL_DEVICE_WORKGROUP_PROTECTION_DEVICE_ENQUEUE_CAPABILITIES_IMG")]
    DeviceWorkgroupProtectionDeviceEnqueueCapabilitiesIMG = 16603,

    [NativeName("CL_DEVICE_SAFETY_MEM_SIZE_IMG")]
    DeviceSafetyMemSizeIMG = 16604,
}
