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
    [NativeName("Name", "VkPhysicalDeviceTensorFeaturesARM")]
    public unsafe partial struct PhysicalDeviceTensorFeaturesARM : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceTensorFeaturesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceTensorFeaturesArm,
            void* pNext = null,
            Bool32? tensorNonPacked = null,
            Bool32? shaderTensorAccess = null,
            Bool32? shaderStorageTensorArrayDynamicIndexing = null,
            Bool32? shaderStorageTensorArrayNonUniformIndexing = null,
            Bool32? descriptorBindingStorageTensorUpdateAfterBind = null,
            Bool32? tensors = null
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

            if (tensorNonPacked is not null)
            {
                TensorNonPacked = tensorNonPacked.Value;
            }

            if (shaderTensorAccess is not null)
            {
                ShaderTensorAccess = shaderTensorAccess.Value;
            }

            if (shaderStorageTensorArrayDynamicIndexing is not null)
            {
                ShaderStorageTensorArrayDynamicIndexing = shaderStorageTensorArrayDynamicIndexing.Value;
            }

            if (shaderStorageTensorArrayNonUniformIndexing is not null)
            {
                ShaderStorageTensorArrayNonUniformIndexing = shaderStorageTensorArrayNonUniformIndexing.Value;
            }

            if (descriptorBindingStorageTensorUpdateAfterBind is not null)
            {
                DescriptorBindingStorageTensorUpdateAfterBind = descriptorBindingStorageTensorUpdateAfterBind.Value;
            }

            if (tensors is not null)
            {
                Tensors = tensors.Value;
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
        [NativeName("Name", "tensorNonPacked")]
        public Bool32 TensorNonPacked;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTensorAccess")]
        public Bool32 ShaderTensorAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageTensorArrayDynamicIndexing")]
        public Bool32 ShaderStorageTensorArrayDynamicIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderStorageTensorArrayNonUniformIndexing")]
        public Bool32 ShaderStorageTensorArrayNonUniformIndexing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingStorageTensorUpdateAfterBind")]
        public Bool32 DescriptorBindingStorageTensorUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "tensors")]
        public Bool32 Tensors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTensorFeaturesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
