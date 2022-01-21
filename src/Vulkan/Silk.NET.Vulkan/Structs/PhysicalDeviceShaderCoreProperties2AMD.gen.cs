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
    [NativeName("Name", "VkPhysicalDeviceShaderCoreProperties2AMD")]
    public unsafe partial struct PhysicalDeviceShaderCoreProperties2AMD : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShaderCoreProperties2AMD
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderCoreProperties2Amd,
            void* pNext = null,
            ShaderCorePropertiesFlagsAMD? shaderCoreFeatures = null,
            uint? activeComputeUnitCount = null
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

            if (shaderCoreFeatures is not null)
            {
                ShaderCoreFeatures = shaderCoreFeatures.Value;
            }

            if (activeComputeUnitCount is not null)
            {
                ActiveComputeUnitCount = activeComputeUnitCount.Value;
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
        [NativeName("Type", "VkShaderCorePropertiesFlagsAMD")]
        [NativeName("Type.Name", "VkShaderCorePropertiesFlagsAMD")]
        [NativeName("Name", "shaderCoreFeatures")]
        public ShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "activeComputeUnitCount")]
        public uint ActiveComputeUnitCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderCoreProperties2Amd;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
