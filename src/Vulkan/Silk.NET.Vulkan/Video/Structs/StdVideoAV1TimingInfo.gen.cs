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
    [NativeName("Name", "StdVideoAV1TimingInfo")]
    public unsafe partial struct StdVideoAV1TimingInfo
    {
        public StdVideoAV1TimingInfo
        (
            StdVideoAV1TimingInfoFlags? flags = null,
            uint? numUnitsInDisplayTick = null,
            uint? timeScale = null,
            uint? numTicksPerPictureMinus1 = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (numUnitsInDisplayTick is not null)
            {
                NumUnitsInDisplayTick = numUnitsInDisplayTick.Value;
            }

            if (timeScale is not null)
            {
                TimeScale = timeScale.Value;
            }

            if (numTicksPerPictureMinus1 is not null)
            {
                NumTicksPerPictureMinus1 = numTicksPerPictureMinus1.Value;
            }
        }


        [NativeName("Type", "StdVideoAV1TimingInfoFlags")]
        [NativeName("Type.Name", "StdVideoAV1TimingInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1TimingInfoFlags Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "num_units_in_display_tick")]
        public uint NumUnitsInDisplayTick;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "time_scale")]
        public uint TimeScale;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "num_ticks_per_picture_minus_1")]
        public uint NumTicksPerPictureMinus1;
    }
}
