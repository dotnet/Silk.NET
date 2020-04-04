// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct ViewportWScalingNV
    {
        public ViewportWScalingNV
        (
            float xcoeff = default,
            float ycoeff = default
        )
        {
           Xcoeff = xcoeff;
           Ycoeff = ycoeff;
        }

/// <summary></summary>
        public float Xcoeff;
/// <summary></summary>
        public float Ycoeff;
    }
}
