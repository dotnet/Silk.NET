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
    [NativeName("Name", "_TRACE_PROFILE_INTERVAL")]
    public unsafe partial struct TraceProfileInterval
    {
        public TraceProfileInterval
        (
            uint? source = null,
            uint? interval = null
        ) : this()
        {
            if (source is not null)
            {
                Source = source.Value;
            }

            if (interval is not null)
            {
                Interval = interval.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Source")]
        public uint Source;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Interval")]
        public uint Interval;
    }
}
