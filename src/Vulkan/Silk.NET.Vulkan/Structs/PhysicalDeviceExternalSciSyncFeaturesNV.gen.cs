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
    [NativeName("Name", "VkPhysicalDeviceExternalSciSyncFeaturesNV")]
    public unsafe partial struct PhysicalDeviceExternalSciSyncFeaturesNV : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceExternalSciSyncFeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceExternalSciSyncFeaturesNV,
            void* pNext = null,
            Bool32? sciSyncFence = null,
            Bool32? sciSyncSemaphore = null,
            Bool32? sciSyncImport = null,
            Bool32? sciSyncExport = null
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

            if (sciSyncFence is not null)
            {
                SciSyncFence = sciSyncFence.Value;
            }

            if (sciSyncSemaphore is not null)
            {
                SciSyncSemaphore = sciSyncSemaphore.Value;
            }

            if (sciSyncImport is not null)
            {
                SciSyncImport = sciSyncImport.Value;
            }

            if (sciSyncExport is not null)
            {
                SciSyncExport = sciSyncExport.Value;
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
        [NativeName("Name", "sciSyncFence")]
        public Bool32 SciSyncFence;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sciSyncSemaphore")]
        public Bool32 SciSyncSemaphore;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sciSyncImport")]
        public Bool32 SciSyncImport;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sciSyncExport")]
        public Bool32 SciSyncExport;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExternalSciSyncFeaturesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
