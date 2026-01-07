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
    [NativeName("Name", "VkPhysicalDeviceShaderFmaFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceShaderFmaFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderFmaFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderFmaFeaturesKhr,
            void* pNext = null,
            Bool32? shaderFmaFloat16 = null,
            Bool32? shaderFmaFloat32 = null,
            Bool32? shaderFmaFloat64 = null
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

            if (shaderFmaFloat16 is not null)
            {
                ShaderFmaFloat16 = shaderFmaFloat16.Value;
            }

            if (shaderFmaFloat32 is not null)
            {
                ShaderFmaFloat32 = shaderFmaFloat32.Value;
            }

            if (shaderFmaFloat64 is not null)
            {
                ShaderFmaFloat64 = shaderFmaFloat64.Value;
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
        [NativeName("Name", "shaderFmaFloat16")]
        public Bool32 ShaderFmaFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderFmaFloat32")]
        public Bool32 ShaderFmaFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderFmaFloat64")]
        public Bool32 ShaderFmaFloat64;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderFmaFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
