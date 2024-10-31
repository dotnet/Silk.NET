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
    [NativeName("Name", "VkPhysicalDevice8BitStorageFeaturesKHR")]
    [NativeName("AliasOf", "VkPhysicalDevice8BitStorageFeatures")]
    public unsafe partial struct PhysicalDevice8BitStorageFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDevice8BitStorageFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDevice8BitStorageFeatures,
            void* pNext = null,
            Bool32? storageBuffer8BitAccess = null,
            Bool32? uniformAndStorageBuffer8BitAccess = null,
            Bool32? storagePushConstant8 = null
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

            if (storageBuffer8BitAccess is not null)
            {
                StorageBuffer8BitAccess = storageBuffer8BitAccess.Value;
            }

            if (uniformAndStorageBuffer8BitAccess is not null)
            {
                UniformAndStorageBuffer8BitAccess = uniformAndStorageBuffer8BitAccess.Value;
            }

            if (storagePushConstant8 is not null)
            {
                StoragePushConstant8 = storagePushConstant8.Value;
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
        [NativeName("Name", "storageBuffer8BitAccess")]
        public Bool32 StorageBuffer8BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "uniformAndStorageBuffer8BitAccess")]
        public Bool32 UniformAndStorageBuffer8BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "storagePushConstant8")]
        public Bool32 StoragePushConstant8;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevice8BitStorageFeatures;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
