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
    [NativeName("Name", "__AnonymousRecord_evntrace_L975_C5")]
    public unsafe partial struct EventInstanceHeaderUnion3
    {
        public EventInstanceHeaderUnion3
        (
            EventInstanceHeaderUnion3Union1? anonymous1 = null,
            ulong? processorTime = null,
            EventInstanceHeaderUnion3Union2? anonymous2 = null,
            uint? kernelTime = null,
            uint? userTime = null,
            uint? eventId = null,
            uint? flags = null
        ) : this()
        {
            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (processorTime is not null)
            {
                ProcessorTime = processorTime.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (kernelTime is not null)
            {
                KernelTime = kernelTime.Value;
            }

            if (userTime is not null)
            {
                UserTime = userTime.Value;
            }

            if (eventId is not null)
            {
                EventId = eventId.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L976_C9")]
        [NativeName("Name", "anonymous1")]
        public EventInstanceHeaderUnion3Union1 Anonymous1;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "ProcessorTime")]
        public ulong ProcessorTime;

        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L981_C9")]
        [NativeName("Name", "anonymous2")]
        public EventInstanceHeaderUnion3Union2 Anonymous2;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint KernelTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].KernelTime;
        }
#else
        public uint KernelTime
        {
            get => Anonymous1.KernelTime;
            set => Anonymous1.KernelTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint UserTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].UserTime;
        }
#else
        public uint UserTime
        {
            get => Anonymous1.UserTime;
            set => Anonymous1.UserTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint EventId
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].EventId;
        }
#else
        public uint EventId
        {
            get => Anonymous2.EventId;
            set => Anonymous2.EventId = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Flags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Flags;
        }
#else
        public uint Flags
        {
            get => Anonymous2.Flags;
            set => Anonymous2.Flags = value;
        }
#endif

    }
}
