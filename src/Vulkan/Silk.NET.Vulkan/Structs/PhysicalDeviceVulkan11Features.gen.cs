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
    [NativeName("Name", "VkPhysicalDeviceVulkan11Features")]
    public unsafe partial struct PhysicalDeviceVulkan11Features : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceVulkan11Features
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan11Features,
            void* pNext = null,
            Bool32? storageBuffer16BitAccess = null,
            Bool32? uniformAndStorageBuffer16BitAccess = null,
            Bool32? storagePushConstant16 = null,
            Bool32? storageInputOutput16 = null,
            Bool32? multiview = null,
            Bool32? multiviewGeometryShader = null,
            Bool32? multiviewTessellationShader = null,
            Bool32? variablePointersStorageBuffer = null,
            Bool32? variablePointers = null,
            Bool32? protectedMemory = null,
            Bool32? samplerYcbcrConversion = null,
            Bool32? shaderDrawParameters = null
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

            if (storageBuffer16BitAccess is not null)
            {
                StorageBuffer16BitAccess = storageBuffer16BitAccess.Value;
            }

            if (uniformAndStorageBuffer16BitAccess is not null)
            {
                UniformAndStorageBuffer16BitAccess = uniformAndStorageBuffer16BitAccess.Value;
            }

            if (storagePushConstant16 is not null)
            {
                StoragePushConstant16 = storagePushConstant16.Value;
            }

            if (storageInputOutput16 is not null)
            {
                StorageInputOutput16 = storageInputOutput16.Value;
            }

            if (multiview is not null)
            {
                Multiview = multiview.Value;
            }

            if (multiviewGeometryShader is not null)
            {
                MultiviewGeometryShader = multiviewGeometryShader.Value;
            }

            if (multiviewTessellationShader is not null)
            {
                MultiviewTessellationShader = multiviewTessellationShader.Value;
            }

            if (variablePointersStorageBuffer is not null)
            {
                VariablePointersStorageBuffer = variablePointersStorageBuffer.Value;
            }

            if (variablePointers is not null)
            {
                VariablePointers = variablePointers.Value;
            }

            if (protectedMemory is not null)
            {
                ProtectedMemory = protectedMemory.Value;
            }

            if (samplerYcbcrConversion is not null)
            {
                SamplerYcbcrConversion = samplerYcbcrConversion.Value;
            }

            if (shaderDrawParameters is not null)
            {
                ShaderDrawParameters = shaderDrawParameters.Value;
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
        [NativeName("Name", "storageBuffer16BitAccess")]
        public Bool32 StorageBuffer16BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "uniformAndStorageBuffer16BitAccess")]
        public Bool32 UniformAndStorageBuffer16BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storagePushConstant16")]
        public Bool32 StoragePushConstant16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storageInputOutput16")]
        public Bool32 StorageInputOutput16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiview")]
        public Bool32 Multiview;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewGeometryShader")]
        public Bool32 MultiviewGeometryShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewTessellationShader")]
        public Bool32 MultiviewTessellationShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "variablePointersStorageBuffer")]
        public Bool32 VariablePointersStorageBuffer;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "variablePointers")]
        public Bool32 VariablePointers;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "protectedMemory")]
        public Bool32 ProtectedMemory;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "samplerYcbcrConversion")]
        public Bool32 SamplerYcbcrConversion;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDrawParameters")]
        public Bool32 ShaderDrawParameters;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan11Features;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
