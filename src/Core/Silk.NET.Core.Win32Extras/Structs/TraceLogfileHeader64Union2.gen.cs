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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1169_C5")]
    public unsafe partial struct TraceLogfileHeader64Union2
    {
        public TraceLogfileHeader64Union2
        (
            Guid? logInstanceGuid = null,
            TraceLogfileHeader64Union2Union? anonymous = null,
            uint? startBuffers = null,
            uint? pointerSize = null,
            uint? eventsLost = null,
            uint? cpuSpeedInMHz = null
        ) : this()
        {
            if (logInstanceGuid is not null)
            {
                LogInstanceGuid = logInstanceGuid.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [FieldOffset(0)]
        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "LogInstanceGuid")]
        public Guid LogInstanceGuid;

        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1171_C9")]
        [NativeName("Name", "anonymous1")]
        public TraceLogfileHeader64Union2Union Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint StartBuffers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].StartBuffers;
        }
#else
        public uint StartBuffers
        {
            get => Anonymous.StartBuffers;
            set => Anonymous.StartBuffers = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint PointerSize
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PointerSize;
        }
#else
        public uint PointerSize
        {
            get => Anonymous.PointerSize;
            set => Anonymous.PointerSize = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint EventsLost
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].EventsLost;
        }
#else
        public uint EventsLost
        {
            get => Anonymous.EventsLost;
            set => Anonymous.EventsLost = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint CpuSpeedInMHz
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].CpuSpeedInMHz;
        }
#else
        public uint CpuSpeedInMHz
        {
            get => Anonymous.CpuSpeedInMHz;
            set => Anonymous.CpuSpeedInMHz = value;
        }
#endif

    }
}
