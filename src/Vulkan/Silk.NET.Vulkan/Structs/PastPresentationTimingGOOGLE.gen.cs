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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPastPresentationTimingGOOGLE")]
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "presentID")]
        public uint PresentID;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "desiredPresentTime")]
        public ulong DesiredPresentTime;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "actualPresentTime")]
        public ulong ActualPresentTime;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "earliestPresentTime")]
        public ulong EarliestPresentTime;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "presentMargin")]
        public ulong PresentMargin;
    }
}
