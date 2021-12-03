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
    [NativeName("Name", "VkPipelineInputAssemblyStateCreateInfo")]
    public unsafe partial struct PipelineInputAssemblyStateCreateInfo : IChainable
    {
        public PipelineInputAssemblyStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineInputAssemblyStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            PrimitiveTopology? topology = null,
            Bool32? primitiveRestartEnable = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (topology is not null)
            {
                Topology = topology.Value;
            }

            if (primitiveRestartEnable is not null)
            {
                PrimitiveRestartEnable = primitiveRestartEnable.Value;
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
        [NativeName("Type", "VkPipelineInputAssemblyStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineInputAssemblyStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkPrimitiveTopology")]
        [NativeName("Type.Name", "VkPrimitiveTopology")]
        [NativeName("Name", "topology")]
        public PrimitiveTopology Topology;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveRestartEnable")]
        public Bool32 PrimitiveRestartEnable;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineInputAssemblyStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
