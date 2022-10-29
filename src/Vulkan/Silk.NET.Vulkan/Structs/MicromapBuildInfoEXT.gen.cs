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
    [NativeName("Name", "VkMicromapBuildInfoEXT")]
    public unsafe partial struct MicromapBuildInfoEXT : IChainable
    {
        public MicromapBuildInfoEXT
        (
            StructureType? sType = StructureType.MicromapBuildInfoExt,
            void* pNext = null,
            MicromapTypeEXT? type = null,
            BuildMicromapFlagsEXT? flags = null,
            BuildMicromapModeEXT? mode = null,
            MicromapEXT? dstMicromap = null,
            uint? usageCountsCount = null,
            MicromapUsageEXT* pUsageCounts = null,
            MicromapUsageEXT** ppUsageCounts = null,
            DeviceOrHostAddressConstKHR? data = null,
            DeviceOrHostAddressKHR? scratchData = null,
            DeviceOrHostAddressConstKHR? triangleArray = null,
            ulong? triangleArrayStride = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (dstMicromap is not null)
            {
                DstMicromap = dstMicromap.Value;
            }

            if (usageCountsCount is not null)
            {
                UsageCountsCount = usageCountsCount.Value;
            }

            if (pUsageCounts is not null)
            {
                PUsageCounts = pUsageCounts;
            }

            if (ppUsageCounts is not null)
            {
                PpUsageCounts = ppUsageCounts;
            }

            if (data is not null)
            {
                Data = data.Value;
            }

            if (scratchData is not null)
            {
                ScratchData = scratchData.Value;
            }

            if (triangleArray is not null)
            {
                TriangleArray = triangleArray.Value;
            }

            if (triangleArrayStride is not null)
            {
                TriangleArrayStride = triangleArrayStride.Value;
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
        [NativeName("Type", "VkMicromapTypeEXT")]
        [NativeName("Type.Name", "VkMicromapTypeEXT")]
        [NativeName("Name", "type")]
        public MicromapTypeEXT Type;
/// <summary></summary>
        [NativeName("Type", "VkBuildMicromapFlagsEXT")]
        [NativeName("Type.Name", "VkBuildMicromapFlagsEXT")]
        [NativeName("Name", "flags")]
        public BuildMicromapFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkBuildMicromapModeEXT")]
        [NativeName("Type.Name", "VkBuildMicromapModeEXT")]
        [NativeName("Name", "mode")]
        public BuildMicromapModeEXT Mode;
/// <summary></summary>
        [NativeName("Type", "VkMicromapEXT")]
        [NativeName("Type.Name", "VkMicromapEXT")]
        [NativeName("Name", "dstMicromap")]
        public MicromapEXT DstMicromap;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "usageCountsCount")]
        public uint UsageCountsCount;
/// <summary></summary>
        [NativeName("Type", "VkMicromapUsageEXT*")]
        [NativeName("Type.Name", "VkMicromapUsageEXT")]
        [NativeName("Name", "pUsageCounts")]
        public MicromapUsageEXT* PUsageCounts;
/// <summary></summary>
        [NativeName("Type", "VkMicromapUsageEXT**")]
        [NativeName("Type.Name", "VkMicromapUsageEXT")]
        [NativeName("Name", "ppUsageCounts")]
        public MicromapUsageEXT** PpUsageCounts;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "data")]
        public DeviceOrHostAddressConstKHR Data;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressKHR")]
        [NativeName("Name", "scratchData")]
        public DeviceOrHostAddressKHR ScratchData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "triangleArray")]
        public DeviceOrHostAddressConstKHR TriangleArray;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "triangleArrayStride")]
        public ulong TriangleArrayStride;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MicromapBuildInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
