// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDevice16BitStorageFeaturesKHR")]
    public unsafe partial struct PhysicalDevice16BitStorageFeaturesKHR
    {
        public PhysicalDevice16BitStorageFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDevice16BitStorageFeatures,
            void* pNext = null,
            Bool32? storageBuffer16BitAccess = null,
            Bool32? uniformAndStorageBuffer16BitAccess = null,
            Bool32? storagePushConstant16 = null,
            Bool32? storageInputOutput16 = null
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
