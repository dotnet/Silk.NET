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
    [NativeName("Name", "VkVideoEncodeAV1QIndexKHR")]
    public unsafe partial struct VideoEncodeAV1QIndexKHR
    {
        public VideoEncodeAV1QIndexKHR
        (
            uint? intraQIndex = null,
            uint? predictiveQIndex = null,
            uint? bipredictiveQIndex = null
        ) : this()
        {
            if (intraQIndex is not null)
            {
                IntraQIndex = intraQIndex.Value;
            }

            if (predictiveQIndex is not null)
            {
                PredictiveQIndex = predictiveQIndex.Value;
            }

            if (bipredictiveQIndex is not null)
            {
                BipredictiveQIndex = bipredictiveQIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "intraQIndex")]
        public uint IntraQIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "predictiveQIndex")]
        public uint PredictiveQIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bipredictiveQIndex")]
        public uint BipredictiveQIndex;
    }
}
