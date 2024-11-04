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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1128_C9")]
    public unsafe partial struct TraceLogfileHeader32Union2Union
    {
        public TraceLogfileHeader32Union2Union
        (
            uint? startBuffers = null,
            uint? pointerSize = null,
            uint? eventsLost = null,
            uint? cpuSpeedInMHz = null
        ) : this()
        {
            if (startBuffers is not null)
            {
                StartBuffers = startBuffers.Value;
            }

            if (pointerSize is not null)
            {
                PointerSize = pointerSize.Value;
            }

            if (eventsLost is not null)
            {
                EventsLost = eventsLost.Value;
            }

            if (cpuSpeedInMHz is not null)
            {
                CpuSpeedInMHz = cpuSpeedInMHz.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "StartBuffers")]
        public uint StartBuffers;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "PointerSize")]
        public uint PointerSize;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EventsLost")]
        public uint EventsLost;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "CpuSpeedInMHz")]
        public uint CpuSpeedInMHz;
    }
}
