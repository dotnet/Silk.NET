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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1LoopFilter")]
    public unsafe partial struct StdVideoAV1LoopFilter
    {
        public StdVideoAV1LoopFilter
        (
            StdVideoAV1LoopFilterFlags? flags = null,
            byte? loopFilterSharpness = null,
            byte? updateRefDelta = null,
            byte? updateModeDelta = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (loopFilterSharpness is not null)
            {
                LoopFilterSharpness = loopFilterSharpness.Value;
            }

            if (updateRefDelta is not null)
            {
                UpdateRefDelta = updateRefDelta.Value;
            }

            if (updateModeDelta is not null)
            {
                UpdateModeDelta = updateModeDelta.Value;
            }
        }


        [NativeName("Type", "StdVideoAV1LoopFilterFlags")]
        [NativeName("Type.Name", "StdVideoAV1LoopFilterFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1LoopFilterFlags Flags;
        [NativeName("Type", "uint8_t[4]")]
        [NativeName("Type.Name", "uint8_t[4]")]
        [NativeName("Name", "loop_filter_level")]
        public fixed byte LoopFilterLevel[4];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "loop_filter_sharpness")]
        public byte LoopFilterSharpness;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "update_ref_delta")]
        public byte UpdateRefDelta;
        [NativeName("Type", "int8_t[8]")]
        [NativeName("Type.Name", "int8_t[8]")]
        [NativeName("Name", "loop_filter_ref_deltas")]
        public fixed byte LoopFilterRefDeltas[8];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "update_mode_delta")]
        public byte UpdateModeDelta;
        [NativeName("Type", "int8_t[2]")]
        [NativeName("Type.Name", "int8_t[2]")]
        [NativeName("Name", "loop_filter_mode_deltas")]
        public fixed byte LoopFilterModeDeltas[2];
    }
}
