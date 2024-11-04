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
    [NativeName("Name", "VkPhysicalDeviceCooperativeMatrix2PropertiesNV")]
    public unsafe partial struct PhysicalDeviceCooperativeMatrix2PropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceCooperativeMatrix2PropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceCooperativeMatrix2PropertiesNV,
            void* pNext = null,
            uint? cooperativeMatrixWorkgroupScopeMaxWorkgroupSize = null,
            uint? cooperativeMatrixFlexibleDimensionsMaxDimension = null,
            uint? cooperativeMatrixWorkgroupScopeReservedSharedMemory = null
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

            if (cooperativeMatrixWorkgroupScopeMaxWorkgroupSize is not null)
            {
                CooperativeMatrixWorkgroupScopeMaxWorkgroupSize = cooperativeMatrixWorkgroupScopeMaxWorkgroupSize.Value;
            }

            if (cooperativeMatrixFlexibleDimensionsMaxDimension is not null)
            {
                CooperativeMatrixFlexibleDimensionsMaxDimension = cooperativeMatrixFlexibleDimensionsMaxDimension.Value;
            }

            if (cooperativeMatrixWorkgroupScopeReservedSharedMemory is not null)
            {
                CooperativeMatrixWorkgroupScopeReservedSharedMemory = cooperativeMatrixWorkgroupScopeReservedSharedMemory.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cooperativeMatrixWorkgroupScopeMaxWorkgroupSize")]
        public uint CooperativeMatrixWorkgroupScopeMaxWorkgroupSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cooperativeMatrixFlexibleDimensionsMaxDimension")]
        public uint CooperativeMatrixFlexibleDimensionsMaxDimension;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cooperativeMatrixWorkgroupScopeReservedSharedMemory")]
        public uint CooperativeMatrixWorkgroupScopeReservedSharedMemory;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceCooperativeMatrix2PropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
