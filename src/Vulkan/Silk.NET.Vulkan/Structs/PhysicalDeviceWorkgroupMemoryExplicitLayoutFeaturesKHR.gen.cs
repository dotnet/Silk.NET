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
    [NativeName("Name", "VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr,
            void* pNext = null,
            Bool32? workgroupMemoryExplicitLayout = null,
            Bool32? workgroupMemoryExplicitLayoutScalarBlockLayout = null,
            Bool32? workgroupMemoryExplicitLayout8BitAccess = null,
            Bool32? workgroupMemoryExplicitLayout16BitAccess = null
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

            if (workgroupMemoryExplicitLayout is not null)
            {
                WorkgroupMemoryExplicitLayout = workgroupMemoryExplicitLayout.Value;
            }

            if (workgroupMemoryExplicitLayoutScalarBlockLayout is not null)
            {
                WorkgroupMemoryExplicitLayoutScalarBlockLayout = workgroupMemoryExplicitLayoutScalarBlockLayout.Value;
            }

            if (workgroupMemoryExplicitLayout8BitAccess is not null)
            {
                WorkgroupMemoryExplicitLayout8BitAccess = workgroupMemoryExplicitLayout8BitAccess.Value;
            }

            if (workgroupMemoryExplicitLayout16BitAccess is not null)
            {
                WorkgroupMemoryExplicitLayout16BitAccess = workgroupMemoryExplicitLayout16BitAccess.Value;
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
        [NativeName("Name", "workgroupMemoryExplicitLayout")]
        public Bool32 WorkgroupMemoryExplicitLayout;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "workgroupMemoryExplicitLayoutScalarBlockLayout")]
        public Bool32 WorkgroupMemoryExplicitLayoutScalarBlockLayout;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "workgroupMemoryExplicitLayout8BitAccess")]
        public Bool32 WorkgroupMemoryExplicitLayout8BitAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "workgroupMemoryExplicitLayout16BitAccess")]
        public Bool32 WorkgroupMemoryExplicitLayout16BitAccess;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
