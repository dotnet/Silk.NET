// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkClusterAccelerationStructureCommandsInfoNV")]
    public unsafe partial struct ClusterAccelerationStructureCommandsInfoNV : IChainable
    {
        public ClusterAccelerationStructureCommandsInfoNV
        (
            StructureType? sType = StructureType.ClusterAccelerationStructureCommandsInfoNV,
            void* pNext = null,
            ClusterAccelerationStructureInputInfoNV? input = null,
            ulong? dstImplicitData = null,
            ulong? scratchData = null,
            StridedDeviceAddressRegionKHR? dstAddressesArray = null,
            StridedDeviceAddressRegionKHR? dstSizesArray = null,
            StridedDeviceAddressRegionKHR? srcInfosArray = null,
            ulong? srcInfosCount = null,
            ClusterAccelerationStructureAddressResolutionFlagsNV? addressResolutionFlags = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (input is not null)
            {
                Input = input.Value;
            }

            if (dstImplicitData is not null)
            {
                DstImplicitData = dstImplicitData.Value;
            }

            if (scratchData is not null)
            {
                ScratchData = scratchData.Value;
            }

            if (dstAddressesArray is not null)
            {
                DstAddressesArray = dstAddressesArray.Value;
            }

            if (dstSizesArray is not null)
            {
                DstSizesArray = dstSizesArray.Value;
            }

            if (srcInfosArray is not null)
            {
                SrcInfosArray = srcInfosArray.Value;
            }

            if (srcInfosCount is not null)
            {
                SrcInfosCount = srcInfosCount.Value;
            }

            if (addressResolutionFlags is not null)
            {
                AddressResolutionFlags = addressResolutionFlags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureInputInfoNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureInputInfoNV")]
        [NativeName("Name", "input")]
        public ClusterAccelerationStructureInputInfoNV Input;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "dstImplicitData")]
        public ulong DstImplicitData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "scratchData")]
        public ulong ScratchData;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Type.Name", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Name", "dstAddressesArray")]
        public StridedDeviceAddressRegionKHR DstAddressesArray;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Type.Name", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Name", "dstSizesArray")]
        public StridedDeviceAddressRegionKHR DstSizesArray;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Type.Name", "VkStridedDeviceAddressRegionKHR")]
        [NativeName("Name", "srcInfosArray")]
        public StridedDeviceAddressRegionKHR SrcInfosArray;
/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "srcInfosCount")]
        public ulong SrcInfosCount;
/// <summary></summary>
        [NativeName("Type", "VkClusterAccelerationStructureAddressResolutionFlagsNV")]
        [NativeName("Type.Name", "VkClusterAccelerationStructureAddressResolutionFlagsNV")]
        [NativeName("Name", "addressResolutionFlags")]
        public ClusterAccelerationStructureAddressResolutionFlagsNV AddressResolutionFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ClusterAccelerationStructureCommandsInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
