// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDevice16BitStorageFeatures
    {
        public PhysicalDevice16BitStorageFeatures
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 StorageBuffer16BitAccess;
/// <summary></summary>
        public Bool32 UniformAndStorageBuffer16BitAccess;
/// <summary></summary>
        public Bool32 StoragePushConstant16;
/// <summary></summary>
        public Bool32 StorageInputOutput16;
    }
}
