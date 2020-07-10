// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceVulkan11Features")]
    public unsafe partial struct PhysicalDeviceVulkan11Features
    {
        public PhysicalDeviceVulkan11Features
        (
            StructureType sType = StructureType.PhysicalDeviceVulkan11Features,
            void* pNext = default,
            Bool32 storageBuffer16BitAccess = default,
            Bool32 uniformAndStorageBuffer16BitAccess = default,
            Bool32 storagePushConstant16 = default,
            Bool32 storageInputOutput16 = default,
            Bool32 multiview = default,
            Bool32 multiviewGeometryShader = default,
            Bool32 multiviewTessellationShader = default,
            Bool32 variablePointersStorageBuffer = default,
            Bool32 variablePointers = default,
            Bool32 protectedMemory = default,
            Bool32 samplerYcbcrConversion = default,
            Bool32 shaderDrawParameters = default
        )
        {
            SType = sType;
            PNext = pNext;
            StorageBuffer16BitAccess = storageBuffer16BitAccess;
            UniformAndStorageBuffer16BitAccess = uniformAndStorageBuffer16BitAccess;
            StoragePushConstant16 = storagePushConstant16;
            StorageInputOutput16 = storageInputOutput16;
            Multiview = multiview;
            MultiviewGeometryShader = multiviewGeometryShader;
            MultiviewTessellationShader = multiviewTessellationShader;
            VariablePointersStorageBuffer = variablePointersStorageBuffer;
            VariablePointers = variablePointers;
            ProtectedMemory = protectedMemory;
            SamplerYcbcrConversion = samplerYcbcrConversion;
            ShaderDrawParameters = shaderDrawParameters;
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
    }
}
