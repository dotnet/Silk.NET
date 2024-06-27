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
    [NativeName("Name", "StdVideoAV1CDEF")]
    public unsafe partial struct StdVideoAV1CDEF
    {
        public StdVideoAV1CDEF
        (
            byte? cdefDampingMinus3 = null,
            byte? cdefBits = null
        ) : this()
        {
            if (cdefDampingMinus3 is not null)
            {
                CdefDampingMinus3 = cdefDampingMinus3.Value;
            }

            if (cdefBits is not null)
            {
                CdefBits = cdefBits.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cdef_damping_minus_3")]
        public byte CdefDampingMinus3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cdef_bits")]
        public byte CdefBits;
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "cdef_y_pri_strength")]
        public fixed byte CdefYPriStrength[8];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "cdef_y_sec_strength")]
        public fixed byte CdefYSecStrength[8];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "cdef_uv_pri_strength")]
        public fixed byte CdefUvPriStrength[8];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "cdef_uv_sec_strength")]
        public fixed byte CdefUvSecStrength[8];
    }
}
