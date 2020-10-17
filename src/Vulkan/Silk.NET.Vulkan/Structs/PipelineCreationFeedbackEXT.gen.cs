// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCreationFeedbackEXT")]
    public unsafe partial struct PipelineCreationFeedbackEXT
    {
        public PipelineCreationFeedbackEXT
        (
            PipelineCreationFeedbackFlagsEXT flags = default,
            ulong duration = default
        )
        {
            Flags = flags;
            Duration = duration;
        }

/// <summary></summary>
        [NativeName("Type", "VkPipelineCreationFeedbackFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineCreationFeedbackFlagsEXT")]
        [NativeName("Name", "flags")]
        public PipelineCreationFeedbackFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "duration")]
        public ulong Duration;
    }
}
