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

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_EVENT_TRACE_HEADER")]
    public unsafe partial struct EventTraceHeader
    {
        public EventTraceHeader
        (
            ushort? size = null,
            uint? threadId = null,
            uint? processId = null,
            long? timeStamp = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (threadId is not null)
            {
                ThreadId = threadId.Value;
            }

            if (processId is not null)
            {
                ProcessId = processId.Value;
            }

            if (timeStamp is not null)
            {
                TimeStamp = timeStamp.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Size")]
        public ushort Size;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ThreadId")]
        public uint ThreadId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProcessId")]
        public uint ProcessId;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "TimeStamp")]
        public long TimeStamp;
    }
}
