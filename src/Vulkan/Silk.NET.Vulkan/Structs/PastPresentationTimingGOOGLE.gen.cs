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
    public unsafe struct PastPresentationTimingGOOGLE
    {
        public PastPresentationTimingGOOGLE
        (
            uint presentID = default,
            ulong desiredPresentTime = default,
            ulong actualPresentTime = default,
            ulong earliestPresentTime = default,
            ulong presentMargin = default
        )
        {
           PresentID = presentID;
           DesiredPresentTime = desiredPresentTime;
           ActualPresentTime = actualPresentTime;
           EarliestPresentTime = earliestPresentTime;
           PresentMargin = presentMargin;
        }

/// <summary></summary>
        public uint PresentID;
/// <summary></summary>
        public ulong DesiredPresentTime;
/// <summary></summary>
        public ulong ActualPresentTime;
/// <summary></summary>
        public ulong EarliestPresentTime;
/// <summary></summary>
        public ulong PresentMargin;
    }
}
