// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
        L1Cache = 0x1,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
        AffinityDomainL1CacheExt = 0x1,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
        L2Cache = 0x2,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
        AffinityDomainL2CacheExt = 0x2,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
        L3Cache = 0x3,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
        AffinityDomainL3CacheExt = 0x3,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
        L4Cache = 0x4,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
        AffinityDomainL4CacheExt = 0x4,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NUMA_EXT")]
        Numa = 0x10,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NUMA_EXT")]
        AffinityDomainNumaExt = 0x10,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
        NextFissionable = 0x100,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
        AffinityDomainNextFissionableExt = 0x100,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_LOAD_STORE_EXT")]
        GlobalFPAtomicLoadStore = 0x1,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceGlobalFPAtomicLoadStoreExt = 0x1,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_ADD_EXT")]
        GlobalFPAtomicAdd = 0x2,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_ADD_EXT")]
        DeviceGlobalFPAtomicAddExt = 0x2,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_MIN_MAX_EXT")]
        GlobalFPAtomicMinMax = 0x4,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceGlobalFPAtomicMinMaxExt = 0x4,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_LOAD_STORE_EXT")]
        LocalFPAtomicLoadStore = 0x10000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceLocalFPAtomicLoadStoreExt = 0x10000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_ADD_EXT")]
        LocalFPAtomicAdd = 0x20000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_ADD_EXT")]
        DeviceLocalFPAtomicAddExt = 0x20000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_MIN_MAX_EXT")]
        LocalFPAtomicMinMax = 0x40000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceLocalFPAtomicMinMaxExt = 0x40000,
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY_EXT")]
        Equally = 0x4050,
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY_EXT")]
        DevicePartitionEquallyExt = 0x4050,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_EXT")]
        ByCounts = 0x4051,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_EXT")]
        DevicePartitionByCountsExt = 0x4051,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_EXT")]
        ByNames = 0x4052,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_EXT")]
        DevicePartitionByNamesExt = 0x4052,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT")]
        ByAffinityDomain = 0x4053,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT")]
        DevicePartitionByAffinityDomainExt = 0x4053,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_BASE_ADDRESS_ALIGNMENT_EXT")]
        BaseAddressAlignment = 0x1292,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_BASE_ADDRESS_ALIGNMENT_EXT")]
        ImageRequirementsBaseAddressAlignmentExt = 0x1292,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_ROW_PITCH_ALIGNMENT_EXT")]
        RowPitchAlignment = 0x1290,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_ROW_PITCH_ALIGNMENT_EXT")]
        ImageRequirementsRowPitchAlignmentExt = 0x1290,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SIZE_EXT")]
        Size = 0x12B2,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SIZE_EXT")]
        ImageRequirementsSizeExt = 0x12B2,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_WIDTH_EXT")]
        MaxWidth = 0x12B3,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_WIDTH_EXT")]
        ImageRequirementsMaxWidthExt = 0x12B3,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_HEIGHT_EXT")]
        MaxHeight = 0x12B4,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_HEIGHT_EXT")]
        ImageRequirementsMaxHeightExt = 0x12B4,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_DEPTH_EXT")]
        MaxDepth = 0x12B5,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_DEPTH_EXT")]
        ImageRequirementsMaxDepthExt = 0x12B5,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_ARRAY_SIZE_EXT")]
        MaxArraySize = 0x12B6,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_ARRAY_SIZE_EXT")]
        ImageRequirementsMaxArraySizeExt = 0x12B6,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SLICE_PITCH_ALIGNMENT_EXT")]
        SlicePitchAlignment = 0x1291,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SLICE_PITCH_ALIGNMENT_EXT")]
        ImageRequirementsSlicePitchAlignmentExt = 0x1291,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST_EXT")]
        MigrateMemObjectHost = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST_EXT")]
        MigrateMemObjectHostExt = 0x1,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW10_EXT")]
        UnsignedIntRaw10Ext = 0x10E3,
        [NativeName("Name", "CL_UNSIGNED_INT_RAW12_EXT")]
        UnsignedIntRaw12Ext = 0x10E4,
        [NativeName("Name", "CL_UNORM_INT_2_101010_EXT")]
        UnormInt2101010Ext = 0x10E5,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        MigrateMemObjectExt = 0x4040,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        CommandMigrateMemObjectExt = 0x4040,
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
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        CxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        DeviceCxxForOpenclNumericVersionExt = 0x4230,
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
        [NativeName("Name", "CL_DEVICE_PARTITION_FAILED_EXT")]
        DevicePartitionFailedExt = unchecked((int) 0xFFFFFFFFFFFFFBDF),
        [NativeName("Name", "CL_INVALID_PARTITION_COUNT_EXT")]
        InvalidPartitionCountExt = unchecked((int) 0xFFFFFFFFFFFFFBDE),
        [NativeName("Name", "CL_INVALID_PARTITION_NAME_EXT")]
        InvalidPartitionNameExt = unchecked((int) 0xFFFFFFFFFFFFFBDD),
    }
}
