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
    [NativeName("Name", "VkPhysicalDeviceImageProcessingPropertiesQCOM")]
    public unsafe partial struct PhysicalDeviceImageProcessingPropertiesQCOM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceImageProcessingPropertiesQCOM
        (
            StructureType? sType = StructureType.PhysicalDeviceImageProcessingPropertiesQCom,
            void* pNext = null,
            uint? maxWeightFilterPhases = null,
            Extent2D? maxWeightFilterDimension = null,
            Extent2D? maxBlockMatchRegion = null,
            Extent2D? maxBoxFilterBlockSize = null
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

            if (maxWeightFilterPhases is not null)
            {
                MaxWeightFilterPhases = maxWeightFilterPhases.Value;
            }

            if (maxWeightFilterDimension is not null)
            {
                MaxWeightFilterDimension = maxWeightFilterDimension.Value;
            }

            if (maxBlockMatchRegion is not null)
            {
                MaxBlockMatchRegion = maxBlockMatchRegion.Value;
            }

            if (maxBoxFilterBlockSize is not null)
            {
                MaxBoxFilterBlockSize = maxBoxFilterBlockSize.Value;
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
        [NativeName("Name", "maxWeightFilterPhases")]
        public uint MaxWeightFilterPhases;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxWeightFilterDimension")]
        public Extent2D MaxWeightFilterDimension;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxBlockMatchRegion")]
        public Extent2D MaxBlockMatchRegion;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxBoxFilterBlockSize")]
        public Extent2D MaxBoxFilterBlockSize;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceImageProcessingPropertiesQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
