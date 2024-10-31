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
    [NativeName("Name", "ETW_BUFFER_CALLBACK_INFORMATION")]
    public unsafe partial struct EtwBufferCallbackInformation
    {
        public EtwBufferCallbackInformation
        (
            ulong? traceHandle = null,
            TraceLogfileHeader* logfileHeader = null,
            uint? buffersRead = null
        ) : this()
        {
            if (traceHandle is not null)
            {
                TraceHandle = traceHandle.Value;
            }

            if (logfileHeader is not null)
            {
                LogfileHeader = logfileHeader;
            }

            if (buffersRead is not null)
            {
                BuffersRead = buffersRead.Value;
            }
        }


        [NativeName("Type", "PROCESSTRACE_HANDLE")]
        [NativeName("Type.Name", "PROCESSTRACE_HANDLE")]
        [NativeName("Name", "TraceHandle")]
        public ulong TraceHandle;

        [NativeName("Type", "const TRACE_LOGFILE_HEADER *")]
        [NativeName("Type.Name", "const TRACE_LOGFILE_HEADER *")]
        [NativeName("Name", "LogfileHeader")]
        public TraceLogfileHeader* LogfileHeader;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BuffersRead")]
        public uint BuffersRead;
    }
}
