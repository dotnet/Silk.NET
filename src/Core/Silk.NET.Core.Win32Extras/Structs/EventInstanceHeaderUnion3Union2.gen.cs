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
    [NativeName("Name", "__AnonymousRecord_evntrace_L981_C9")]
    public unsafe partial struct EventInstanceHeaderUnion3Union2
    {
        public EventInstanceHeaderUnion3Union2
        (
            uint? eventId = null,
            uint? flags = null
        ) : this()
        {
            if (eventId is not null)
            {
                EventId = eventId.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EventId")]
        public uint EventId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
