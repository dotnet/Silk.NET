// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct QueueFamilyCheckpointPropertiesNV
    {
        public QueueFamilyCheckpointPropertiesNV
        (
            StructureType sType = StructureType.QueueFamilyCheckpointPropertiesNV,
            void* pNext = default,
            PipelineStageFlags checkpointExecutionStageMask = default
        )
        {
           SType = sType;
           PNext = pNext;
           CheckpointExecutionStageMask = checkpointExecutionStageMask;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineStageFlags CheckpointExecutionStageMask;
    }
}
