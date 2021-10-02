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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L926_C5")]
    public unsafe partial struct EventTracePropertiesV2Union3
    {
        public EventTracePropertiesV2Union3
        (
            ulong? v2Options = null
        ) : this()
        {
            if (v2Options is not null)
            {
                V2Options = v2Options.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "V2Options")]
        public ulong V2Options;
    }
}
