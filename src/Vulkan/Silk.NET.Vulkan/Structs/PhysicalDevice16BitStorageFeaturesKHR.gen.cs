// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDevice16BitStorageFeaturesKHR")]
    public unsafe partial struct PhysicalDevice16BitStorageFeaturesKHR
    {
        public PhysicalDevice16BitStorageFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDevice16BitStorageFeatures,
            void* pNext = default,
            Bool32 storageBuffer16BitAccess = default,
            Bool32 uniformAndStorageBuffer16BitAccess = default,
            Bool32 storagePushConstant16 = default,
            Bool32 storageInputOutput16 = default
        )
        {
            SType = sType;
            PNext = pNext;
            StorageBuffer16BitAccess = storageBuffer16BitAccess;
            UniformAndStorageBuffer16BitAccess = uniformAndStorageBuffer16BitAccess;
            StoragePushConstant16 = storagePushConstant16;
            StorageInputOutput16 = storageInputOutput16;
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
    }
}
