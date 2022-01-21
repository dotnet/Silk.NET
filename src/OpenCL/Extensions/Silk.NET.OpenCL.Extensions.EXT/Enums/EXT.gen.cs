// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [NativeName("Name", "GLenum")]
    public enum EXT : int
    {
        [NativeName("Name", "CL_DEVICE_CXX_FOR_OPENCL_NUMERIC_VERSION_EXT")]
        DeviceCxxForOpenclNumericVersionExt = 0x4230,
        [NativeName("Name", "CL_DEVICE_PARTITION_FAILED_EXT")]
        DevicePartitionFailedExt = unchecked((int)0xFFFFFFFFFFFFFBDF),
        [NativeName("Name", "CL_INVALID_PARTITION_COUNT_EXT")]
        InvalidPartitionCountExt = unchecked((int)0xFFFFFFFFFFFFFBDE),
        [NativeName("Name", "CL_INVALID_PARTITION_NAME_EXT")]
        InvalidPartitionNameExt = unchecked((int)0xFFFFFFFFFFFFFBDD),
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
        [NativeName("Name", "CL_DEVICE_PARTITION_EQUALLY_EXT")]
        DevicePartitionEquallyExt = 0x4050,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_COUNTS_EXT")]
        DevicePartitionByCountsExt = 0x4051,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_NAMES_EXT")]
        DevicePartitionByNamesExt = 0x4052,
        [NativeName("Name", "CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN_EXT")]
        DevicePartitionByAffinityDomainExt = 0x4053,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L1_CACHE_EXT")]
        AffinityDomainL1CacheExt = 0x1,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L2_CACHE_EXT")]
        AffinityDomainL2CacheExt = 0x2,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L3_CACHE_EXT")]
        AffinityDomainL3CacheExt = 0x3,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_L4_CACHE_EXT")]
        AffinityDomainL4CacheExt = 0x4,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NUMA_EXT")]
        AffinityDomainNumaExt = 0x10,
        [NativeName("Name", "CL_AFFINITY_DOMAIN_NEXT_FISSIONABLE_EXT")]
        AffinityDomainNextFissionableExt = 0x100,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceGlobalFPAtomicLoadStoreExt = 0x1,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_ADD_EXT")]
        DeviceGlobalFPAtomicAddExt = 0x2,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceGlobalFPAtomicMinMaxExt = 0x4,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_LOAD_STORE_EXT")]
        DeviceLocalFPAtomicLoadStoreExt = 0x10000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_ADD_EXT")]
        DeviceLocalFPAtomicAddExt = 0x20000,
        [NativeName("Name", "CL_DEVICE_LOCAL_FP_ATOMIC_MIN_MAX_EXT")]
        DeviceLocalFPAtomicMinMaxExt = 0x40000,
        [NativeName("Name", "CL_DEVICE_SINGLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceSingleFPAtomicCapabilitiesExt = 0x4231,
        [NativeName("Name", "CL_DEVICE_DOUBLE_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceDoubleFPAtomicCapabilitiesExt = 0x4232,
        [NativeName("Name", "CL_DEVICE_HALF_FP_ATOMIC_CAPABILITIES_EXT")]
        DeviceHalfFPAtomicCapabilitiesExt = 0x4233,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST_EXT")]
        MigrateMemObjectHostExt = 0x1,
        [NativeName("Name", "CL_COMMAND_MIGRATE_MEM_OBJECT_EXT")]
        CommandMigrateMemObjectExt = 0x4040,
    }
}
