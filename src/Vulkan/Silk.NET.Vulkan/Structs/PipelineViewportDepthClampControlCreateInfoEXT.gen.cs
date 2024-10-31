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
    [NativeName("Name", "VkPipelineViewportDepthClampControlCreateInfoEXT")]
    public unsafe partial struct PipelineViewportDepthClampControlCreateInfoEXT : IExtendsChain<PipelineViewportStateCreateInfo>
    {
        public PipelineViewportDepthClampControlCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineViewportDepthClampControlCreateInfoExt,
            void* pNext = null,
            DepthClampModeEXT? depthClampMode = null,
            DepthClampRangeEXT* pDepthClampRange = null
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

            if (depthClampMode is not null)
            {
                DepthClampMode = depthClampMode.Value;
            }

            if (pDepthClampRange is not null)
            {
                PDepthClampRange = pDepthClampRange;
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
        [NativeName("Type", "VkDepthClampModeEXT")]
        [NativeName("Type.Name", "VkDepthClampModeEXT")]
        [NativeName("Name", "depthClampMode")]
        public DepthClampModeEXT DepthClampMode;
/// <summary></summary>
        [NativeName("Type", "VkDepthClampRangeEXT*")]
        [NativeName("Type.Name", "VkDepthClampRangeEXT")]
        [NativeName("Name", "pDepthClampRange")]
        public DepthClampRangeEXT* PDepthClampRange;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineViewportDepthClampControlCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
