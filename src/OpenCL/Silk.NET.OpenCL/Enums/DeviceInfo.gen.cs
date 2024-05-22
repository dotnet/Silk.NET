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
        Type = 0x1000,
        [NativeName("Name", "CL_DEVICE_VENDOR_ID")]
        VendorID = 0x1001,
        [NativeName("Name", "CL_DEVICE_MAX_COMPUTE_UNITS")]
        MaxComputeUnits = 0x1002,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS")]
        MaxWorkItemDimensions = 0x1003,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE")]
        MaxWorkGroupSize = 0x1004,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_ITEM_SIZES")]
        MaxWorkItemSizes = 0x1005,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR")]
        PreferredVectorWidthChar = 0x1006,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT")]
        PreferredVectorWidthShort = 0x1007,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT")]
        PreferredVectorWidthInt = 0x1008,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG")]
        PreferredVectorWidthLong = 0x1009,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT")]
        PreferredVectorWidthFloat = 0x100A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE")]
        PreferredVectorWidthDouble = 0x100B,
        [NativeName("Name", "CL_DEVICE_MAX_CLOCK_FREQUENCY")]
        MaxClockFrequency = 0x100C,
        [NativeName("Name", "CL_DEVICE_ADDRESS_BITS")]
        AddressBits = 0x100D,
        [NativeName("Name", "CL_DEVICE_MAX_READ_IMAGE_ARGS")]
        MaxReadImageArgs = 0x100E,
        [NativeName("Name", "CL_DEVICE_MAX_WRITE_IMAGE_ARGS")]
        MaxWriteImageArgs = 0x100F,
        [NativeName("Name", "CL_DEVICE_MAX_MEM_ALLOC_SIZE")]
        MaxMemAllocSize = 0x1010,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_WIDTH")]
        Image2DMaxWidth = 0x1011,
        [NativeName("Name", "CL_DEVICE_IMAGE2D_MAX_HEIGHT")]
        Image2DMaxHeight = 0x1012,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_WIDTH")]
        Image3DMaxWidth = 0x1013,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_HEIGHT")]
        Image3DMaxHeight = 0x1014,
        [NativeName("Name", "CL_DEVICE_IMAGE3D_MAX_DEPTH")]
        Image3DMaxDepth = 0x1015,
        [NativeName("Name", "CL_DEVICE_IMAGE_SUPPORT")]
        ImageSupport = 0x1016,
        [NativeName("Name", "CL_DEVICE_MAX_PARAMETER_SIZE")]
        MaxParameterSize = 0x1017,
        [NativeName("Name", "CL_DEVICE_MAX_SAMPLERS")]
        MaxSamplers = 0x1018,
        [NativeName("Name", "CL_DEVICE_MEM_BASE_ADDR_ALIGN")]
        MemBaseAddrAlign = 0x1019,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_CONFIG")]
        SingleFPConfig = 0x101B,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_TYPE")]
        GlobalMemCacheType = 0x101C,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE")]
        GlobalMemCachelineSize = 0x101D,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CACHE_SIZE")]
        GlobalMemCacheSize = 0x101E,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_SIZE")]
        GlobalMemSize = 0x101F,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE")]
        MaxConstantBufferSize = 0x1020,
        [NativeName("Name", "CL_DEVICE_MAX_CONSTANT_ARGS")]
        MaxConstantArgs = 0x1021,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_TYPE")]
        LocalMemType = 0x1022,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE")]
        LocalMemSize = 0x1023,
        [NativeName("Name", "CL_DEVICE_ERROR_CORRECTION_SUPPORT")]
        ErrorCorrectionSupport = 0x1024,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_RESOLUTION")]
        ProfilingTimerResolution = 0x1025,
        [NativeName("Name", "CL_DEVICE_ENDIAN_LITTLE")]
        EndianLittle = 0x1026,
        [NativeName("Name", "CL_DEVICE_AVAILABLE")]
        Available = 0x1027,
        [NativeName("Name", "CL_DEVICE_COMPILER_AVAILABLE")]
        CompilerAvailable = 0x1028,
        [NativeName("Name", "CL_DEVICE_EXECUTION_CAPABILITIES")]
        ExecutionCapabilities = 0x1029,
        [NativeName("Name", "CL_DEVICE_NAME")]
        Name = 0x102B,
        [NativeName("Name", "CL_DEVICE_VENDOR")]
        Vendor = 0x102C,
        [NativeName("Name", "CL_DRIVER_VERSION")]
        DriverVersion = 0x102D,
        [NativeName("Name", "CL_DEVICE_PROFILE")]
        Profile = 0x102E,
        [NativeName("Name", "CL_DEVICE_VERSION")]
        Version = 0x102F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS")]
        Extensions = 0x1030,
        [NativeName("Name", "CL_DEVICE_PLATFORM")]
        Platform = 0x1031,
        [System.Obsolete("Deprecated in version 1.2")]
        [NativeName("Name", "CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE")]
        MinDataTypeAlignSize = 0x101A,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_QUEUE_PROPERTIES")]
        QueueProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF")]
        PreferredVectorWidthHalf = 0x1034,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR")]
        NativeVectorWidthChar = 0x1036,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT")]
        NativeVectorWidthShort = 0x1037,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_INT")]
        NativeVectorWidthInt = 0x1038,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG")]
        NativeVectorWidthLong = 0x1039,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT")]
        NativeVectorWidthFloat = 0x103A,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE")]
        NativeVectorWidthDouble = 0x103B,
        [NativeName("Name", "CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF")]
        NativeVectorWidthHalf = 0x103C,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_DEVICE_HOST_UNIFIED_MEMORY")]
        HostUnifiedMemory = 0x1035,
        [System.Obsolete("Deprecated in version 3.0")]
        [NativeName("Name", "CL_DEVICE_OPENCL_C_VERSION")]
        OpenclCVersion = 0x103D,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_CONFIG")]
        DoubleFPConfig = 0x1032,
        [NativeName("Name", "CL_DEVICE_LINKER_AVAILABLE")]
        LinkerAvailable = 0x103E,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS")]
        BuiltInKernels = 0x103F,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_BUFFER_SIZE")]
        ImageMaxBufferSize = 0x1040,
        [NativeName("Name", "CL_DEVICE_IMAGE_MAX_ARRAY_SIZE")]
        ImageMaxArraySize = 0x1041,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE")]
        ParentDevice = 0x1042,
        [NativeName("Name", "CL_DEVICE_PARTITION_MAX_SUB_DEVICES")]
        PartitionMaxSubDevices = 0x1043,
        [NativeName("Name", "CL_DEVICE_PARTITION_PROPERTIES")]
        PartitionProperties = 0x1044,
        [NativeName("Name", "CL_DEVICE_PARTITION_AFFINITY_DOMAIN")]
        PartitionAffinityDomain = 0x1045,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPE")]
        PartitionType = 0x1046,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT")]
        ReferenceCount = 0x1047,
        [NativeName("Name", "CL_DEVICE_PREFERRED_INTEROP_USER_SYNC")]
        PreferredInteropUserSync = 0x1048,
        [NativeName("Name", "CL_DEVICE_PRINTF_BUFFER_SIZE")]
        PrintfBufferSize = 0x1049,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_HOST_PROPERTIES")]
        QueueOnHostProperties = 0x102A,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT")]
        ImagePitchAlignment = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT")]
        ImageBaseAddressAlignment = 0x104B,
        [NativeName("Name", "CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS")]
        MaxReadWriteImageArgs = 0x104C,
        [NativeName("Name", "CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE")]
        MaxGlobalVariableSize = 0x104D,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES")]
        QueueOnDeviceProperties = 0x104E,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE")]
        QueueOnDevicePreferredSize = 0x104F,
        [NativeName("Name", "CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE")]
        QueueOnDeviceMaxSize = 0x1050,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_QUEUES")]
        MaxOnDeviceQueues = 0x1051,
        [NativeName("Name", "CL_DEVICE_MAX_ON_DEVICE_EVENTS")]
        MaxOnDeviceEvents = 0x1052,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES")]
        SvmCapabilities = 0x1053,
        [NativeName("Name", "CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE")]
        GlobalVariablePreferredTotalSize = 0x1054,
        [NativeName("Name", "CL_DEVICE_MAX_PIPE_ARGS")]
        MaxPipeArgs = 0x1055,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS")]
        PipeMaxActiveReservations = 0x1056,
        [NativeName("Name", "CL_DEVICE_PIPE_MAX_PACKET_SIZE")]
        PipeMaxPacketSize = 0x1057,
        [NativeName("Name", "CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT")]
        PreferredPlatformAtomicAlignment = 0x1058,
        [NativeName("Name", "CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT")]
        PreferredGlobalAtomicAlignment = 0x1059,
        [NativeName("Name", "CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT")]
        PreferredLocalAtomicAlignment = 0x105A,
        [NativeName("Name", "CL_DEVICE_IL_VERSION")]
        ILVersion = 0x105B,
        [NativeName("Name", "CL_DEVICE_MAX_NUM_SUB_GROUPS")]
        MaxNumSubGroups = 0x105C,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS")]
        SubGroupIndependentForwardProgress = 0x105D,
        [NativeName("Name", "CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES")]
        AtomicMemoryCapabilities = 0x1063,
        [NativeName("Name", "CL_DEVICE_ATOMIC_FENCE_CAPABILITIES")]
        AtomicFenceCapabilities = 0x1064,
        [NativeName("Name", "CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT")]
        NonUniformWorkGroupSupport = 0x1065,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_ALL_VERSIONS")]
        OpenclCAllVersions = 0x1066,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT")]
        WorkGroupCollectiveFunctionsSupport = 0x1068,
        [NativeName("Name", "CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT")]
        GenericAddressSpaceSupport = 0x1069,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_FEATURES")]
        OpenclCFeatures = 0x106F,
        [NativeName("Name", "CL_DEVICE_DEVICE_ENQUEUE_CAPABILITIES")]
        DeviceEnqueueCapabilities = 0x1070,
        [NativeName("Name", "CL_DEVICE_PIPE_SUPPORT")]
        PipeSupport = 0x1071,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION")]
        NumericVersion = 0x105E,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION")]
        ExtensionsWithVersion = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION")]
        IlsWithVersion = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION")]
        BuiltInKernelsWithVersion = 0x1062,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        PreferredWorkGroupSizeMultiple = 0x1067,
        [NativeName("Name", "CL_DEVICE_LATEST_CONFORMANCE_VERSION_PASSED")]
        LatestConformanceVersionPassed = 0x1072,
        [NativeName("Name", "CL_DEVICE_HALF_FP_CONFIG")]
        HalfFPConfig = 0x1033,
        [NativeName("Name", "CL_DEVICE_IL_VERSION_KHR")]
        ILVersionKhr = 0x105B,
        [NativeName("Name", "CL_DEVICE_IMAGE_PITCH_ALIGNMENT_KHR")]
        ImagePitchAlignmentKhr = 0x104A,
        [NativeName("Name", "CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT_KHR")]
        ImageBaseAddressAlignmentKhr = 0x104B,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_KHR")]
        TerminateCapabilityKhr = 0x2031,
        [NativeName("Name", "CL_DEVICE_SPIR_VERSIONS")]
        SpirVersions = 0x40E0,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV")]
        ComputeCapabilityMajorNV = 0x4000,
        [NativeName("Name", "CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV")]
        ComputeCapabilityMinorNV = 0x4001,
        [NativeName("Name", "CL_DEVICE_REGISTERS_PER_BLOCK_NV")]
        RegistersPerBlockNV = 0x4002,
        [NativeName("Name", "CL_DEVICE_WARP_SIZE_NV")]
        WarpSizeNV = 0x4003,
        [NativeName("Name", "CL_DEVICE_GPU_OVERLAP_NV")]
        GpuOverlapNV = 0x4004,
        [NativeName("Name", "CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV")]
        KernelExecTimeoutNV = 0x4005,
        [NativeName("Name", "CL_DEVICE_INTEGRATED_MEMORY_NV")]
        IntegratedMemoryNV = 0x4006,
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
        ProfilingTimerOffsetAmd = 0x4036,
        [NativeName("Name", "CL_DEVICE_TOPOLOGY_AMD")]
        TopologyAmd = 0x4037,
        [NativeName("Name", "CL_DEVICE_BOARD_NAME_AMD")]
        BoardNameAmd = 0x4038,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
        GlobalFreeMemoryAmd = 0x4039,
        [NativeName("Name", "CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
        SimdPerComputeUnitAmd = 0x4040,
        [NativeName("Name", "CL_DEVICE_SIMD_WIDTH_AMD")]
        SimdWidthAmd = 0x4041,
        [NativeName("Name", "CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
        SimdInstructionWidthAmd = 0x4042,
        [NativeName("Name", "CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
        WavefrontWidthAmd = 0x4043,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
        GlobalMemChannelsAmd = 0x4044,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
        GlobalMemChannelBanksAmd = 0x4045,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
        GlobalMemChannelBankWidthAmd = 0x4046,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
        LocalMemSizePerComputeUnitAmd = 0x4047,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
        LocalMemBanksAmd = 0x4048,
        [NativeName("Name", "CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
        ThreadTraceSupportedAmd = 0x4049,
        [NativeName("Name", "CL_DEVICE_GFXIP_MAJOR_AMD")]
        GfxipMajorAmd = 0x404A,
        [NativeName("Name", "CL_DEVICE_GFXIP_MINOR_AMD")]
        GfxipMinorAmd = 0x404B,
        [NativeName("Name", "CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
        AvailableAsyncQueuesAmd = 0x404C,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
        PreferredWorkGroupSizeAmd = 0x4030,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
        MaxWorkGroupSizeAmd = 0x4031,
        [NativeName("Name", "CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
        PreferredConstantBufferSizeAmd = 0x4033,
        [NativeName("Name", "CL_DEVICE_PCIE_ID_AMD")]
        PcieIDAmd = 0x4034,
        [NativeName("Name", "CL_DEVICE_PARENT_DEVICE_EXT")]
        ParentDeviceExt = 0x4054,
        [NativeName("Name", "CL_DEVICE_PARTITION_TYPES_EXT")]
        PartitionTypesExt = 0x4055,
        [NativeName("Name", "CL_DEVICE_AFFINITY_DOMAINS_EXT")]
        AffinityDomainsExt = 0x4056,
        [NativeName("Name", "CL_DEVICE_REFERENCE_COUNT_EXT")]
        ReferenceCountExt = 0x4057,
        [NativeName("Name", "CL_DEVICE_PARTITION_STYLE_EXT")]
        PartitionStyleExt = 0x4058,
        [NativeName("Name", "CL_DEVICE_EXT_MEM_PADDING_IN_BYTES_QCOM")]
        ExtMemPaddingInBytesQCom = 0x40A0,
        [NativeName("Name", "CL_DEVICE_PAGE_SIZE_QCOM")]
        PageSizeQCom = 0x40A1,
        [NativeName("Name", "CL_DEVICE_MAX_NAMED_BARRIER_COUNT_KHR")]
        MaxNamedBarrierCountKhr = 0x2035,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES_ARM")]
        SvmCapabilitiesArm = 0x40B6,
        [NativeName("Name", "CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
        ComputeUnitsBitfieldArm = 0x40BF,
        [NativeName("Name", "CL_DEVICE_ME_VERSION_INTEL")]
        MEVersionIntel = 0x407E,
        [NativeName("Name", "CL_DEVICE_SIMULTANEOUS_INTEROPS_INTEL")]
        SimultaneousInteropsIntel = 0x4104,
        [NativeName("Name", "CL_DEVICE_NUM_SIMULTANEOUS_INTEROPS_INTEL")]
        NumSimultaneousInteropsIntel = 0x4105,
        [NativeName("Name", "CL_DEVICE_SUB_GROUP_SIZES_INTEL")]
        SubGroupSizesIntel = 0x4108,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_WIDTH_INTEL")]
        PlanarYuvMaxWidthIntel = 0x417E,
        [NativeName("Name", "CL_DEVICE_PLANAR_YUV_MAX_HEIGHT_INTEL")]
        PlanarYuvMaxHeightIntel = 0x417F,
        [NativeName("Name", "CL_DEVICE_AVC_ME_VERSION_INTEL")]
        AvcMEVersionIntel = 0x410B,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_TEXTURE_SAMPLER_USE_INTEL")]
        AvcMESupportsTextureSamplerUseIntel = 0x410C,
        [NativeName("Name", "CL_DEVICE_AVC_ME_SUPPORTS_PREEMPTION_INTEL")]
        AvcMESupportsPreemptionIntel = 0x410D,
        [NativeName("Name", "CL_DEVICE_HOST_MEM_CAPABILITIES_INTEL")]
        HostMemCapabilitiesIntel = 0x4190,
        [NativeName("Name", "CL_DEVICE_DEVICE_MEM_CAPABILITIES_INTEL")]
        DeviceMemCapabilitiesIntel = 0x4191,
        [NativeName("Name", "CL_DEVICE_SINGLE_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        SingleDeviceSharedMemCapabilitiesIntel = 0x4192,
        [NativeName("Name", "CL_DEVICE_CROSS_DEVICE_SHARED_MEM_CAPABILITIES_INTEL")]
        CrossDeviceSharedMemCapabilitiesIntel = 0x4193,
        [NativeName("Name", "CL_DEVICE_SHARED_SYSTEM_MEM_CAPABILITIES_INTEL")]
        SharedSystemMemCapabilitiesIntel = 0x4194,
        [NativeName("Name", "CL_DEVICE_UUID_KHR")]
        UuidKhr = 0x106A,
        [NativeName("Name", "CL_DRIVER_UUID_KHR")]
        DriverUuidKhr = 0x106B,
        [NativeName("Name", "CL_DEVICE_LUID_VALID_KHR")]
        LuidValidKhr = 0x106C,
        [NativeName("Name", "CL_DEVICE_LUID_KHR")]
        LuidKhr = 0x106D,
        [NativeName("Name", "CL_DEVICE_NODE_MASK_KHR")]
        NodeMaskKhr = 0x106E,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        SchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
        SupportedRegisterAllocationsArm = 0x41EB,
        [NativeName("Name", "CL_DEVICE_MAX_WARP_COUNT_ARM")]
        MaxWarpCountArm = 0x41EA,
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        CxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_NUMERIC_VERSION_KHR")]
        NumericVersionKhr = 0x105E,
        [NativeName("Name", "CL_DEVICE_OPENCL_C_NUMERIC_VERSION_KHR")]
        OpenclCNumericVersionKhr = 0x105F,
        [NativeName("Name", "CL_DEVICE_EXTENSIONS_WITH_VERSION_KHR")]
        ExtensionsWithVersionKhr = 0x1060,
        [NativeName("Name", "CL_DEVICE_ILS_WITH_VERSION_KHR")]
        IlsWithVersionKhr = 0x1061,
        [NativeName("Name", "CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION_KHR")]
        BuiltInKernelsWithVersionKhr = 0x1062,
        [NativeName("Name", "CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
        MemoryCapabilitiesImg = 0x40D8,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
        ControlledTerminationCapabilitiesArm = 0x41EE,
        [NativeName("Name", "CL_DEVICE_QUEUE_FAMILY_PROPERTIES_INTEL")]
        QueueFamilyPropertiesIntel = 0x418B,
        [NativeName("Name", "CL_DEVICE_PCI_BUS_INFO_KHR")]
        PciBusInfoKhr = 0x410F,
        [NativeName("Name", "CL_DEVICE_IP_VERSION_INTEL")]
        IPVersionIntel = 0x4250,
        [NativeName("Name", "CL_DEVICE_ID_INTEL")]
        IDIntel = 0x4251,
        [NativeName("Name", "CL_DEVICE_NUM_SLICES_INTEL")]
        NumSlicesIntel = 0x4252,
        [NativeName("Name", "CL_DEVICE_NUM_SUB_SLICES_PER_SLICE_INTEL")]
        NumSubSlicesPerSliceIntel = 0x4253,
        [NativeName("Name", "CL_DEVICE_NUM_EUS_PER_SUB_SLICE_INTEL")]
        NumEusPerSubSliceIntel = 0x4254,
        [NativeName("Name", "CL_DEVICE_NUM_THREADS_PER_EU_INTEL")]
        NumThreadsPerEUIntel = 0x4255,
        [NativeName("Name", "CL_DEVICE_FEATURE_CAPABILITIES_INTEL")]
        FeatureCapabilitiesIntel = 0x4256,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_CAPABILITIES_KHR")]
        IntegerDotProductCapabilitiesKhr = 0x1073,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_8BIT_KHR")]
        IntegerDotProductAccelerationProperties8BitKhr = 0x1074,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_ACCELERATION_PROPERTIES_4x8BIT_PACKED_KHR")]
        IntegerDotProductAccelerationProperties4x8BitPackedKhr = 0x1075,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_TYPES_KHR")]
        SemaphoreTypesKhr = 0x204C,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_IMPORT_HANDLE_TYPES_KHR")]
        SemaphoreImportHandleTypesKhr = 0x204D,
        [NativeName("Name", "CL_DEVICE_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        SemaphoreExportHandleTypesKhr = 0x204E,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_HANDLE_TYPES_KHR")]
        ExternalMemoryImportHandleTypesKhr = 0x204F,
        [NativeName("Name", "CL_DEVICE_EXTERNAL_MEMORY_IMPORT_ASSUME_LINEAR_IMAGES_HANDLE_TYPES_KHR")]
        ExternalMemoryImportAssumeLinearImagesHandleTypesKhr = 0x2052,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_CAPABILITIES_KHR")]
        CommandBufferCapabilitiesKhr = 0x12A9,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_REQUIRED_QUEUE_PROPERTIES_KHR")]
        CommandBufferRequiredQueuePropertiesKhr = 0x12AA,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
        SingleFPAtomicCapabilitiesExt = 0x4231,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DoubleFPAtomicCapabilitiesExt = 0x4232,
        [NativeName("Name", "CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
        HalfFPAtomicCapabilitiesExt = 0x4233,
        [NativeName("Name", "CL_DEVICE_JOB_SLOTS_ARM")]
        JobSlotsArm = 0x41E0,
        [NativeName("Name", "CL_DEVICE_MUTABLE_DISPATCH_CAPABILITIES_KHR")]
        MutableDispatchCapabilitiesKhr = 0x12B0,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_NUM_SYNC_DEVICES_KHR")]
        CommandBufferNumSyncDevicesKhr = 0x12AB,
        [NativeName("Name", "CL_DEVICE_COMMAND_BUFFER_SYNC_DEVICES_KHR")]
        CommandBufferSyncDevicesKhr = 0x12AC,
        [NativeName("Name", "CL_DEVICE_KERNEL_CLOCK_CAPABILITIES_KHR")]
        KernelClockCapabilitiesKhr = 0x1076,
    }
}
