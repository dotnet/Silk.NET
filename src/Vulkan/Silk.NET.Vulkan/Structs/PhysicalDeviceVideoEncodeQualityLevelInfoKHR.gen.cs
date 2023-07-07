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
    [NativeName("Name", "VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR")]
    public unsafe partial struct PhysicalDeviceVideoEncodeQualityLevelInfoKHR : IChainable
    {
        public PhysicalDeviceVideoEncodeQualityLevelInfoKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceVideoEncodeQualityLevelInfoKhr,
            void* pNext = null,
            VideoProfileInfoKHR* pVideoProfile = null,
            uint? qualityLevel = null
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

            if (pVideoProfile is not null)
            {
                PVideoProfile = pVideoProfile;
            }

            if (qualityLevel is not null)
            {
                QualityLevel = qualityLevel.Value;
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
        [NativeName("Type", "VkVideoProfileInfoKHR*")]
        [NativeName("Type.Name", "VkVideoProfileInfoKHR")]
        [NativeName("Name", "pVideoProfile")]
        public VideoProfileInfoKHR* PVideoProfile;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "qualityLevel")]
        public uint QualityLevel;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVideoEncodeQualityLevelInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
