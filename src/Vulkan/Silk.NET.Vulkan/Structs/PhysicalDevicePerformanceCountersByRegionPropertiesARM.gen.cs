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
    [NativeName("Name", "VkPhysicalDevicePerformanceCountersByRegionPropertiesARM")]
    public unsafe partial struct PhysicalDevicePerformanceCountersByRegionPropertiesARM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDevicePerformanceCountersByRegionPropertiesARM
        (
            StructureType? sType = StructureType.PhysicalDevicePerformanceCountersByRegionPropertiesArm,
            void* pNext = null,
            uint? maxPerRegionPerformanceCounters = null,
            Extent2D? performanceCounterRegionSize = null,
            uint? rowStrideAlignment = null,
            uint? regionAlignment = null,
            Bool32? identityTransformOrder = null
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

            if (maxPerRegionPerformanceCounters is not null)
            {
                MaxPerRegionPerformanceCounters = maxPerRegionPerformanceCounters.Value;
            }

            if (performanceCounterRegionSize is not null)
            {
                PerformanceCounterRegionSize = performanceCounterRegionSize.Value;
            }

            if (rowStrideAlignment is not null)
            {
                RowStrideAlignment = rowStrideAlignment.Value;
            }

            if (regionAlignment is not null)
            {
                RegionAlignment = regionAlignment.Value;
            }

            if (identityTransformOrder is not null)
            {
                IdentityTransformOrder = identityTransformOrder.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerRegionPerformanceCounters")]
        public uint MaxPerRegionPerformanceCounters;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "performanceCounterRegionSize")]
        public Extent2D PerformanceCounterRegionSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "rowStrideAlignment")]
        public uint RowStrideAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "regionAlignment")]
        public uint RegionAlignment;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "identityTransformOrder")]
        public Bool32 IdentityTransformOrder;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePerformanceCountersByRegionPropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
