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
    [NativeName("Name", "_EVENT_TRACE_LOGFILEA")]
    public unsafe partial struct EventTraceLogfilea
    {
        public EventTraceLogfilea
        (
            byte* logFileName = null,
            byte* loggerName = null,
            long? currentTime = null,
            uint? buffersRead = null,
            EventTrace? currentEvent = null,
            TraceLogfileHeader? logfileHeader = null,
            PfnPeventTraceBufferCallbacka? bufferCallback = null,
            uint? bufferSize = null,
            uint? filled = null,
            uint? eventsLost = null,
            uint? isKernelTrace = null,
            void* context = null
        ) : this()
        {
            if (logFileName is not null)
            {
                LogFileName = logFileName;
            }

            if (loggerName is not null)
            {
                LoggerName = loggerName;
            }

            if (currentTime is not null)
            {
                CurrentTime = currentTime.Value;
            }

            if (buffersRead is not null)
            {
                BuffersRead = buffersRead.Value;
            }

            if (currentEvent is not null)
            {
                CurrentEvent = currentEvent.Value;
            }

            if (logfileHeader is not null)
            {
                LogfileHeader = logfileHeader.Value;
            }

            if (bufferCallback is not null)
            {
                BufferCallback = bufferCallback.Value;
            }

            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }

            if (filled is not null)
            {
                Filled = filled.Value;
            }

            if (eventsLost is not null)
            {
                EventsLost = eventsLost.Value;
            }

            if (isKernelTrace is not null)
            {
                IsKernelTrace = isKernelTrace.Value;
            }

            if (context is not null)
            {
                Context = context;
            }
        }


        [NativeName("Type", "LPSTR")]
        [NativeName("Type.Name", "LPSTR")]
        [NativeName("Name", "LogFileName")]
        public byte* LogFileName;

        [NativeName("Type", "LPSTR")]
        [NativeName("Type.Name", "LPSTR")]
        [NativeName("Name", "LoggerName")]
        public byte* LoggerName;

        [NativeName("Type", "LONGLONG")]
        [NativeName("Type.Name", "LONGLONG")]
        [NativeName("Name", "CurrentTime")]
        public long CurrentTime;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BuffersRead")]
        public uint BuffersRead;

        [NativeName("Type", "EVENT_TRACE")]
        [NativeName("Type.Name", "EVENT_TRACE")]
        [NativeName("Name", "CurrentEvent")]
        public EventTrace CurrentEvent;

        [NativeName("Type", "TRACE_LOGFILE_HEADER")]
        [NativeName("Type.Name", "TRACE_LOGFILE_HEADER")]
        [NativeName("Name", "LogfileHeader")]
        public TraceLogfileHeader LogfileHeader;

        [NativeName("Type", "PEVENT_TRACE_BUFFER_CALLBACKA")]
        [NativeName("Type.Name", "PEVENT_TRACE_BUFFER_CALLBACKA")]
        [NativeName("Name", "BufferCallback")]
        public PfnPeventTraceBufferCallbacka BufferCallback;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BufferSize")]
        public uint BufferSize;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Filled")]
        public uint Filled;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EventsLost")]
        public uint EventsLost;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "IsKernelTrace")]
        public uint IsKernelTrace;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "Context")]
        public void* Context;
    }
}
