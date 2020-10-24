// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRefreshCycleDurationGOOGLE")]
    public unsafe partial struct RefreshCycleDurationGOOGLE
    {
        public RefreshCycleDurationGOOGLE
        (
            ulong? refreshDuration = null
        ) : this()
        {
            if (refreshDuration is not null)
            {
                RefreshDuration = refreshDuration.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "refreshDuration")]
        public ulong RefreshDuration;
    }
}
