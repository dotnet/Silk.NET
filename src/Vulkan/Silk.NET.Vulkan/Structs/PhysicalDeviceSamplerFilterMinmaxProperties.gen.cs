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
    [NativeName("Name", "VkPhysicalDeviceSamplerFilterMinmaxProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceSamplerFilterMinmaxProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceSamplerFilterMinmaxProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceSamplerFilterMinmaxProperties,
            void* pNext = null,
            Bool32? filterMinmaxSingleComponentFormats = null,
            Bool32? filterMinmaxImageComponentMapping = null
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

            if (filterMinmaxSingleComponentFormats is not null)
            {
                FilterMinmaxSingleComponentFormats = filterMinmaxSingleComponentFormats.Value;
            }

            if (filterMinmaxImageComponentMapping is not null)
            {
                FilterMinmaxImageComponentMapping = filterMinmaxImageComponentMapping.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filterMinmaxSingleComponentFormats")]
        public Bool32 FilterMinmaxSingleComponentFormats;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "filterMinmaxImageComponentMapping")]
        public Bool32 FilterMinmaxImageComponentMapping;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSamplerFilterMinmaxProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
