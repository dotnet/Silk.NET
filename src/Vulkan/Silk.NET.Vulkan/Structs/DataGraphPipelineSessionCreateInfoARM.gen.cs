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
    [NativeName("Name", "VkDataGraphPipelineSessionCreateInfoARM")]
    public unsafe partial struct DataGraphPipelineSessionCreateInfoARM : IChainable
    {
        public DataGraphPipelineSessionCreateInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineSessionCreateInfoArm,
            void* pNext = null,
            DataGraphPipelineSessionCreateFlagsARM? flags = null,
            Pipeline? dataGraphPipeline = null
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

            if (dataGraphPipeline is not null)
            {
                DataGraphPipeline = dataGraphPipeline.Value;
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
        [NativeName("Type", "VkDataGraphPipelineSessionCreateFlagsARM")]
        [NativeName("Type.Name", "VkDataGraphPipelineSessionCreateFlagsARM")]
        [NativeName("Name", "flags")]
        public DataGraphPipelineSessionCreateFlagsARM Flags;
/// <summary></summary>
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "dataGraphPipeline")]
        public Pipeline DataGraphPipeline;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineSessionCreateInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
