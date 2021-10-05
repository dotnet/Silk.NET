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
    [NativeName("Name", "_TRACE_ENABLE_INFO")]
    public unsafe partial struct TraceEnableInfo
    {
        public TraceEnableInfo
        (
            uint? isEnabled = null,
            byte? level = null,
            byte? reserved1 = null,
            ushort? loggerId = null,
            uint? enableProperty = null,
            uint? reserved2 = null,
            ulong? matchAnyKeyword = null,
            ulong? matchAllKeyword = null
        ) : this()
        {
            if (isEnabled is not null)
            {
                IsEnabled = isEnabled.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (loggerId is not null)
            {
                LoggerId = loggerId.Value;
            }

            if (enableProperty is not null)
            {
                EnableProperty = enableProperty.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (matchAnyKeyword is not null)
            {
                MatchAnyKeyword = matchAnyKeyword.Value;
            }

            if (matchAllKeyword is not null)
            {
                MatchAllKeyword = matchAllKeyword.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "IsEnabled")]
        public uint IsEnabled;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Level")]
        public byte Level;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Reserved1")]
        public byte Reserved1;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "LoggerId")]
        public ushort LoggerId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableProperty")]
        public uint EnableProperty;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Reserved2")]
        public uint Reserved2;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "MatchAnyKeyword")]
        public ulong MatchAnyKeyword;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "MatchAllKeyword")]
        public ulong MatchAllKeyword;
    }
}
