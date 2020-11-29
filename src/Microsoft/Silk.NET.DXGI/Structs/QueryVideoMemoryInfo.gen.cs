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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_QUERY_VIDEO_MEMORY_INFO")]
    public unsafe partial struct QueryVideoMemoryInfo
    {
        public QueryVideoMemoryInfo
        (
            ulong? budget = null,
            ulong? currentUsage = null,
            ulong? availableForReservation = null,
            ulong? currentReservation = null
        ) : this()
        {
            if (budget is not null)
            {
                Budget = budget.Value;
            }

            if (currentUsage is not null)
            {
                CurrentUsage = currentUsage.Value;
            }

            if (availableForReservation is not null)
            {
                AvailableForReservation = availableForReservation.Value;
            }

            if (currentReservation is not null)
            {
                CurrentReservation = currentReservation.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Budget")]
        public ulong Budget;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentUsage")]
        public ulong CurrentUsage;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AvailableForReservation")]
        public ulong AvailableForReservation;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentReservation")]
        public ulong CurrentReservation;
    }
}
