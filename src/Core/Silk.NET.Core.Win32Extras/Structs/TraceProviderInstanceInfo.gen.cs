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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_TRACE_PROVIDER_INSTANCE_INFO")]
    public unsafe partial struct TraceProviderInstanceInfo
    {
        public TraceProviderInstanceInfo
        (
            uint? nextOffset = null,
            uint? enableCount = null,
            uint? pid = null,
            uint? flags = null
        ) : this()
        {
            if (nextOffset is not null)
            {
                NextOffset = nextOffset.Value;
            }

            if (enableCount is not null)
            {
                EnableCount = enableCount.Value;
            }

            if (pid is not null)
            {
                Pid = pid.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NextOffset")]
        public uint NextOffset;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableCount")]
        public uint EnableCount;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Pid")]
        public uint Pid;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
