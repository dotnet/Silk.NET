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
    [NativeName("Name", "VkPhysicalDeviceCooperativeVectorPropertiesNV")]
    public unsafe partial struct PhysicalDeviceCooperativeVectorPropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceCooperativeVectorPropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceCooperativeVectorPropertiesNV,
            void* pNext = null,
            ShaderStageFlags? cooperativeVectorSupportedStages = null,
            Bool32? cooperativeVectorTrainingFloat16Accumulation = null,
            Bool32? cooperativeVectorTrainingFloat32Accumulation = null,
            uint? maxCooperativeVectorComponents = null
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

            if (cooperativeVectorSupportedStages is not null)
            {
                CooperativeVectorSupportedStages = cooperativeVectorSupportedStages.Value;
            }

            if (cooperativeVectorTrainingFloat16Accumulation is not null)
            {
                CooperativeVectorTrainingFloat16Accumulation = cooperativeVectorTrainingFloat16Accumulation.Value;
            }

            if (cooperativeVectorTrainingFloat32Accumulation is not null)
            {
                CooperativeVectorTrainingFloat32Accumulation = cooperativeVectorTrainingFloat32Accumulation.Value;
            }

            if (maxCooperativeVectorComponents is not null)
            {
                MaxCooperativeVectorComponents = maxCooperativeVectorComponents.Value;
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
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "cooperativeVectorSupportedStages")]
        public ShaderStageFlags CooperativeVectorSupportedStages;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeVectorTrainingFloat16Accumulation")]
        public Bool32 CooperativeVectorTrainingFloat16Accumulation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeVectorTrainingFloat32Accumulation")]
        public Bool32 CooperativeVectorTrainingFloat32Accumulation;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxCooperativeVectorComponents")]
        public uint MaxCooperativeVectorComponents;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceCooperativeVectorPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
