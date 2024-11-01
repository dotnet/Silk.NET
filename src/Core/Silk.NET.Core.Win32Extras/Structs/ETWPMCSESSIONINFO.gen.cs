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
    [NativeName("AnonymousName", "__AnonymousRecord_evntrace_L1427_C9")]
    [NativeName("Name", "ETW_PMC_SESSION_INFO")]
    public unsafe partial struct ETWPMCSESSIONINFO
    {
        public ETWPMCSESSIONINFO
        (
            uint? nextEntryOffset = null,
            ushort? loggerId = null,
            ushort? reserved = null,
            uint? profileSourceCount = null,
            uint? hookIdCount = null
        ) : this()
        {
            if (nextEntryOffset is not null)
            {
                NextEntryOffset = nextEntryOffset.Value;
            }

            if (loggerId is not null)
            {
                LoggerId = loggerId.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (profileSourceCount is not null)
            {
                ProfileSourceCount = profileSourceCount.Value;
            }

            if (hookIdCount is not null)
            {
                HookIdCount = hookIdCount.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NextEntryOffset")]
        public uint NextEntryOffset;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "LoggerId")]
        public ushort LoggerId;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Reserved")]
        public ushort Reserved;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProfileSourceCount")]
        public uint ProfileSourceCount;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "HookIdCount")]
        public uint HookIdCount;
    }
}
