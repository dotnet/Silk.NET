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
    [NativeName("Name", "StdVideoVP9LoopFilter")]
    public unsafe partial struct StdVideoVP9LoopFilter
    {
        public StdVideoVP9LoopFilter
        (
            StdVideoVP9LoopFilterFlags? flags = null,
            byte? loopFilterLevel = null,
            byte? loopFilterSharpness = null,
            byte? updateRefDelta = null,
            byte? updateModeDelta = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (loopFilterLevel is not null)
            {
                LoopFilterLevel = loopFilterLevel.Value;
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


        [NativeName("Type", "StdVideoVP9LoopFilterFlags")]
        [NativeName("Type.Name", "StdVideoVP9LoopFilterFlags")]
        [NativeName("Name", "flags")]
        public StdVideoVP9LoopFilterFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "loop_filter_level")]
        public byte LoopFilterLevel;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "loop_filter_sharpness")]
        public byte LoopFilterSharpness;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "update_ref_delta")]
        public byte UpdateRefDelta;
        [NativeName("Type", "int8_t[4]")]
        [NativeName("Type.Name", "int8_t[4]")]
        [NativeName("Name", "loop_filter_ref_deltas")]
        public fixed byte LoopFilterRefDeltas[4];

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
