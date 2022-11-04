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
    [NativeName("Name", "StdVideoH265VideoParameterSet")]
    public unsafe partial struct StdVideoH265VideoParameterSet
    {
        public StdVideoH265VideoParameterSet
        (
            StdVideoH265VpsFlags? flags = null,
            byte? vpsVideoParameterSetId = null,
            byte? vpsMaxSubLayersMinus1 = null,
            byte? reserved1 = null,
            byte? reserved2 = null,
            uint? vpsNumUnitsInTick = null,
            uint? vpsTimeScale = null,
            uint? vpsNumTicksPocDiffOneMinus1 = null,
            uint? reserved3 = null,
            StdVideoH265DecPicBufMgr* pDecPicBufMgr = null,
            StdVideoH265HrdParameters* pHrdParameters = null,
            StdVideoH265ProfileTierLevel* pProfileTierLevel = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (vpsVideoParameterSetId is not null)
            {
                VpsVideoParameterSetId = vpsVideoParameterSetId.Value;
            }

            if (vpsMaxSubLayersMinus1 is not null)
            {
                VpsMaxSubLayersMinus1 = vpsMaxSubLayersMinus1.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (vpsNumUnitsInTick is not null)
            {
                VpsNumUnitsInTick = vpsNumUnitsInTick.Value;
            }

            if (vpsTimeScale is not null)
            {
                VpsTimeScale = vpsTimeScale.Value;
            }

            if (vpsNumTicksPocDiffOneMinus1 is not null)
            {
                VpsNumTicksPocDiffOneMinus1 = vpsNumTicksPocDiffOneMinus1.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (pDecPicBufMgr is not null)
            {
                PDecPicBufMgr = pDecPicBufMgr;
            }

            if (pHrdParameters is not null)
            {
                PHrdParameters = pHrdParameters;
            }

            if (pProfileTierLevel is not null)
            {
                PProfileTierLevel = pProfileTierLevel;
            }
        }


        [NativeName("Type", "StdVideoH265VpsFlags")]
        [NativeName("Type.Name", "StdVideoH265VpsFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265VpsFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "vps_video_parameter_set_id")]
        public byte VpsVideoParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "vps_max_sub_layers_minus1")]
        public byte VpsMaxSubLayersMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_num_units_in_tick")]
        public uint VpsNumUnitsInTick;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_time_scale")]
        public uint VpsTimeScale;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vps_num_ticks_poc_diff_one_minus1")]
        public uint VpsNumTicksPocDiffOneMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "reserved3")]
        public uint Reserved3;

        [NativeName("Type", "const StdVideoH265DecPicBufMgr *")]
        [NativeName("Type.Name", "const StdVideoH265DecPicBufMgr *")]
        [NativeName("Name", "pDecPicBufMgr")]
        public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

        [NativeName("Type", "const StdVideoH265HrdParameters *")]
        [NativeName("Type.Name", "const StdVideoH265HrdParameters *")]
        [NativeName("Name", "pHrdParameters")]
        public StdVideoH265HrdParameters* PHrdParameters;

        [NativeName("Type", "const StdVideoH265ProfileTierLevel *")]
        [NativeName("Type.Name", "const StdVideoH265ProfileTierLevel *")]
        [NativeName("Name", "pProfileTierLevel")]
        public StdVideoH265ProfileTierLevel* PProfileTierLevel;
    }
}
