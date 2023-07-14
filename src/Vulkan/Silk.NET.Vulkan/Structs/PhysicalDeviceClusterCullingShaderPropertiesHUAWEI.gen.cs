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
    [NativeName("Name", "VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI")]
    public unsafe partial struct PhysicalDeviceClusterCullingShaderPropertiesHUAWEI : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceClusterCullingShaderPropertiesHUAWEI
        (
            StructureType? sType = StructureType.PhysicalDeviceClusterCullingShaderPropertiesHuawei,
            void* pNext = null,
            uint? maxOutputClusterCount = null,
            ulong? indirectBufferOffsetAlignment = null
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

            if (maxOutputClusterCount is not null)
            {
                MaxOutputClusterCount = maxOutputClusterCount.Value;
            }

            if (indirectBufferOffsetAlignment is not null)
            {
                IndirectBufferOffsetAlignment = indirectBufferOffsetAlignment.Value;
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
        [NativeName("Name", "maxWorkGroupCount")]
        public fixed uint MaxWorkGroupCount[3];
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxWorkGroupSize")]
        public fixed uint MaxWorkGroupSize[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxOutputClusterCount")]
        public uint MaxOutputClusterCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "indirectBufferOffsetAlignment")]
        public ulong IndirectBufferOffsetAlignment;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceClusterCullingShaderPropertiesHuawei;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
