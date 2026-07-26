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
    [NativeName("Name", "VkPhysicalDeviceShaderBfloat16FeaturesKHR")]
    public unsafe partial struct PhysicalDeviceShaderBfloat16FeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderBfloat16FeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderBfloat16FeaturesKhr,
            void* pNext = null,
            Bool32? shaderBFloat16Type = null,
            Bool32? shaderBFloat16DotProduct = null,
            Bool32? shaderBFloat16CooperativeMatrix = null
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

            if (shaderBFloat16Type is not null)
            {
                ShaderBFloat16Type = shaderBFloat16Type.Value;
            }

            if (shaderBFloat16DotProduct is not null)
            {
                ShaderBFloat16DotProduct = shaderBFloat16DotProduct.Value;
            }

            if (shaderBFloat16CooperativeMatrix is not null)
            {
                ShaderBFloat16CooperativeMatrix = shaderBFloat16CooperativeMatrix.Value;
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
        [NativeName("Name", "shaderBFloat16Type")]
        public Bool32 ShaderBFloat16Type;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBFloat16DotProduct")]
        public Bool32 ShaderBFloat16DotProduct;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBFloat16CooperativeMatrix")]
        public Bool32 ShaderBFloat16CooperativeMatrix;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderBfloat16FeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
