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

namespace Silk.NET.Vulkan
{
    public unsafe struct DisplayPlaneCapabilitiesKHR
    {
        public DisplayPlaneCapabilitiesKHR
        (
            DisplayPlaneAlphaFlagsKHR supportedAlpha = default,
            Offset2D minSrcPosition = default,
            Offset2D maxSrcPosition = default,
            Extent2D minSrcExtent = default,
            Extent2D maxSrcExtent = default,
            Offset2D minDstPosition = default,
            Offset2D maxDstPosition = default,
            Extent2D minDstExtent = default,
            Extent2D maxDstExtent = default
        )
        {
           SupportedAlpha = supportedAlpha;
           MinSrcPosition = minSrcPosition;
           MaxSrcPosition = maxSrcPosition;
           MinSrcExtent = minSrcExtent;
           MaxSrcExtent = maxSrcExtent;
           MinDstPosition = minDstPosition;
           MaxDstPosition = maxDstPosition;
           MinDstExtent = minDstExtent;
           MaxDstExtent = maxDstExtent;
        }

/// <summary></summary>
        public DisplayPlaneAlphaFlagsKHR SupportedAlpha;
/// <summary></summary>
        public Offset2D MinSrcPosition;
/// <summary></summary>
        public Offset2D MaxSrcPosition;
/// <summary></summary>
        public Extent2D MinSrcExtent;
/// <summary></summary>
        public Extent2D MaxSrcExtent;
/// <summary></summary>
        public Offset2D MinDstPosition;
/// <summary></summary>
        public Offset2D MaxDstPosition;
/// <summary></summary>
        public Extent2D MinDstExtent;
/// <summary></summary>
        public Extent2D MaxDstExtent;
    }
}
