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
    [NativeName("Name", "VkDataGraphPipelineSessionMemoryRequirementsInfoARM")]
    public unsafe partial struct DataGraphPipelineSessionMemoryRequirementsInfoARM : IChainable
    {
        public DataGraphPipelineSessionMemoryRequirementsInfoARM
        (
            StructureType? sType = StructureType.DataGraphPipelineSessionMemoryRequirementsInfoArm,
            void* pNext = null,
            DataGraphPipelineSessionARM? session = null,
            DataGraphPipelineSessionBindPointARM? bindPoint = null,
            uint? objectIndex = null
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

            if (session is not null)
            {
                Session = session.Value;
            }

            if (bindPoint is not null)
            {
                BindPoint = bindPoint.Value;
            }

            if (objectIndex is not null)
            {
                ObjectIndex = objectIndex.Value;
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
        [NativeName("Type", "VkDataGraphPipelineSessionARM")]
        [NativeName("Type.Name", "VkDataGraphPipelineSessionARM")]
        [NativeName("Name", "session")]
        public DataGraphPipelineSessionARM Session;
/// <summary></summary>
        [NativeName("Type", "VkDataGraphPipelineSessionBindPointARM")]
        [NativeName("Type.Name", "VkDataGraphPipelineSessionBindPointARM")]
        [NativeName("Name", "bindPoint")]
        public DataGraphPipelineSessionBindPointARM BindPoint;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "objectIndex")]
        public uint ObjectIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DataGraphPipelineSessionMemoryRequirementsInfoArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
