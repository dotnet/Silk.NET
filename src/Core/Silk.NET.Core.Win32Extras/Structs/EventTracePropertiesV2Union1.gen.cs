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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L1269_C5")]
    public unsafe partial struct EventTracePropertiesV2Union1
    {
        public EventTracePropertiesV2Union1
        (
            int? ageLimit = null,
            int? flushThreshold = null
        ) : this()
        {
            if (ageLimit is not null)
            {
                AgeLimit = ageLimit.Value;
            }

            if (flushThreshold is not null)
            {
                FlushThreshold = flushThreshold.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "AgeLimit")]
        public int AgeLimit;

        [FieldOffset(0)]
        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "FlushThreshold")]
        public int FlushThreshold;
    }
}
