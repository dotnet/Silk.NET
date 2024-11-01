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
    [NativeName("Name", "VkExecutionGraphPipelineScratchSizeAMDX")]
    public unsafe partial struct ExecutionGraphPipelineScratchSizeAMDX : IChainable
    {
        public ExecutionGraphPipelineScratchSizeAMDX
        (
            StructureType? sType = StructureType.ExecutionGraphPipelineScratchSizeAmdx,
            void* pNext = null,
            ulong? minSize = null,
            ulong? maxSize = null,
            ulong? sizeGranularity = null
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

            if (minSize is not null)
            {
                MinSize = minSize.Value;
            }

            if (maxSize is not null)
            {
                MaxSize = maxSize.Value;
            }

            if (sizeGranularity is not null)
            {
                SizeGranularity = sizeGranularity.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minSize")]
        public ulong MinSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxSize")]
        public ulong MaxSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "sizeGranularity")]
        public ulong SizeGranularity;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExecutionGraphPipelineScratchSizeAmdx;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
