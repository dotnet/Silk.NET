// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_motion_estimation_desc_intel")]
    public unsafe struct MotionEstimationDescIntel
    {
        public MotionEstimationDescIntel
        (
            uint mbBlockType = default,
            uint subpixelMode = default,
            uint sadAdjustMode = default,
            uint searchPathType = default
        )
        {
           MbBlockType = mbBlockType;
           SubpixelMode = subpixelMode;
           SadAdjustMode = sadAdjustMode;
           SearchPathType = searchPathType;
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
