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
    [NativeName("Name", "VkPresentStageTimeEXT")]
    public unsafe partial struct PresentStageTimeEXT
    {
        public PresentStageTimeEXT
        (
            PresentStageFlagsEXT? stage = null,
            ulong? time = null
        ) : this()
        {
            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPresentStageFlagsEXT")]
        [NativeName("Type.Name", "VkPresentStageFlagsEXT")]
        [NativeName("Name", "stage")]
        public PresentStageFlagsEXT Stage;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "time")]
        public ulong Time;
    }
}
