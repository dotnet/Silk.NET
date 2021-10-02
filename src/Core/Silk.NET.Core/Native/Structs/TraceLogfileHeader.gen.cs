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
    [NativeName("Name", "_TRACE_LOGFILE_HEADER")]
    public unsafe partial struct TraceLogfileHeader
    {
        public TraceLogfileHeader
        (
            uint? bufferSize = null,
            uint? providerVersion = null,
            uint? numberOfProcessors = null,
            long? endTime = null,
            uint? timerResolution = null,
            uint? maximumFileSize = null,
            uint? logFileMode = null,
            uint? buffersWritten = null,
            char* loggerName = null,
            char* logFileName = null,
            _TIME_ZONE_INFORMATION? timeZone = null,
            long? bootTime = null,
            long? perfFreq = null,
            long? startTime = null,
            uint? reservedFlags = null,
            uint? buffersLost = null
        ) : this()
        {
            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
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

            if (loggerName is not null)
            {
                LoggerName = loggerName;
            }

            if (logFileName is not null)
            {
                LogFileName = logFileName;
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
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BufferSize")]
        public uint BufferSize;

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

        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "LoggerName")]
        public char* LoggerName;

        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "LogFileName")]
        public char* LogFileName;

        [NativeName("Type", "TIME_ZONE_INFORMATION")]
        [NativeName("Type.Name", "TIME_ZONE_INFORMATION")]
        [NativeName("Name", "TimeZone")]
        public _TIME_ZONE_INFORMATION TimeZone;

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
    }
}
