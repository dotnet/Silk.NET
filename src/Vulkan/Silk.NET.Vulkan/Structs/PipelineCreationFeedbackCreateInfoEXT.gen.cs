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
    public unsafe struct PipelineCreationFeedbackCreateInfoEXT
    {
        public PipelineCreationFeedbackCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineCreationFeedbackCreateInfoExt,
            void* pNext = default,
            PipelineCreationFeedbackEXT* pPipelineCreationFeedback = default,
            uint pipelineStageCreationFeedbackCount = default,
            PipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks = default
        )
        {
           SType = sType;
           PNext = pNext;
           PPipelineCreationFeedback = pPipelineCreationFeedback;
           PipelineStageCreationFeedbackCount = pipelineStageCreationFeedbackCount;
           PPipelineStageCreationFeedbacks = pPipelineStageCreationFeedbacks;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineCreationFeedbackEXT* PPipelineCreationFeedback;
/// <summary></summary>
        public uint PipelineStageCreationFeedbackCount;
/// <summary></summary>
        public PipelineCreationFeedbackEXT* PPipelineStageCreationFeedbacks;
    }
}
