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
    [NativeName("Name", "VkPipelineColorWriteCreateInfoEXT")]
    public unsafe partial struct PipelineColorWriteCreateInfoEXT : IExtendsChain<PipelineColorBlendStateCreateInfo>
    {
        public PipelineColorWriteCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineColorWriteCreateInfoExt,
            void* pNext = null,
            uint? attachmentCount = null,
            Bool32* pColorWriteEnables = null
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

            if (attachmentCount is not null)
            {
                AttachmentCount = attachmentCount.Value;
            }

            if (pColorWriteEnables is not null)
            {
                PColorWriteEnables = pColorWriteEnables;
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
        [NativeName("Name", "attachmentCount")]
        public uint AttachmentCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32*")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pColorWriteEnables")]
        public Bool32* PColorWriteEnables;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineColorWriteCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
