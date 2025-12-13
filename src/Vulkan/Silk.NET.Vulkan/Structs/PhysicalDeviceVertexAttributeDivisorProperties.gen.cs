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
    [NativeName("Name", "VkPhysicalDeviceVertexAttributeDivisorProperties")]
    [NativeName("Aliases", "VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceVertexAttributeDivisorProperties : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceVertexAttributeDivisorProperties
        (
            StructureType? sType = StructureType.PhysicalDeviceVertexAttributeDivisorProperties,
            void* pNext = null,
            uint? maxVertexAttribDivisor = null,
            Bool32? supportsNonZeroFirstInstance = null
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

            if (maxVertexAttribDivisor is not null)
            {
                MaxVertexAttribDivisor = maxVertexAttribDivisor.Value;
            }

            if (supportsNonZeroFirstInstance is not null)
            {
                SupportsNonZeroFirstInstance = supportsNonZeroFirstInstance.Value;
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
        [NativeName("Name", "maxVertexAttribDivisor")]
        public uint MaxVertexAttribDivisor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "supportsNonZeroFirstInstance")]
        public Bool32 SupportsNonZeroFirstInstance;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVertexAttributeDivisorProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
