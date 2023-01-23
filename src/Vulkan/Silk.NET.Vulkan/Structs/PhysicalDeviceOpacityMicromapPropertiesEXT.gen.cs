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
    [NativeName("Name", "VkPhysicalDeviceOpacityMicromapPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceOpacityMicromapPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceOpacityMicromapPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceOpacityMicromapPropertiesExt,
            void* pNext = null,
            uint? maxOpacity2StateSubdivisionLevel = null,
            uint? maxOpacity4StateSubdivisionLevel = null
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

            if (maxOpacity2StateSubdivisionLevel is not null)
            {
                MaxOpacity2StateSubdivisionLevel = maxOpacity2StateSubdivisionLevel.Value;
            }

            if (maxOpacity4StateSubdivisionLevel is not null)
            {
                MaxOpacity4StateSubdivisionLevel = maxOpacity4StateSubdivisionLevel.Value;
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
        [NativeName("Name", "maxOpacity2StateSubdivisionLevel")]
        public uint MaxOpacity2StateSubdivisionLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxOpacity4StateSubdivisionLevel")]
        public uint MaxOpacity4StateSubdivisionLevel;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceOpacityMicromapPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
