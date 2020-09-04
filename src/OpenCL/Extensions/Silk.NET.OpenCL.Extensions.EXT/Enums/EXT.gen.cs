// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    public enum EXT
    {
        DevicePartitionEquallyExt = 0x4050,
        DevicePartitionByCountsExt = 0x4051,
        DevicePartitionByNamesExt = 0x4052,
        DevicePartitionByAffinityDomainExt = 0x4053,
        DeviceParentDeviceExt = 0x4054,
        DevicePartitionTypesExt = 0x4055,
        DeviceAffinityDomainsExt = 0x4056,
        DeviceReferenceCountExt = 0x4057,
        DevicePartitionStyleExt = 0x4058,
        DevicePartitionFailedExt = unchecked((int)0xFFFFFFFFFFFFFBDF),
        InvalidPartitionCountExt = unchecked((int)0xFFFFFFFFFFFFFBDE),
        InvalidPartitionNameExt = unchecked((int)0xFFFFFFFFFFFFFBDD),
        AffinityDomainL1CacheExt = 0x1,
        AffinityDomainL2CacheExt = 0x2,
        AffinityDomainL3CacheExt = 0x3,
        AffinityDomainL4CacheExt = 0x4,
        AffinityDomainNumaExt = 0x10,
        AffinityDomainNextFissionableExt = 0x100,
        DeviceCxxForOpenclNumericVersionExt = 0x4230,
        MigrateMemObjectHostExt = 0x1,
        CommandMigrateMemObjectExt = 0x4040,
    }
}
