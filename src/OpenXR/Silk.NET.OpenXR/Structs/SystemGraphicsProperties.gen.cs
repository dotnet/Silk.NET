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
    public unsafe struct SystemGraphicsProperties
    {
        public SystemGraphicsProperties
        (
            uint maxSwapchainImageHeight = default,
            uint maxSwapchainImageWidth = default,
            uint maxLayerCount = default
        )
        {
           MaxSwapchainImageHeight = maxSwapchainImageHeight;
           MaxSwapchainImageWidth = maxSwapchainImageWidth;
           MaxLayerCount = maxLayerCount;
        }

/// <summary></summary>
        public uint MaxSwapchainImageHeight;
/// <summary></summary>
        public uint MaxSwapchainImageWidth;
/// <summary></summary>
        public uint MaxLayerCount;
    }
}
