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
    [NativeName("Name", "StdVideoH265LongTermRefPicsSps")]
    public unsafe partial struct StdVideoH265LongTermRefPicsSps
    {
        public StdVideoH265LongTermRefPicsSps
        (
            uint? usedByCurrPicLtSpsFlag = null
        ) : this()
        {
            if (usedByCurrPicLtSpsFlag is not null)
            {
                UsedByCurrPicLtSpsFlag = usedByCurrPicLtSpsFlag.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "used_by_curr_pic_lt_sps_flag")]
        public uint UsedByCurrPicLtSpsFlag;
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "lt_ref_pic_poc_lsb_sps")]
        public fixed uint LtRefPicPocLsbSps[32];
    }
}
