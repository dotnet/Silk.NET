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
    [NativeName("Name", "VkPipelineCreationFeedbackEXT")]
    public unsafe partial struct PipelineCreationFeedbackEXT
    {
        public PipelineCreationFeedbackEXT
        (
            PipelineCreationFeedbackFlagsEXT? flags = null,
            ulong? duration = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (duration is not null)
            {
                Duration = duration.Value;
            }
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
