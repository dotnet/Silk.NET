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
    [NativeName("Name", "VkIndirectExecutionSetShaderInfoEXT")]
    public unsafe partial struct IndirectExecutionSetShaderInfoEXT : IChainable
    {
        public IndirectExecutionSetShaderInfoEXT
        (
            StructureType? sType = StructureType.IndirectExecutionSetShaderInfoExt,
            void* pNext = null,
            uint? shaderCount = null,
            ShaderEXT* pInitialShaders = null,
            IndirectExecutionSetShaderLayoutInfoEXT* pSetLayoutInfos = null,
            uint? maxShaderCount = null,
            uint? pushConstantRangeCount = null,
            PushConstantRange* pPushConstantRanges = null
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

            if (shaderCount is not null)
            {
                ShaderCount = shaderCount.Value;
            }

            if (pInitialShaders is not null)
            {
                PInitialShaders = pInitialShaders;
            }

            if (pSetLayoutInfos is not null)
            {
                PSetLayoutInfos = pSetLayoutInfos;
            }

            if (maxShaderCount is not null)
            {
                MaxShaderCount = maxShaderCount.Value;
            }

            if (pushConstantRangeCount is not null)
            {
                PushConstantRangeCount = pushConstantRangeCount.Value;
            }

            if (pPushConstantRanges is not null)
            {
                PPushConstantRanges = pPushConstantRanges;
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
        [NativeName("Name", "shaderCount")]
        public uint ShaderCount;
/// <summary></summary>
        [NativeName("Type", "VkShaderEXT*")]
        [NativeName("Type.Name", "VkShaderEXT")]
        [NativeName("Name", "pInitialShaders")]
        public ShaderEXT* PInitialShaders;
/// <summary></summary>
        [NativeName("Type", "VkIndirectExecutionSetShaderLayoutInfoEXT*")]
        [NativeName("Type.Name", "VkIndirectExecutionSetShaderLayoutInfoEXT")]
        [NativeName("Name", "pSetLayoutInfos")]
        public IndirectExecutionSetShaderLayoutInfoEXT* PSetLayoutInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxShaderCount")]
        public uint MaxShaderCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pushConstantRangeCount")]
        public uint PushConstantRangeCount;
/// <summary></summary>
        [NativeName("Type", "VkPushConstantRange*")]
        [NativeName("Type.Name", "VkPushConstantRange")]
        [NativeName("Name", "pPushConstantRanges")]
        public PushConstantRange* PPushConstantRanges;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectExecutionSetShaderInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
