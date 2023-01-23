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
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMapPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceFragmentDensityMapPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceFragmentDensityMapPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt,
            void* pNext = null,
            Extent2D? minFragmentDensityTexelSize = null,
            Extent2D? maxFragmentDensityTexelSize = null,
            Bool32? fragmentDensityInvocations = null
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

            if (minFragmentDensityTexelSize is not null)
            {
                MinFragmentDensityTexelSize = minFragmentDensityTexelSize.Value;
            }

            if (maxFragmentDensityTexelSize is not null)
            {
                MaxFragmentDensityTexelSize = maxFragmentDensityTexelSize.Value;
            }

            if (fragmentDensityInvocations is not null)
            {
                FragmentDensityInvocations = fragmentDensityInvocations.Value;
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
        [NativeName("Name", "minFragmentDensityTexelSize")]
        public Extent2D MinFragmentDensityTexelSize;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxFragmentDensityTexelSize")]
        public Extent2D MaxFragmentDensityTexelSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentDensityInvocations")]
        public Bool32 FragmentDensityInvocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
