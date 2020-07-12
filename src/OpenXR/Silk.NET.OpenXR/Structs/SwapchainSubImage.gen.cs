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

namespace Silk.NET.OpenXR
{
    public unsafe struct SwapchainSubImage
    {
        public SwapchainSubImage
        (
            Swapchain swapchain = default,
            Rect2Di imageRect = default,
            uint imageArrayIndex = default
        )
        {
           Swapchain = swapchain;
           ImageRect = imageRect;
           ImageArrayIndex = imageArrayIndex;
        }

/// <summary></summary>
        public Swapchain Swapchain;
/// <summary></summary>
        public Rect2Di ImageRect;
/// <summary></summary>
        public uint ImageArrayIndex;
    }
}
