// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_info")]
    public enum DeviceInfo : int
    {
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
        [System.Obsolete("Deprecated in version 1.2")]
        [NativeName("Name", "CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
        DeviceMinDataTypeAlignSize = 0x101A,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_QUEUE_PROPERTIES")]
        DeviceQueueProperties = 0x102A,
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
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_HOST_UNIFIED_MEMORY")]
        DeviceHostUnifiedMemory = 0x1035,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_DEVICE_OPENCL_C_VERSION")]
        DeviceOpenclCVersion = 0x103D,
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
        [NativeName("Name", "CL_DEVICE_IL_VERSION")]
        DeviceILVersion = 0x105B,
        [NativeName("Name", "CL_DEVICE_MAX_NUM_SUB_GROUPS")]
        DeviceMaxNumSubGroups = 0x105C,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
        DeviceSubGroupIndependentForwardProgress = 0x105D,
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
        [NativeName("Name", "CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
        DeviceLatestConformanceVersionPassed = 0x1072,
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        DeviceHalfFPConfig = 0x1033,
        [NativeName("Name", "CL_DEVICE_IL_VERSION_KHR")]
        DeviceILVersionKhr = 0x105B,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
        DeviceImagePitchAlignmentKhr = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
        DeviceImageBaseAddressAlignmentKhr = 0x104B,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
        DeviceTerminateCapabilityKhr = 0x2031,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        DeviceSpirVersions = 0x40E0,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
        DeviceComputeCapabilityMajorNV = 0x4000,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
        DeviceComputeCapabilityMinorNV = 0x4001,
        [NativeName("Name", "CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
        DeviceRegistersPerBlockNV = 0x4002,
        [NativeName("Name", "CL_DEVICE_WARP_SIZE_NV")]
        DeviceWarpSizeNV = 0x4003,
        [NativeName("Name", "CL_DEVICE_GPU_OVERLAP_NV")]
        DeviceGpuOverlapNV = 0x4004,
        [NativeName("Name", "CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
        DeviceKernelExecTimeoutNV = 0x4005,
        [NativeName("Name", "CL_DEVICE_INTEGRATED_MEMORY_NV")]
        DeviceIntegratedMemoryNV = 0x4006,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
        DeviceProfilingTimerOffsetAmd = 0x4036,
        [NativeName("Name", "CL_DEVICE_TOPOLOGY_AMD")]
        DeviceTopologyAmd = 0x4037,
        [NativeName("Name", "CL_DEVICE_BOARD_NAME_AMD")]
        DeviceBoardNameAmd = 0x4038,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
        DeviceGlobalFreeMemoryAmd = 0x4039,
        [NativeName("Name", "CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
        DeviceSimdPerComputeUnitAmd = 0x4040,
        [NativeName("Name", "CL_DEVICE_SIMD_WIDTH_AMD")]
        DeviceSimdWidthAmd = 0x4041,
        [NativeName("Name", "CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
        DeviceSimdInstructionWidthAmd = 0x4042,
        [NativeName("Name", "CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
        DeviceWavefrontWidthAmd = 0x4043,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
        DeviceGlobalMemChannelsAmd = 0x4044,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
        DeviceGlobalMemChannelBanksAmd = 0x4045,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
        DeviceGlobalMemChannelBankWidthAmd = 0x4046,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
        DeviceLocalMemSizePerComputeUnitAmd = 0x4047,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
        DeviceLocalMemBanksAmd = 0x4048,
        [NativeName("Name", "CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
        DeviceThreadTraceSupportedAmd = 0x4049,
        [NativeName("Name", "CL_DEVICE_GFXIP_MAJOR_AMD")]
        DeviceGfxipMajorAmd = 0x404A,
        [NativeName("Name", "CL_DEVICE_GFXIP_MINOR_AMD")]
        DeviceGfxipMinorAmd = 0x404B,
        [NativeName("Name", "CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
        DeviceAvailableAsyncQueuesAmd = 0x404C,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
        DevicePreferredWorkGroupSizeAmd = 0x4030,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
        DeviceMaxWorkGroupSizeAmd = 0x4031,
        [NativeName("Name", "CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
        DevicePreferredConstantBufferSizeAmd = 0x4033,
        [NativeName("Name", "CL_DEVICE_PCIE_ID_AMD")]
        DevicePcieIDAmd = 0x4034,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE_EXT")]
        DeviceParentDeviceExt = 0x4054,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPES_EXT")]
        DevicePartitionTypesExt = 0x4055,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAINS_EXT")]
        DeviceAffinityDomainsExt = 0x4056,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT_EXT")]
        DeviceReferenceCountExt = 0x4057,
        [NativeName("Name", "CL_DEVICE_PARTITION_STYLE_EXT")]
        DevicePartitionStyleExt = 0x4058,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        DeviceExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        DevicePageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        DeviceMaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES_ARM")]
        DeviceSvmCapabilitiesArm = 0x40B6,
        [NativeName("Name", "CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
        DeviceComputeUnitsBitfieldArm = 0x40BF,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        DeviceMEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceSimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        DeviceNumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        DeviceSubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        DevicePlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        DevicePlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        DeviceAvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        DeviceAvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        DeviceAvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        DeviceHostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceDeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceSingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        DeviceCrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        DeviceSharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_UUID_KHR")]
        DeviceUuidKhr = 0x106A,
        [NativeName("Name", "CL_DRIVER_UUID_KHR")]
        DriverUuidKhr = 0x106B,
        [NativeName("Name", "CL_DEVICE_LUID_VALID_KHR")]
        DeviceLuidValidKhr = 0x106C,
        [NativeName("Name", "CL_DEVICE_LUID_KHR")]
        DeviceLuidKhr = 0x106D,
        [NativeName("Name", "CL_DEVICE_NODE_MASK_KHR")]
        DeviceNodeMaskKhr = 0x106E,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        DeviceSchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
        DeviceSupportedRegisterAllocationsArm = 0x41EB,
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        DeviceCxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION_KHR")]
        DeviceNumericVersionKhr = 0x105E,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
        DeviceOpenclCNumericVersionKhr = 0x105F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
        DeviceExtensionsWithVersionKhr = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION_KHR")]
        DeviceIlsWithVersionKhr = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
        DeviceBuiltInKernelsWithVersionKhr = 0x1062,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
        DeviceControlledTerminationCapabilitiesArm = 0x41EE,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        DeviceQueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        DevicePciBusInfoKhr = 0x410F,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        DeviceIPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        DeviceIDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        DeviceNumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        DeviceNumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        DeviceNumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        DeviceNumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        DeviceFeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
        DeviceIntegerDotProductCapabilitiesKhr = 0x1073,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
        DeviceIntegerDotProductAccelerationProperties8BitKhr = 0x1074,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
        DeviceIntegerDotProductAccelerationProperties4x8BitPackedKhr = 0x1075,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_TYPES_KHR")]
        DeviceSemaphoreTypesKhr = 0x204C,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        DeviceSemaphoreImportHandleTypesKhr = 0x204D,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        DeviceSemaphoreExportHandleTypesKhr = 0x204E,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        DeviceExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        DeviceCommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        DeviceCommandBufferRequiredQueuePropertiesKhr = 0x12AA,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceSingleFPAtomicCapabilitiesExt = 0x4231,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceDoubleFPAtomicCapabilitiesExt = 0x4232,
        [NativeName("Name", "CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceHalfFPAtomicCapabilitiesExt = 0x4233,
    }
}
