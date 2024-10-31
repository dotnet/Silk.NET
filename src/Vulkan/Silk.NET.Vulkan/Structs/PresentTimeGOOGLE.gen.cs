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
    [NativeName("Name", "VkPresentTimeGOOGLE")]
    public unsafe partial struct PresentTimeGOOGLE
    {
        public PresentTimeGOOGLE
        (
            uint? presentID = null,
            ulong? desiredPresentTime = null
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
