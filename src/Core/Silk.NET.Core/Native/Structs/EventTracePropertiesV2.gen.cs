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
    [NativeName("Name", "_EVENT_TRACE_PROPERTIES_V2")]
    public unsafe partial struct EventTracePropertiesV2
    {
        public EventTracePropertiesV2
        (
            _WNODE_HEADER? wnode = null,
            uint? bufferSize = null,
            uint? minimumBuffers = null,
            uint? maximumBuffers = null,
            uint? maximumFileSize = null,
            uint? logFileMode = null,
            uint? flushTimer = null,
            uint? enableFlags = null,
            uint? numberOfBuffers = null,
            uint? freeBuffers = null,
            uint? eventsLost = null,
            uint? buffersWritten = null,
            uint? logBuffersLost = null,
            uint? realTimeBuffersLost = null,
            void* loggerThreadId = null,
            uint? logFileNameOffset = null,
            uint? loggerNameOffset = null,
            uint? filterDescCount = null,
            EventFilterDescriptor* filterDesc = null
        ) : this()
        {
            if (wnode is not null)
            {
                Wnode = wnode.Value;
            }

            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }

            if (minimumBuffers is not null)
            {
                MinimumBuffers = minimumBuffers.Value;
            }

            if (maximumBuffers is not null)
            {
                MaximumBuffers = maximumBuffers.Value;
            }

            if (maximumFileSize is not null)
            {
                MaximumFileSize = maximumFileSize.Value;
            }

            if (logFileMode is not null)
            {
                LogFileMode = logFileMode.Value;
            }

            if (flushTimer is not null)
            {
                FlushTimer = flushTimer.Value;
            }

            if (enableFlags is not null)
            {
                EnableFlags = enableFlags.Value;
            }

            if (numberOfBuffers is not null)
            {
                NumberOfBuffers = numberOfBuffers.Value;
            }

            if (freeBuffers is not null)
            {
                FreeBuffers = freeBuffers.Value;
            }

            if (eventsLost is not null)
            {
                EventsLost = eventsLost.Value;
            }

            if (buffersWritten is not null)
            {
                BuffersWritten = buffersWritten.Value;
            }

            if (logBuffersLost is not null)
            {
                LogBuffersLost = logBuffersLost.Value;
            }

            if (realTimeBuffersLost is not null)
            {
                RealTimeBuffersLost = realTimeBuffersLost.Value;
            }

            if (loggerThreadId is not null)
            {
                LoggerThreadId = loggerThreadId;
            }

            if (logFileNameOffset is not null)
            {
                LogFileNameOffset = logFileNameOffset.Value;
            }

            if (loggerNameOffset is not null)
            {
                LoggerNameOffset = loggerNameOffset.Value;
            }

            if (filterDescCount is not null)
            {
                FilterDescCount = filterDescCount.Value;
            }

            if (filterDesc is not null)
            {
                FilterDesc = filterDesc;
            }
        }


        [NativeName("Type", "WNODE_HEADER")]
        [NativeName("Type.Name", "WNODE_HEADER")]
        [NativeName("Name", "Wnode")]
        public _WNODE_HEADER Wnode;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BufferSize")]
        public uint BufferSize;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MinimumBuffers")]
        public uint MinimumBuffers;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MaximumBuffers")]
        public uint MaximumBuffers;

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
        [NativeName("Name", "FlushTimer")]
        public uint FlushTimer;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableFlags")]
        public uint EnableFlags;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NumberOfBuffers")]
        public uint NumberOfBuffers;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FreeBuffers")]
        public uint FreeBuffers;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EventsLost")]
        public uint EventsLost;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BuffersWritten")]
        public uint BuffersWritten;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LogBuffersLost")]
        public uint LogBuffersLost;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "RealTimeBuffersLost")]
        public uint RealTimeBuffersLost;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "LoggerThreadId")]
        public void* LoggerThreadId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LogFileNameOffset")]
        public uint LogFileNameOffset;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LoggerNameOffset")]
        public uint LoggerNameOffset;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FilterDescCount")]
        public uint FilterDescCount;

        [NativeName("Type", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Type.Name", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Name", "FilterDesc")]
        public EventFilterDescriptor* FilterDesc;
    }
}
