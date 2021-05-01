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
    [NativeName("Name", "StdVideoH265VpsFlags")]
    public unsafe partial struct StdVideoH265VpsFlags
    {
        public StdVideoH265VpsFlags
        (
            uint? vpsTemporalIdNestingFlag = null,
            uint? vpsSubLayerOrderingInfoPresentFlag = null,
            uint? vpsTimingInfoPresentFlag = null,
            uint? vpsPocProportionalToTimingFlag = null
        ) : this()
        {
            if (vpsTemporalIdNestingFlag is not null)
            {
                VpsTemporalIdNestingFlag = vpsTemporalIdNestingFlag.Value;
            }

            if (vpsSubLayerOrderingInfoPresentFlag is not null)
            {
                VpsSubLayerOrderingInfoPresentFlag = vpsSubLayerOrderingInfoPresentFlag.Value;
            }

            if (vpsTimingInfoPresentFlag is not null)
            {
                VpsTimingInfoPresentFlag = vpsTimingInfoPresentFlag.Value;
            }

            if (vpsPocProportionalToTimingFlag is not null)
            {
                VpsPocProportionalToTimingFlag = vpsPocProportionalToTimingFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_temporal_id_nesting_flag")]
        public uint VpsTemporalIdNestingFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_sub_layer_ordering_info_present_flag")]
        public uint VpsSubLayerOrderingInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_timing_info_present_flag")]
        public uint VpsTimingInfoPresentFlag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_poc_proportional_to_timing_flag")]
        public uint VpsPocProportionalToTimingFlag;
    }
}
