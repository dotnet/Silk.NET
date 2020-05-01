// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDevice8BitStorageFeaturesKHR
    {
        public PhysicalDevice8BitStorageFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDevice8BitStorageFeatures,
            void* pNext = default,
            Bool32 storageBuffer8BitAccess = default,
            Bool32 uniformAndStorageBuffer8BitAccess = default,
            Bool32 storagePushConstant8 = default
        )
        {
           SType = sType;
           PNext = pNext;
           StorageBuffer8BitAccess = storageBuffer8BitAccess;
           UniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess;
           StoragePushConstant8 = storagePushConstant8;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 StorageBuffer8BitAccess;
/// <summary></summary>
        public Bool32 UniformAndStorageBuffer8BitAccess;
/// <summary></summary>
        public Bool32 StoragePushConstant8;
    }
}
