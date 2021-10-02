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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L568_C5")]
    public unsafe partial struct EventTraceHeaderUnion4
    {
        public EventTraceHeaderUnion4
        (
            ulong? processorTime = null
        ) : this()
        {
            if (processorTime is not null)
            {
                ProcessorTime = processorTime.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "ProcessorTime")]
        public ulong ProcessorTime;
    }
}
