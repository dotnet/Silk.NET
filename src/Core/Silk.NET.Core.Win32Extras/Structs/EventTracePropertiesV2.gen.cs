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
    [NativeName("Name", "_EVENT_TRACE_PROPERTIES_V2")]
    public unsafe partial struct EventTracePropertiesV2
    {
        public EventTracePropertiesV2
        (
            WnodeHeader? wnode = null,
            uint? bufferSize = null,
            uint? minimumBuffers = null,
            uint? maximumBuffers = null,
            uint? maximumFileSize = null,
            uint? logFileMode = null,
            uint? flushTimer = null,
            uint? enableFlags = null,
            EventTracePropertiesV2Union1? anonymous1 = null,
            uint? numberOfBuffers = null,
            uint? freeBuffers = null,
            uint? eventsLost = null,
            uint? buffersWritten = null,
            uint? logBuffersLost = null,
            uint? realTimeBuffersLost = null,
            void* loggerThreadId = null,
            uint? logFileNameOffset = null,
            uint? loggerNameOffset = null,
            EventTracePropertiesV2Union2? anonymous2 = null,
            uint? filterDescCount = null,
            EventFilterDescriptor* filterDesc = null,
            EventTracePropertiesV2Union3? anonymous3 = null,
            int? ageLimit = null,
            int? flushThreshold = null,
            EventTracePropertiesV2Union2Union? anonymous = null,
            uint? v2Control = null,
            uint? versionNumber = null,
            ulong? v2Options = null,
            uint? wow = null,
            uint? qpcDeltaTracking = null,
            uint? largeMdlPages = null,
            uint? excludeKernelStack = null
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

            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
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

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (filterDescCount is not null)
            {
                FilterDescCount = filterDescCount.Value;
            }

            if (filterDesc is not null)
            {
                FilterDesc = filterDesc;
            }

            if (anonymous3 is not null)
            {
                Anonymous3 = anonymous3.Value;
            }

            if (ageLimit is not null)
            {
                AgeLimit = ageLimit.Value;
            }

            if (flushThreshold is not null)
            {
                FlushThreshold = flushThreshold.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (v2Control is not null)
            {
                V2Control = v2Control.Value;
            }

            if (versionNumber is not null)
            {
                VersionNumber = versionNumber.Value;
            }

            if (v2Options is not null)
            {
                V2Options = v2Options.Value;
            }

            if (wow is not null)
            {
                Wow = wow.Value;
            }

            if (qpcDeltaTracking is not null)
            {
                QpcDeltaTracking = qpcDeltaTracking.Value;
            }

            if (largeMdlPages is not null)
            {
                LargeMdlPages = largeMdlPages.Value;
            }

            if (excludeKernelStack is not null)
            {
                ExcludeKernelStack = excludeKernelStack.Value;
            }
        }


        [NativeName("Type", "WNODE_HEADER")]
        [NativeName("Type.Name", "WNODE_HEADER")]
        [NativeName("Name", "Wnode")]
        public WnodeHeader Wnode;

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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1269_C5")]
        [NativeName("Name", "anonymous1")]
        public EventTracePropertiesV2Union1 Anonymous1;

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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1286_C5")]
        [NativeName("Name", "anonymous2")]
        public EventTracePropertiesV2Union2 Anonymous2;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FilterDescCount")]
        public uint FilterDescCount;

        [NativeName("Type", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Type.Name", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Name", "FilterDesc")]
        public EventFilterDescriptor* FilterDesc;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1294_C5")]
        [NativeName("Name", "anonymous3")]
        public EventTracePropertiesV2Union3 Anonymous3;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int AgeLimit
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].AgeLimit;
        }
#else
        public int AgeLimit
        {
            get => Anonymous1.AgeLimit;
            set => Anonymous1.AgeLimit = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int FlushThreshold
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].FlushThreshold;
        }
#else
        public int FlushThreshold
        {
            get => Anonymous1.FlushThreshold;
            set => Anonymous1.FlushThreshold = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref EventTracePropertiesV2Union2Union Anonymous
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Anonymous;
        }
#else
        public EventTracePropertiesV2Union2Union Anonymous
        {
            get => Anonymous2.Anonymous;
            set => Anonymous2.Anonymous = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint V2Control
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].V2Control;
        }
#else
        public uint V2Control
        {
            get => Anonymous2.V2Control;
            set => Anonymous2.V2Control = value;
        }
#endif

        public uint VersionNumber
        {
            get => Anonymous2.VersionNumber;
            set => Anonymous2.VersionNumber = value;
        }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong V2Options
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous3, 1)[0].V2Options;
        }
#else
        public ulong V2Options
        {
            get => Anonymous3.V2Options;
            set => Anonymous3.V2Options = value;
        }
#endif

        public uint Wow
        {
            get => Anonymous3.Wow;
            set => Anonymous3.Wow = value;
        }

        public uint QpcDeltaTracking
        {
            get => Anonymous3.QpcDeltaTracking;
            set => Anonymous3.QpcDeltaTracking = value;
        }

        public uint LargeMdlPages
        {
            get => Anonymous3.LargeMdlPages;
            set => Anonymous3.LargeMdlPages = value;
        }

        public uint ExcludeKernelStack
        {
            get => Anonymous3.ExcludeKernelStack;
            set => Anonymous3.ExcludeKernelStack = value;
        }

    }
}
