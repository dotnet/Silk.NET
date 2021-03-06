// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkQueueFamilyCheckpointProperties2NV")]
    public unsafe partial struct QueueFamilyCheckpointProperties2NV
    {
        public QueueFamilyCheckpointProperties2NV
        (
            StructureType? sType = StructureType.QueueFamilyCheckpointProperties2NV,
            void* pNext = null,
            PipelineStageFlags2KHR? checkpointExecutionStageMask = null
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

            if (checkpointExecutionStageMask is not null)
            {
                CheckpointExecutionStageMask = checkpointExecutionStageMask.Value;
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
        [NativeName("Type", "VkPipelineStageFlags2KHR")]
        [NativeName("Type.Name", "VkPipelineStageFlags2KHR")]
        [NativeName("Name", "checkpointExecutionStageMask")]
        public PipelineStageFlags2KHR CheckpointExecutionStageMask;
    }
}
