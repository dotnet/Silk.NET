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
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT")]
    [NativeName("Aliases", "VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM")]
    public unsafe partial struct PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentDensityMapOffsetPropertiesExt,
            void* pNext = null,
            Extent2D? fragmentDensityOffsetGranularity = null
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

            if (fragmentDensityOffsetGranularity is not null)
            {
                FragmentDensityOffsetGranularity = fragmentDensityOffsetGranularity.Value;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "fragmentDensityOffsetGranularity")]
        public Extent2D FragmentDensityOffsetGranularity;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFragmentDensityMapOffsetPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
