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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPastPresentationTimingGOOGLE")]
    public unsafe partial struct PastPresentationTimingGOOGLE
    {
        public PastPresentationTimingGOOGLE
        (
            uint? presentID = null,
            ulong? desiredPresentTime = null,
            ulong? actualPresentTime = null,
            ulong? earliestPresentTime = null,
            ulong? presentMargin = null
        ) : this()
        {
            if (presentID is not null)
            {
                PresentID = presentID.Value;
            }

            if (desiredPresentTime is not null)
            {
                DesiredPresentTime = desiredPresentTime.Value;
            }

            if (actualPresentTime is not null)
            {
                ActualPresentTime = actualPresentTime.Value;
            }

            if (earliestPresentTime is not null)
            {
                EarliestPresentTime = earliestPresentTime.Value;
            }

            if (presentMargin is not null)
            {
                PresentMargin = presentMargin.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
