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
    [NativeName("Name", "StdVideoH265ProfileTierLevel")]
    public unsafe partial struct StdVideoH265ProfileTierLevel
    {
        public StdVideoH265ProfileTierLevel
        (
            StdVideoH265ProfileTierLevelFlags? flags = null,
            StdVideoH265ProfileIdc? generalProfileIdc = null,
            StdVideoH265LevelIdc? generalLevelIdc = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (generalProfileIdc is not null)
            {
                GeneralProfileIdc = generalProfileIdc.Value;
            }

            if (generalLevelIdc is not null)
            {
                GeneralLevelIdc = generalLevelIdc.Value;
            }
        }


        [NativeName("Type", "StdVideoH265ProfileTierLevelFlags")]
        [NativeName("Type.Name", "StdVideoH265ProfileTierLevelFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265ProfileTierLevelFlags Flags;

        [NativeName("Type", "StdVideoH265ProfileIdc")]
        [NativeName("Type.Name", "StdVideoH265ProfileIdc")]
        [NativeName("Name", "general_profile_idc")]
        public StdVideoH265ProfileIdc GeneralProfileIdc;

        [NativeName("Type", "StdVideoH265LevelIdc")]
        [NativeName("Type.Name", "StdVideoH265LevelIdc")]
        [NativeName("Name", "general_level_idc")]
        public StdVideoH265LevelIdc GeneralLevelIdc;
    }
}
