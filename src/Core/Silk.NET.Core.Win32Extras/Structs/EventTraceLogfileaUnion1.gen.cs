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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L1625_C5")]
    public unsafe partial struct EventTraceLogfileaUnion1
    {
        public EventTraceLogfileaUnion1
        (
            uint? logFileMode = null,
            uint? processTraceMode = null
        ) : this()
        {
            if (logFileMode is not null)
            {
                LogFileMode = logFileMode.Value;
            }

            if (processTraceMode is not null)
            {
                ProcessTraceMode = processTraceMode.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LogFileMode")]
        public uint LogFileMode;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProcessTraceMode")]
        public uint ProcessTraceMode;
    }
}
