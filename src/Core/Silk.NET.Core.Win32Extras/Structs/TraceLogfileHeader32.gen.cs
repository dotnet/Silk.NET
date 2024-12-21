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
    [NativeName("Name", "_TRACE_LOGFILE_HEADER32")]
    public unsafe partial struct TraceLogfileHeader32
    {
        public TraceLogfileHeader32
        (
            uint? bufferSize = null,
            TraceLogfileHeader32Union1? anonymous1 = null,
            uint? providerVersion = null,
            uint? numberOfProcessors = null,
            long? endTime = null,
            uint? timerResolution = null,
            uint? maximumFileSize = null,
            uint? logFileMode = null,
            uint? buffersWritten = null,
            TraceLogfileHeader32Union2? anonymous2 = null,
            uint? loggerName = null,
            uint? logFileName = null,
            TimeZoneInformation? timeZone = null,
            long? bootTime = null,
            long? perfFreq = null,
            long? startTime = null,
            uint? reservedFlags = null,
            uint? buffersLost = null,
            uint? version = null,
            TraceLogfileHeader32Union1VersionDetail? versionDetail = null,
            Guid? logInstanceGuid = null,
            TraceLogfileHeader32Union2Union? anonymous = null,
            uint? startBuffers = null,
            uint? pointerSize = null,
            uint? eventsLost = null,
            uint? cpuSpeedInMHz = null
        ) : this()
        {
            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }

            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (providerVersion is not null)
            {
                ProviderVersion = providerVersion.Value;
            }

            if (numberOfProcessors is not null)
            {
                NumberOfProcessors = numberOfProcessors.Value;
            }

            if (endTime is not null)
            {
                EndTime = endTime.Value;
            }

            if (timerResolution is not null)
            {
                TimerResolution = timerResolution.Value;
            }

            if (maximumFileSize is not null)
            {
                MaximumFileSize = maximumFileSize.Value;
            }

            if (logFileMode is not null)
            {
                LogFileMode = logFileMode.Value;
            }

            if (buffersWritten is not null)
            {
                BuffersWritten = buffersWritten.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (loggerName is not null)
            {
                LoggerName = loggerName.Value;
            }

            if (logFileName is not null)
            {
                LogFileName = logFileName.Value;
            }

            if (timeZone is not null)
            {
                TimeZone = timeZone.Value;
            }

            if (bootTime is not null)
            {
                BootTime = bootTime.Value;
            }

            if (perfFreq is not null)
            {
                PerfFreq = perfFreq.Value;
            }

            if (startTime is not null)
            {
                StartTime = startTime.Value;
            }

            if (reservedFlags is not null)
            {
                ReservedFlags = reservedFlags.Value;
            }

            if (buffersLost is not null)
            {
                BuffersLost = buffersLost.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (versionDetail is not null)
            {
                VersionDetail = versionDetail.Value;
            }

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


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BufferSize")]
        public uint BufferSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1110_C5")]
        [NativeName("Name", "anonymous1")]
        public TraceLogfileHeader32Union1 Anonymous1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProviderVersion")]
        public uint ProviderVersion;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NumberOfProcessors")]
        public uint NumberOfProcessors;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "EndTime")]
        public long EndTime;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "TimerResolution")]
        public uint TimerResolution;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MaximumFileSize")]
        public uint MaximumFileSize;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LogFileMode")]
        public uint LogFileMode;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BuffersWritten")]
        public uint BuffersWritten;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1126_C5")]
        [NativeName("Name", "anonymous2")]
        public TraceLogfileHeader32Union2 Anonymous2;

        [NativeName("Type", "ULONG32")]
        [NativeName("Type.Name", "ULONG32")]
        [NativeName("Name", "LoggerName")]
        public uint LoggerName;

        [NativeName("Type", "ULONG32")]
        [NativeName("Type.Name", "ULONG32")]
        [NativeName("Name", "LogFileName")]
        public uint LogFileName;

        [NativeName("Type", "TIME_ZONE_INFORMATION")]
        [NativeName("Type.Name", "TIME_ZONE_INFORMATION")]
        [NativeName("Name", "TimeZone")]
        public TimeZoneInformation TimeZone;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "BootTime")]
        public long BootTime;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "PerfFreq")]
        public long PerfFreq;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "StartTime")]
        public long StartTime;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ReservedFlags")]
        public uint ReservedFlags;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BuffersLost")]
        public uint BuffersLost;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Version
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Version;
        }
#else
        public uint Version
        {
            get => Anonymous1.Version;
            set => Anonymous1.Version = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TraceLogfileHeader32Union1VersionDetail VersionDetail
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].VersionDetail;
        }
#else
        public TraceLogfileHeader32Union1VersionDetail VersionDetail
        {
            get => Anonymous1.VersionDetail;
            set => Anonymous1.VersionDetail = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Guid LogInstanceGuid
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].LogInstanceGuid;
        }
#else
        public Guid LogInstanceGuid
        {
            get => Anonymous2.LogInstanceGuid;
            set => Anonymous2.LogInstanceGuid = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TraceLogfileHeader32Union2Union Anonymous
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Anonymous;
        }
#else
        public TraceLogfileHeader32Union2Union Anonymous
        {
            get => Anonymous2.Anonymous;
            set => Anonymous2.Anonymous = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint StartBuffers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].StartBuffers;
        }
#else
        public uint StartBuffers
        {
            get => Anonymous2.StartBuffers;
            set => Anonymous2.StartBuffers = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint PointerSize
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].PointerSize;
        }
#else
        public uint PointerSize
        {
            get => Anonymous2.PointerSize;
            set => Anonymous2.PointerSize = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint EventsLost
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].EventsLost;
        }
#else
        public uint EventsLost
        {
            get => Anonymous2.EventsLost;
            set => Anonymous2.EventsLost = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint CpuSpeedInMHz
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].CpuSpeedInMHz;
        }
#else
        public uint CpuSpeedInMHz
        {
            get => Anonymous2.CpuSpeedInMHz;
            set => Anonymous2.CpuSpeedInMHz = value;
        }
#endif

    }
}
