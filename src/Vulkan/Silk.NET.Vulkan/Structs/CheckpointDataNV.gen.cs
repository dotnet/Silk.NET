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
    public unsafe struct CheckpointDataNV
    {
        public CheckpointDataNV
        (
            StructureType sType = StructureType.CheckpointDataNV,
            void* pNext = default,
            PipelineStageFlags stage = default,
            void* pCheckpointMarker = default
        )
        {
           SType = sType;
           PNext = pNext;
           Stage = stage;
           PCheckpointMarker = pCheckpointMarker;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineStageFlags Stage;
/// <summary></summary>
        public void* PCheckpointMarker;
    }
}
