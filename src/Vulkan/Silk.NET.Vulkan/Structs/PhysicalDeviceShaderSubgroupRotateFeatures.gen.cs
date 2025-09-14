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
    [NativeName("Name", "VkPhysicalDeviceShaderSubgroupRotateFeatures")]
    [NativeName("Aliases", "VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceShaderSubgroupRotateFeatures : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderSubgroupRotateFeatures
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderSubgroupRotateFeatures,
            void* pNext = null,
            Bool32? shaderSubgroupRotate = null,
            Bool32? shaderSubgroupRotateClustered = null
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

            if (shaderSubgroupRotate is not null)
            {
                ShaderSubgroupRotate = shaderSubgroupRotate.Value;
            }

            if (shaderSubgroupRotateClustered is not null)
            {
                ShaderSubgroupRotateClustered = shaderSubgroupRotateClustered.Value;
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
        [NativeName("Name", "shaderSubgroupRotate")]
        public Bool32 ShaderSubgroupRotate;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSubgroupRotateClustered")]
        public Bool32 ShaderSubgroupRotateClustered;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderSubgroupRotateFeatures;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
