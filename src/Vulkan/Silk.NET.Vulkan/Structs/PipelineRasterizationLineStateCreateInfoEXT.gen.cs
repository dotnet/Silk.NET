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
    [NativeName("Name", "VkPipelineRasterizationLineStateCreateInfoEXT")]
    [NativeName("AliasOf", "VkPipelineRasterizationLineStateCreateInfoKHR")]
    public unsafe partial struct PipelineRasterizationLineStateCreateInfoEXT : IExtendsChain<PipelineRasterizationStateCreateInfo>
    {
        public PipelineRasterizationLineStateCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineRasterizationLineStateCreateInfoKhr,
            void* pNext = null,
            LineRasterizationModeKHR? lineRasterizationMode = null,
            Bool32? stippledLineEnable = null,
            uint? lineStippleFactor = null,
            ushort? lineStipplePattern = null
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

            if (lineRasterizationMode is not null)
            {
                LineRasterizationMode = lineRasterizationMode.Value;
            }

            if (stippledLineEnable is not null)
            {
                StippledLineEnable = stippledLineEnable.Value;
            }

            if (lineStippleFactor is not null)
            {
                LineStippleFactor = lineStippleFactor.Value;
            }

            if (lineStipplePattern is not null)
            {
                LineStipplePattern = lineStipplePattern.Value;
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
        [NativeName("Type", "VkLineRasterizationModeKHR")]
        [NativeName("Type.Name", "VkLineRasterizationModeKHR")]
        [NativeName("Name", "lineRasterizationMode")]
        public LineRasterizationModeKHR LineRasterizationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledLineEnable")]
        public Bool32 StippledLineEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "lineStippleFactor")]
        public uint LineStippleFactor;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "lineStipplePattern")]
        public ushort LineStipplePattern;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineRasterizationLineStateCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
