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
    [NativeName("Name", "VkCheckpointDataNV")]
    public unsafe partial struct CheckpointDataNV : IChainable
    {
        public CheckpointDataNV
        (
            StructureType? sType = StructureType.CheckpointDataNV,
            void* pNext = null,
            PipelineStageFlags? stage = null,
            void* pCheckpointMarker = null
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

            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (pCheckpointMarker is not null)
            {
                PCheckpointMarker = pCheckpointMarker;
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
        [NativeName("Type", "VkPipelineStageFlagBits")]
        [NativeName("Type.Name", "VkPipelineStageFlagBits")]
        [NativeName("Name", "stage")]
        public PipelineStageFlags Stage;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pCheckpointMarker")]
        public void* PCheckpointMarker;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CheckpointDataNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
