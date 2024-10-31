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
    [NativeName("Name", "_EVENT_TRACE_HEADER")]
    public unsafe partial struct EventTraceHeader
    {
        public EventTraceHeader
        (
            ushort? size = null,
            EventTraceHeaderUnion1? anonymous1 = null,
            EventTraceHeaderUnion2? anonymous2 = null,
            uint? threadId = null,
            uint? processId = null,
            long? timeStamp = null,
            EventTraceHeaderUnion3? anonymous3 = null,
            EventTraceHeaderUnion4? anonymous4 = null,
            ushort? fieldTypeFlags = null,
            EventTraceHeaderUnion1Union? anonymous = null,
            byte? headerType = null,
            byte? markerFlags = null,
            uint? version = null,
            EventTraceHeaderUnion2Class? @class = null,
            Guid? guid = null,
            ulong? guidPtr = null,
            ulong? processorTime = null,
            uint? kernelTime = null,
            uint? userTime = null,
            uint? clientContext = null,
            uint? flags = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
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

            if (anonymous3 is not null)
            {
                Anonymous3 = anonymous3.Value;
            }

            if (anonymous4 is not null)
            {
                Anonymous4 = anonymous4.Value;
            }

            if (fieldTypeFlags is not null)
            {
                FieldTypeFlags = fieldTypeFlags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (headerType is not null)
            {
                HeaderType = headerType.Value;
            }

            if (markerFlags is not null)
            {
                MarkerFlags = markerFlags.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (@class is not null)
            {
                Class = @class.Value;
            }

            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (guidPtr is not null)
            {
                GuidPtr = guidPtr.Value;
            }

            if (processorTime is not null)
            {
                ProcessorTime = processorTime.Value;
            }

            if (kernelTime is not null)
            {
                KernelTime = kernelTime.Value;
            }

            if (userTime is not null)
            {
                UserTime = userTime.Value;
            }

            if (clientContext is not null)
            {
                ClientContext = clientContext.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Size")]
        public ushort Size;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L914_C5")]
        [NativeName("Name", "anonymous1")]
        public EventTraceHeaderUnion1 Anonymous1;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L921_C5")]
        [NativeName("Name", "anonymous2")]
        public EventTraceHeaderUnion2 Anonymous2;

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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L932_C5")]
        [NativeName("Name", "anonymous3")]
        public EventTraceHeaderUnion3 Anonymous3;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L936_C5")]
        [NativeName("Name", "anonymous4")]
        public EventTraceHeaderUnion4 Anonymous4;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort FieldTypeFlags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].FieldTypeFlags;
        }
#else
        public ushort FieldTypeFlags
        {
            get => Anonymous1.FieldTypeFlags;
            set => Anonymous1.FieldTypeFlags = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref EventTraceHeaderUnion1Union Anonymous
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Anonymous;
        }
#else
        public EventTraceHeaderUnion1Union Anonymous
        {
            get => Anonymous1.Anonymous;
            set => Anonymous1.Anonymous = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte HeaderType
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].HeaderType;
        }
#else
        public byte HeaderType
        {
            get => Anonymous1.HeaderType;
            set => Anonymous1.HeaderType = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte MarkerFlags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].MarkerFlags;
        }
#else
        public byte MarkerFlags
        {
            get => Anonymous1.MarkerFlags;
            set => Anonymous1.MarkerFlags = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Version
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Version;
        }
#else
        public uint Version
        {
            get => Anonymous2.Version;
            set => Anonymous2.Version = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref EventTraceHeaderUnion2Class Class
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Class;
        }
#else
        public EventTraceHeaderUnion2Class Class
        {
            get => Anonymous2.Class;
            set => Anonymous2.Class = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Guid Guid
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].Guid;
        }
#else
        public Guid Guid
        {
            get => Anonymous3.Guid;
            set => Anonymous3.Guid = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong GuidPtr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].GuidPtr;
        }
#else
        public ulong GuidPtr
        {
            get => Anonymous3.GuidPtr;
            set => Anonymous3.GuidPtr = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong ProcessorTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous4, 1)[0].ProcessorTime;
        }
#else
        public ulong ProcessorTime
        {
            get => Anonymous4.ProcessorTime;
            set => Anonymous4.ProcessorTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint KernelTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous4, 1)[0].KernelTime;
        }
#else
        public uint KernelTime
        {
            get => Anonymous4.KernelTime;
            set => Anonymous4.KernelTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint UserTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous4, 1)[0].UserTime;
        }
#else
        public uint UserTime
        {
            get => Anonymous4.UserTime;
            set => Anonymous4.UserTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint ClientContext
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous4, 1)[0].ClientContext;
        }
#else
        public uint ClientContext
        {
            get => Anonymous4.ClientContext;
            set => Anonymous4.ClientContext = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Flags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous4, 1)[0].Flags;
        }
#else
        public uint Flags
        {
            get => Anonymous4.Flags;
            set => Anonymous4.Flags = value;
        }
#endif

    }
}
