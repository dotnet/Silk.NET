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
    [NativeName("Name", "VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR")]
    [NativeName("Aliases", "VkPhysicalDeviceComputeShaderDerivativesFeaturesNV")]
    public unsafe partial struct PhysicalDeviceComputeShaderDerivativesFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceComputeShaderDerivativesFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceComputeShaderDerivativesFeaturesKhr,
            void* pNext = null,
            Bool32? computeDerivativeGroupQuads = null,
            Bool32? computeDerivativeGroupLinear = null
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

            if (computeDerivativeGroupQuads is not null)
            {
                ComputeDerivativeGroupQuads = computeDerivativeGroupQuads.Value;
            }

            if (computeDerivativeGroupLinear is not null)
            {
                ComputeDerivativeGroupLinear = computeDerivativeGroupLinear.Value;
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
        [NativeName("Name", "computeDerivativeGroupQuads")]
        public Bool32 ComputeDerivativeGroupQuads;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "computeDerivativeGroupLinear")]
        public Bool32 ComputeDerivativeGroupLinear;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceComputeShaderDerivativesFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
