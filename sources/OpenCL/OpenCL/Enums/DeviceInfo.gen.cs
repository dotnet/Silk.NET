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
    Type = 4096,

    [NativeName("CL_DEVICE_VENDOR_ID")]
    VendorId = 4097,

    [NativeName("CL_DEVICE_MAX_COMPUTE_UNITS")]
    MaxComputeUnits = 4098,

    [NativeName("CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
    MaxWorkItemDimensions = 4099,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZE")]
    MaxWorkGroupSize = 4100,

    [NativeName("CL_DEVICE_MAX_WORK_ITEM_SIZES")]
    MaxWorkItemSizes = 4101,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZES")]
    MaxWorkGroupSizes = 4101,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
    PreferredVectorWidthChar = 4102,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
    PreferredVectorWidthShort = 4103,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
    PreferredVectorWidthInt = 4104,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
    PreferredVectorWidthLong = 4105,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
    PreferredVectorWidthFloat = 4106,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
    PreferredVectorWidthDouble = 4107,

    [NativeName("CL_DEVICE_MAX_CLOCK_FREQUENCY")]
    MaxClockFrequency = 4108,

    [NativeName("CL_DEVICE_ADDRESS_BITS")]
    AddressBits = 4109,

    [NativeName("CL_DEVICE_MAX_READ_IMAGE_ARGS")]
    MaxReadImageArgs = 4110,

    [NativeName("CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
    MaxWriteImageArgs = 4111,

    [NativeName("CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
    MaxMemAllocSize = 4112,

    [NativeName("CL_DEVICE_IMAGE2D_MAX_WIDTH")]
    Image2DMaxWidth = 4113,

    [NativeName("CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
    Image2DMaxHeight = 4114,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_WIDTH")]
    Image3DMaxWidth = 4115,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
    Image3DMaxHeight = 4116,

    [NativeName("CL_DEVICE_IMAGE3D_MAX_DEPTH")]
    Image3DMaxDepth = 4117,

    [NativeName("CL_DEVICE_IMAGE_SUPPORT")]
    ImageSupport = 4118,

    [NativeName("CL_DEVICE_MAX_PARAMETER_SIZE")]
    MaxParameterSize = 4119,

    [NativeName("CL_DEVICE_MAX_SAMPLERS")]
    MaxSamplers = 4120,

    [NativeName("CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
    MemBaseAddrAlign = 4121,

    [NativeName("CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
    MinDataTypeAlignSize = 4122,

    [NativeName("CL_DEVICE_SINGLE_FP_CONFIG")]
    SingleFpConfig = 4123,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
    GlobalMemCacheType = 4124,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
    GlobalMemCachelineSize = 4125,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
    GlobalMemCacheSize = 4126,

    [NativeName("CL_DEVICE_GLOBAL_MEM_SIZE")]
    GlobalMemSize = 4127,

    [NativeName("CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
    MaxConstantBufferSize = 4128,

    [NativeName("CL_DEVICE_MAX_CONSTANT_ARGS")]
    MaxConstantArgs = 4129,

    [NativeName("CL_DEVICE_LOCAL_MEM_TYPE")]
    LocalMemType = 4130,

    [NativeName("CL_DEVICE_LOCAL_MEM_SIZE")]
    LocalMemSize = 4131,

    [NativeName("CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
    ErrorCorrectionSupport = 4132,

    [NativeName("CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
    ProfilingTimerResolution = 4133,

    [NativeName("CL_DEVICE_ENDIAN_LITTLE")]
    EndianLittle = 4134,

    [NativeName("CL_DEVICE_AVAILABLE")]
    Available = 4135,

    [NativeName("CL_DEVICE_COMPILER_AVAILABLE")]
    CompilerAvailable = 4136,

    [NativeName("CL_DEVICE_EXECUTION_CAPABILITIES")]
    ExecutionCapabilities = 4137,

    [NativeName("CL_DEVICE_QUEUE_PROPERTIES")]
    QueueProperties = 4138,

    [NativeName("CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
    QueueOnHostProperties = 4138,

    [NativeName("CL_DEVICE_NAME")]
    Name = 4139,

    [NativeName("CL_DEVICE_VENDOR")]
    Vendor = 4140,

    [NativeName("CL_DRIVER_VERSION")]
    DriverVersion = 4141,

    [NativeName("CL_DEVICE_PROFILE")]
    Profile = 4142,

    [NativeName("CL_DEVICE_VERSION")]
    Version = 4143,

    [NativeName("CL_DEVICE_EXTENSIONS")]
    Extensions = 4144,

    [NativeName("CL_DEVICE_PLATFORM")]
    Platform = 4145,

    [NativeName("CL_DEVICE_DOUBLE_FP_CONFIG")]
    DoubleFpConfig = 4146,

    [NativeName("CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
    PreferredVectorWidthHalf = 4148,

    [NativeName("CL_DEVICE_HOST_UNIFIED_MEMORY")]
    HostUnifiedMemory = 4149,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
    NativeVectorWidthChar = 4150,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
    NativeVectorWidthShort = 4151,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
    NativeVectorWidthInt = 4152,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
    NativeVectorWidthLong = 4153,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
    NativeVectorWidthFloat = 4154,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
    NativeVectorWidthDouble = 4155,

    [NativeName("CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
    NativeVectorWidthHalf = 4156,

    [NativeName("CL_DEVICE_OPENCL_C_VERSION")]
    OpenclCVersion = 4157,

    [NativeName("CL_DEVICE_LINKER_AVAILABLE")]
    LinkerAvailable = 4158,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS")]
    BuiltInKernels = 4159,

    [NativeName("CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
    ImageMaxBufferSize = 4160,

    [NativeName("CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
    ImageMaxArraySize = 4161,

    [NativeName("CL_DEVICE_PARENT_DEVICE")]
    ParentDevice = 4162,

    [NativeName("CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
    PartitionMaxSubDevices = 4163,

    [NativeName("CL_DEVICE_PARTITION_PROPERTIES")]
    PartitionProperties = 4164,

    [NativeName("CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
    PartitionAffinityDomain = 4165,

    [NativeName("CL_DEVICE_PARTITION_TYPE")]
    PartitionType = 4166,

    [NativeName("CL_DEVICE_REFERENCE_COUNT")]
    ReferenceCount = 4167,

    [NativeName("CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
    PreferredInteropUserSync = 4168,

    [NativeName("CL_DEVICE_PRINTF_BUFFER_SIZE")]
    PrintfBufferSize = 4169,

    [NativeName("CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
    ImagePitchAlignment = 4170,

    [NativeName("CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
    ImageBaseAddressAlignment = 4171,

    [NativeName("CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
    MaxReadWriteImageArgs = 4172,

    [NativeName("CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
    MaxGlobalVariableSize = 4173,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
    QueueOnDeviceProperties = 4174,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
    QueueOnDevicePreferredSize = 4175,

    [NativeName("CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
    QueueOnDeviceMaxSize = 4176,

    [NativeName("CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
    MaxOnDeviceQueues = 4177,

    [NativeName("CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
    MaxOnDeviceEvents = 4178,

    [NativeName("CL_DEVICE_SVM_CAPABILITIES")]
    SvmCapabilities = 4179,

    [NativeName("CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
    GlobalVariablePreferredTotalSize = 4180,

    [NativeName("CL_DEVICE_MAX_PIPE_ARGS")]
    MaxPipeArgs = 4181,

    [NativeName("CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
    PipeMaxActiveReservations = 4182,

    [NativeName("CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
    PipeMaxPacketSize = 4183,

    [NativeName("CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
    PreferredPlatformAtomicAlignment = 4184,

    [NativeName("CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
    PreferredGlobalAtomicAlignment = 4185,

    [NativeName("CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
    PreferredLocalAtomicAlignment = 4186,

    [NativeName("CL_DEVICE_IL_VERSION")]
    IlVersion = 4187,

    [NativeName("CL_DEVICE_MAX_NUM_SUB_GROUPS")]
    MaxNumSubGroups = 4188,

    [NativeName("CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
    SubGroupIndependentForwardProgress = 4189,

    [NativeName("CL_DEVICE_NUMERIC_VERSION")]
    NumericVersion = 4190,

    [NativeName("CL_DEVICE_EXTENSIONS_WITH_VERSION")]
    ExtensionsWithVersion = 4192,

    [NativeName("CL_DEVICE_ILS_WITH_VERSION")]
    IlsWithVersion = 4193,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
    BuiltInKernelsWithVersion = 4194,

    [NativeName("CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
    AtomicMemoryCapabilities = 4195,

    [NativeName("CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
    AtomicFenceCapabilities = 4196,

    [NativeName("CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
    NonUniformWorkGroupSupport = 4197,

    [NativeName("CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
    OpenclCAllVersions = 4198,

    [NativeName("CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
    PreferredWorkGroupSizeMultiple = 4199,

    [NativeName("CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
    WorkGroupCollectiveFunctionsSupport = 4200,

    [NativeName("CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
    GenericAddressSpaceSupport = 4201,

    [NativeName("CL_DEVICE_UUID")]
    Uuid = 4202,

    [NativeName("CL_DRIVER_UUID")]
    DriverUuid = 4203,

    [NativeName("CL_DEVICE_LUID_VALID")]
    LuidValid = 4204,

    [NativeName("CL_DEVICE_LUID")]
    Luid = 4205,

    [NativeName("CL_DEVICE_NODE_MASK")]
    NodeMask = 4206,

    [NativeName("CL_DEVICE_OPENCL_C_FEATURES")]
    OpenclCFeatures = 4207,

    [NativeName("CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
    DeviceEnqueueCapabilities = 4208,

    [NativeName("CL_DEVICE_PIPE_SUPPORT")]
    PipeSupport = 4209,

    [NativeName("CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
    LatestConformanceVersionPassed = 4210,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES")]
    IntegerDotProductCapabilities = 4211,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT")]
    IntegerDotProductAccelerationProperties8Bit = 4212,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED")]
    IntegerDotProductAccelerationProperties4x8BitPacked = 4213,

    [NativeName("CL_DEVICE_SPIRV_EXTENDED_INSTRUCTION_SETS")]
    SpirvExtendedInstructionSets = 4793,

    [NativeName("CL_DEVICE_SPIRV_EXTENSIONS")]
    SpirvExtensions = 4794,

    [NativeName("CL_DEVICE_SPIRV_CAPABILITIES")]
    SpirvCapabilities = 4795,

    [NativeName("CL_DEVICE_HALF_FP_CONFIG")]
    HalfFpConfig = 4147,

    [NativeName("CL_DEVICE_IL_VERSION_KHR")]
    IlVersionKHR = 4187,

    [NativeName("CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
    ImagePitchAlignmentKHR = 4170,

    [NativeName("CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
    ImageBaseAddressAlignmentKHR = 4171,

    [NativeName("CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
    TerminateCapabilityKHR = 8241,

    [NativeName("CL_DEVICE_SPIR_VERSIONS")]
    SpirVersions = 16608,

    [NativeName("CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
    ComputeCapabilityMajorNV = 16384,

    [NativeName("CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
    ComputeCapabilityMinorNV = 16385,

    [NativeName("CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
    RegistersPerBlockNV = 16386,

    [NativeName("CL_DEVICE_WARP_SIZE_NV")]
    WarpSizeNV = 16387,

    [NativeName("CL_DEVICE_GPU_OVERLAP_NV")]
    GpuOverlapNV = 16388,

    [NativeName("CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
    KernelExecTimeoutNV = 16389,

    [NativeName("CL_DEVICE_INTEGRATED_MEMORY_NV")]
    IntegratedMemoryNV = 16390,

    [NativeName("CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
    ProfilingTimerOffsetAMD = 16438,

    [NativeName("CL_DEVICE_TOPOLOGY_AMD")]
    TopologyAMD = 16439,

    [NativeName("CL_DEVICE_BOARD_NAME_AMD")]
    BoardNameAMD = 16440,

    [NativeName("CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
    GlobalFreeMemoryAMD = 16441,

    [NativeName("CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
    SimdPerComputeUnitAMD = 16448,

    [NativeName("CL_DEVICE_SIMD_WIDTH_AMD")]
    SimdWidthAMD = 16449,

    [NativeName("CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
    SimdInstructionWidthAMD = 16450,

    [NativeName("CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
    WavefrontWidthAMD = 16451,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
    GlobalMemChannelsAMD = 16452,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
    GlobalMemChannelBanksAMD = 16453,

    [NativeName("CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
    GlobalMemChannelBankWidthAMD = 16454,

    [NativeName("CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
    LocalMemSizePerComputeUnitAMD = 16455,

    [NativeName("CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
    LocalMemBanksAMD = 16456,

    [NativeName("CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
    ThreadTraceSupportedAMD = 16457,

    [NativeName("CL_DEVICE_GFXIP_MAJOR_AMD")]
    GfxipMajorAMD = 16458,

    [NativeName("CL_DEVICE_GFXIP_MINOR_AMD")]
    GfxipMinorAMD = 16459,

    [NativeName("CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
    AvailableAsyncQueuesAMD = 16460,

    [NativeName("CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
    PreferredWorkGroupSizeAMD = 16432,

    [NativeName("CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
    MaxWorkGroupSizeAMD = 16433,

    [NativeName("CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
    PreferredConstantBufferSizeAMD = 16435,

    [NativeName("CL_DEVICE_PCIE_ID_AMD")]
    PcieIdAMD = 16436,

    [NativeName("CL_DEVICE_PARENT_DEVICE_EXT")]
    ParentDeviceEXT = 16468,

    [NativeName("CL_DEVICE_PARTITION_TYPES_EXT")]
    PartitionTypesEXT = 16469,

    [NativeName("CL_DEVICE_AFFINITY_DOMAINS_EXT")]
    AffinityDomainsEXT = 16470,

    [NativeName("CL_DEVICE_REFERENCE_COUNT_EXT")]
    ReferenceCountEXT = 16471,

    [NativeName("CL_DEVICE_PARTITION_STYLE_EXT")]
    PartitionStyleEXT = 16472,

    [NativeName("CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
    CxxForOpenclNumericVersionEXT = 16944,

    [NativeName("CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
    ExtMemPaddingInBytesQCOM = 16544,

    [NativeName("CL_DEVICE_PAGE_SIZE_QCOM")]
    PageSizeQCOM = 16545,

    [NativeName("CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
    MemoryCapabilitiesIMG = 16600,

    [NativeName("CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
    MaxNamedBarrierCountKHR = 8245,

    [NativeName("CL_DEVICE_NUMERIC_VERSION_KHR")]
    NumericVersionKHR = 4190,

    [NativeName("CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
    OpenclCNumericVersionKHR = 4191,

    [NativeName("CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
    ExtensionsWithVersionKHR = 4192,

    [NativeName("CL_DEVICE_ILS_WITH_VERSION_KHR")]
    IlsWithVersionKHR = 4193,

    [NativeName("CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
    BuiltInKernelsWithVersionKHR = 4194,

    [NativeName("CL_DEVICE_UUID_KHR")]
    UuidKHR = 4202,

    [NativeName("CL_DRIVER_UUID_KHR")]
    DriverUuidKHR = 4203,

    [NativeName("CL_DEVICE_LUID_VALID_KHR")]
    LuidValidKHR = 4204,

    [NativeName("CL_DEVICE_LUID_KHR")]
    LuidKHR = 4205,

    [NativeName("CL_DEVICE_NODE_MASK_KHR")]
    NodeMaskKHR = 4206,

    [NativeName("CL_DEVICE_PCI_BUS_INFO_KHR")]
    PciBusInfoKHR = 16655,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
    IntegerDotProductCapabilitiesKHR = 4211,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
    IntegerDotProductAccelerationProperties8BitKHR = 4212,

    [NativeName("CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
    IntegerDotProductAccelerationProperties4x8BitPackedKHR = 4213,

    [NativeName("CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
    ExternalMemoryImportHandleTypesKHR = 8271,

    [NativeName("CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR")]
    ExternalMemoryImportAssumeLinearImagesHandleTypesKHR = 8274,

    [NativeName("CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
    SemaphoreImportHandleTypesKHR = 8269,

    [NativeName("CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
    SemaphoreExportHandleTypesKHR = 8270,

    [NativeName("CL_DEVICE_SEMAPHORE_TYPES_KHR")]
    SemaphoreTypesKHR = 8268,

    [NativeName("CL_DEVICE_SVM_CAPABILITIES_ARM")]
    SvmCapabilitiesARM = 16566,

    [NativeName("CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
    ComputeUnitsBitfieldARM = 16575,

    [NativeName("CL_DEVICE_JOB_SLOTS_ARM")]
    JobSlotsARM = 16864,

    [NativeName("CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
    SchedulingControlsCapabilitiesARM = 16868,

    [NativeName("CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
    SupportedRegisterAllocationsARM = 16875,

    [NativeName("CL_DEVICE_MAX_WARP_COUNT_ARM")]
    MaxWarpCountARM = 16874,

    [NativeName("CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
    ControlledTerminationCapabilitiesARM = 16878,

    [NativeName("CL_DEVICE_IP_VERSION_INTEL")]
    IpVersionINTEL = 16976,

    [NativeName("CL_DEVICE_ID_INTEL")]
    IdINTEL = 16977,

    [NativeName("CL_DEVICE_NUM_SLICES_INTEL")]
    NumSlicesINTEL = 16978,

    [NativeName("CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
    NumSubSlicesPerSliceINTEL = 16979,

    [NativeName("CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
    NumEusPerSubSliceINTEL = 16980,

    [NativeName("CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
    NumThreadsPerEuINTEL = 16981,

    [NativeName("CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
    FeatureCapabilitiesINTEL = 16982,

    [NativeName("CL_DEVICE_ME_VERSION_INTEL")]
    MeVersionINTEL = 16510,

    [NativeName("CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
    SimultaneousInteropsINTEL = 16644,

    [NativeName("CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
    NumSimultaneousInteropsINTEL = 16645,

    [NativeName("CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
    SubGroupSizesINTEL = 16648,

    [NativeName("CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
    PlanarYuvMaxWidthINTEL = 16766,

    [NativeName("CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
    PlanarYuvMaxHeightINTEL = 16767,

    [NativeName("CL_DEVICE_AVC_ME_VERSION_INTEL")]
    AvcMeVersionINTEL = 16651,

    [NativeName("CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
    AvcMeSupportsTextureSamplerUseINTEL = 16652,

    [NativeName("CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
    AvcMeSupportsPreemptionINTEL = 16653,

    [NativeName("CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
    HostMemCapabilitiesINTEL = 16784,

    [NativeName("CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
    DeviceMemCapabilitiesINTEL = 16785,

    [NativeName("CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
    SingleDeviceSharedMemCapabilitiesINTEL = 16786,

    [NativeName("CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
    CrossDeviceSharedMemCapabilitiesINTEL = 16787,

    [NativeName("CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
    SharedSystemMemCapabilitiesINTEL = 16788,

    [NativeName("CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
    QueueFamilyPropertiesINTEL = 16779,

    [NativeName("CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
    SingleFpAtomicCapabilitiesEXT = 16945,

    [NativeName("CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
    DoubleFpAtomicCapabilitiesEXT = 16946,

    [NativeName("CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
    HalfFpAtomicCapabilitiesEXT = 16947,

    [NativeName("CL_DEVICE_KERNEL_CLOCK_CAPABILITIES_KHR")]
    KernelClockCapabilitiesKHR = 4214,

    [NativeName("CL_DEVICE_SPIRV_EXTENDED_INSTRUCTION_SETS_KHR")]
    SpirvExtendedInstructionSetsKHR = 4793,

    [NativeName("CL_DEVICE_SPIRV_EXTENSIONS_KHR")]
    SpirvExtensionsKHR = 4794,

    [NativeName("CL_DEVICE_SPIRV_CAPABILITIES_KHR")]
    SpirvCapabilitiesKHR = 4795,

    [NativeName("CL_DEVICE_WORKGROUP_PROTECTION_SVM_CAPABILITIES_IMG")]
    WorkgroupProtectionSvmCapabilitiesIMG = 16602,

    [NativeName("CL_DEVICE_WORKGROUP_PROTECTION_DEVICE_ENQUEUE_CAPABILITIES_IMG")]
    WorkgroupProtectionDeviceEnqueueCapabilitiesIMG = 16603,

    [NativeName("CL_DEVICE_SAFETY_MEM_SIZE_IMG")]
    SafetyMemSizeIMG = 16604,
}
