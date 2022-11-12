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

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2_DEBUG_CONFIGURATION")]
    public unsafe partial struct DebugConfiguration
    {
        public DebugConfiguration
        (
            uint? traceMask = null,
            uint? breakMask = null,
            bool? logThreadID = null,
            bool? logFileline = null,
            bool? logFunctionName = null,
            bool? logTiming = null
        ) : this()
        {
            if (traceMask is not null)
            {
                TraceMask = traceMask.Value;
            }

            if (breakMask is not null)
            {
                BreakMask = breakMask.Value;
            }

            if (logThreadID is not null)
            {
                LogThreadID = logThreadID.Value;
            }

            if (logFileline is not null)
            {
                LogFileline = logFileline.Value;
            }

            if (logFunctionName is not null)
            {
                LogFunctionName = logFunctionName.Value;
            }

            if (logTiming is not null)
            {
                LogTiming = logTiming.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "TraceMask")]
        public uint TraceMask;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "BreakMask")]
        public uint BreakMask;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogThreadID")]
        public bool LogThreadID;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogFileline")]
        public bool LogFileline;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogFunctionName")]
        public bool LogFunctionName;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "LogTiming")]
        public bool LogTiming;
    }
}
