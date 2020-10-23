// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkViewportWScalingNV")]
    public unsafe partial struct ViewportWScalingNV
    {
        public ViewportWScalingNV
        (
            float? xcoeff = null,
            float? ycoeff = null
        )
        {
            fixed (ViewportWScalingNV* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (xcoeff is not null)
            {
                Xcoeff = xcoeff.Value;
            }

            if (ycoeff is not null)
            {
                Ycoeff = ycoeff.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "xcoeff")]
        public float Xcoeff;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ycoeff")]
        public float Ycoeff;
    }
}
