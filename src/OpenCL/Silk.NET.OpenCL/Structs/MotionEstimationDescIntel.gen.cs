// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
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
        public uint MbBlockType;
/// <summary></summary>
        public uint SubpixelMode;
/// <summary></summary>
        public uint SadAdjustMode;
/// <summary></summary>
        public uint SearchPathType;
    }
}
