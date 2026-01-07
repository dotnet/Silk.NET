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
    [NativeName("Name", "VkDataGraphPipelineCreateInfoARM")]
    public unsafe partial struct DataGraphPipelineCreateInfoARM : IChainStart
    {
        public DataGraphPipelineCreateInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineCreateInfoArm,
            void* pNext = null,
            PipelineCreateFlags2KHR? flags = null,
            PipelineLayout? layout = null,
            uint? resourceInfoCount = null,
            DataGraphPipelineResourceInfoARM* pResourceInfos = null
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

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (resourceInfoCount is not null)
            {
                ResourceInfoCount = resourceInfoCount.Value;
            }

            if (pResourceInfos is not null)
            {
                PResourceInfos = pResourceInfos;
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
        [NativeName("Type", "VkPipelineCreateFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineCreateFlags2KHR")]
        [NativeName("Name", "flags")]
        public PipelineCreateFlags2KHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resourceInfoCount")]
        public uint ResourceInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkDataGraphPipelineResourceInfoARM*")]
        [NativeName("Type.Name", "VkDataGraphPipelineResourceInfoARM")]
        [NativeName("Name", "pResourceInfos")]
        public DataGraphPipelineResourceInfoARM* PResourceInfos;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineCreateInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DataGraphPipelineCreateInfoARM Chain(
            out DataGraphPipelineCreateInfoARM capture)
        {
            capture = new DataGraphPipelineCreateInfoARM(StructureType.DataGraphPipelineCreateInfoArm);
            return ref capture;
        }
    }
}
