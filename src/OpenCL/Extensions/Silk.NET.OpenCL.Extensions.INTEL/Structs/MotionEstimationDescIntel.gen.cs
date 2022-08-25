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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_motion_estimation_desc_intel")]
    public unsafe partial struct MotionEstimationDescIntel
    {
        public MotionEstimationDescIntel
        (
            uint? mbBlockType = null,
            uint? subpixelMode = null,
            uint? sadAdjustMode = null,
            uint? searchPathType = null
        ) : this()
        {
            if (mbBlockType is not null)
            {
                MbBlockType = mbBlockType.Value;
            }

            if (subpixelMode is not null)
            {
                SubpixelMode = subpixelMode.Value;
            }

            if (sadAdjustMode is not null)
            {
                SadAdjustMode = sadAdjustMode.Value;
            }

            if (searchPathType is not null)
            {
                SearchPathType = searchPathType.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "mb_block_type")]
        public uint MbBlockType;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "subpixel_mode")]
        public uint SubpixelMode;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "sad_adjust_mode")]
        public uint SadAdjustMode;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "search_path_type")]
        public uint SearchPathType;
    }
}
