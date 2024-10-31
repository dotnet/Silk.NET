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
    [NativeName("Name", "VkPipelineOfflineCreateInfo")]
    public unsafe partial struct PipelineOfflineCreateInfo : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoKHR>, IExtendsChain<RayTracingPipelineCreateInfoNV>
    {
        public PipelineOfflineCreateInfo
        (
            StructureType? sType = StructureType.PipelineOfflineCreateInfo,
            void* pNext = null,
            PipelineMatchControl? matchControl = null,
            ulong? poolEntrySize = null
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

            if (matchControl is not null)
            {
                MatchControl = matchControl.Value;
            }

            if (poolEntrySize is not null)
            {
                PoolEntrySize = poolEntrySize.Value;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pipelineIdentifier")]
        public fixed byte PipelineIdentifier[16];
/// <summary></summary>
        [NativeName("Type", "VkPipelineMatchControl")]
        [NativeName("Type.Name", "VkPipelineMatchControl")]
        [NativeName("Name", "matchControl")]
        public PipelineMatchControl MatchControl;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "poolEntrySize")]
        public ulong PoolEntrySize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineOfflineCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
