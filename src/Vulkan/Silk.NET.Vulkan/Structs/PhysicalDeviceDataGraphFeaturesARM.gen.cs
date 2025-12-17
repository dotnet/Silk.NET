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
    [NativeName("Name", "VkPhysicalDeviceDataGraphFeaturesARM")]
    public unsafe partial struct PhysicalDeviceDataGraphFeaturesARM : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceDataGraphFeaturesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceDataGraphFeaturesArm,
            void* pNext = null,
            Bool32? dataGraph = null,
            Bool32? dataGraphUpdateAfterBind = null,
            Bool32? dataGraphSpecializationConstants = null,
            Bool32? dataGraphDescriptorBuffer = null,
            Bool32? dataGraphShaderModule = null
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

            if (dataGraph is not null)
            {
                DataGraph = dataGraph.Value;
            }

            if (dataGraphUpdateAfterBind is not null)
            {
                DataGraphUpdateAfterBind = dataGraphUpdateAfterBind.Value;
            }

            if (dataGraphSpecializationConstants is not null)
            {
                DataGraphSpecializationConstants = dataGraphSpecializationConstants.Value;
            }

            if (dataGraphDescriptorBuffer is not null)
            {
                DataGraphDescriptorBuffer = dataGraphDescriptorBuffer.Value;
            }

            if (dataGraphShaderModule is not null)
            {
                DataGraphShaderModule = dataGraphShaderModule.Value;
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
        [NativeName("Name", "dataGraph")]
        public Bool32 DataGraph;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dataGraphUpdateAfterBind")]
        public Bool32 DataGraphUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dataGraphSpecializationConstants")]
        public Bool32 DataGraphSpecializationConstants;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dataGraphDescriptorBuffer")]
        public Bool32 DataGraphDescriptorBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dataGraphShaderModule")]
        public Bool32 DataGraphShaderModule;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDataGraphFeaturesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
