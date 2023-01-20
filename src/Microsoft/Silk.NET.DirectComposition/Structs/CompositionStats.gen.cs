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

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "tagCOMPOSITION_STATS")]
    public unsafe partial struct CompositionStats
    {
        public CompositionStats
        (
            uint? presentCount = null,
            uint? refreshCount = null,
            uint? virtualRefreshCount = null,
            ulong? time = null
        ) : this()
        {
            if (presentCount is not null)
            {
                PresentCount = presentCount.Value;
            }

            if (refreshCount is not null)
            {
                RefreshCount = refreshCount.Value;
            }

            if (virtualRefreshCount is not null)
            {
                VirtualRefreshCount = virtualRefreshCount.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "presentCount")]
        public uint PresentCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "refreshCount")]
        public uint RefreshCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "virtualRefreshCount")]
        public uint VirtualRefreshCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "time")]
        public ulong Time;
    }
}
