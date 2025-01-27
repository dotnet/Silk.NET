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
    [NativeName("Name", "_EVENT_INSTANCE_HEADER")]
    public unsafe partial struct EventInstanceHeader
    {
        public EventInstanceHeader
        (
            ushort? size = null,
            EventInstanceHeaderUnion1? anonymous1 = null,
            EventInstanceHeaderUnion2? anonymous2 = null,
            uint? threadId = null,
            uint? processId = null,
            long? timeStamp = null,
            ulong? regHandle = null,
            uint? instanceId = null,
            uint? parentInstanceId = null,
            EventInstanceHeaderUnion3? anonymous3 = null,
            ulong? parentRegHandle = null,
            ushort? fieldTypeFlags = null,
            EventInstanceHeaderUnion1Union? anonymous = null,
            byte? headerType = null,
            byte? markerFlags = null,
            uint? version = null,
            EventInstanceHeaderUnion2Class? @class = null,
            ulong? processorTime = null,
            uint? kernelTime = null,
            uint? userTime = null,
            uint? eventId = null,
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

            if (regHandle is not null)
            {
                RegHandle = regHandle.Value;
            }

            if (instanceId is not null)
            {
                InstanceId = instanceId.Value;
            }

            if (parentInstanceId is not null)
            {
                ParentInstanceId = parentInstanceId.Value;
            }

            if (anonymous3 is not null)
            {
                Anonymous3 = anonymous3.Value;
            }

            if (parentRegHandle is not null)
            {
                ParentRegHandle = parentRegHandle.Value;
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

            if (eventId is not null)
            {
                EventId = eventId.Value;
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
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L954_C5")]
        [NativeName("Name", "anonymous1")]
        public EventInstanceHeaderUnion1 Anonymous1;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L961_C5")]
        [NativeName("Name", "anonymous2")]
        public EventInstanceHeaderUnion2 Anonymous2;

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

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "RegHandle")]
        public ulong RegHandle;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "InstanceId")]
        public uint InstanceId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ParentInstanceId")]
        public uint ParentInstanceId;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L975_C5")]
        [NativeName("Name", "anonymous3")]
        public EventInstanceHeaderUnion3 Anonymous3;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ParentRegHandle")]
        public ulong ParentRegHandle;
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
        public ref EventInstanceHeaderUnion1Union Anonymous
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Anonymous;
        }
#else
        public EventInstanceHeaderUnion1Union Anonymous
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
        public ref EventInstanceHeaderUnion2Class Class
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Class;
        }
#else
        public EventInstanceHeaderUnion2Class Class
        {
            get => Anonymous2.Class;
            set => Anonymous2.Class = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong ProcessorTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].ProcessorTime;
        }
#else
        public ulong ProcessorTime
        {
            get => Anonymous3.ProcessorTime;
            set => Anonymous3.ProcessorTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint KernelTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].KernelTime;
        }
#else
        public uint KernelTime
        {
            get => Anonymous3.KernelTime;
            set => Anonymous3.KernelTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint UserTime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].UserTime;
        }
#else
        public uint UserTime
        {
            get => Anonymous3.UserTime;
            set => Anonymous3.UserTime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint EventId
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].EventId;
        }
#else
        public uint EventId
        {
            get => Anonymous3.EventId;
            set => Anonymous3.EventId = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Flags
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].Flags;
        }
#else
        public uint Flags
        {
            get => Anonymous3.Flags;
            set => Anonymous3.Flags = value;
        }
#endif

    }
}
