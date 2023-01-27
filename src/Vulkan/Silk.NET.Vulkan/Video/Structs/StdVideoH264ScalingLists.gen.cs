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
    [NativeName("Name", "StdVideoH264ScalingLists")]
    public unsafe partial struct StdVideoH264ScalingLists
    {
        public StdVideoH264ScalingLists
        (
            ushort? scalingListPresentMask = null,
            ushort? useDefaultScalingMatrixMask = null
        ) : this()
        {
            if (scalingListPresentMask is not null)
            {
                ScalingListPresentMask = scalingListPresentMask.Value;
            }

            if (useDefaultScalingMatrixMask is not null)
            {
                UseDefaultScalingMatrixMask = useDefaultScalingMatrixMask.Value;
            }
        }


        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "scaling_list_present_mask")]
        public ushort ScalingListPresentMask;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "use_default_scaling_matrix_mask")]
        public ushort UseDefaultScalingMatrixMask;
        [NativeName("Type", "uint8_t[6][16]")]
        [NativeName("Type.Name", "uint8_t[6][16]")]
        [NativeName("Name", "ScalingList4x4")]
        public fixed byte ScalingList4x4[96];
        [NativeName("Type", "uint8_t[6][64]")]
        [NativeName("Type.Name", "uint8_t[6][64]")]
        [NativeName("Name", "ScalingList8x8")]
        public fixed byte ScalingList8x8[384];
    }
}
