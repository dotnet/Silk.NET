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
    [NativeName("Name", "__AnonymousRecord_evntrace_L937_C9")]
    public unsafe partial struct EventTraceHeaderUnion4Union1
    {
        public EventTraceHeaderUnion4Union1
        (
            uint? kernelTime = null,
            uint? userTime = null
        ) : this()
        {
            if (kernelTime is not null)
            {
                KernelTime = kernelTime.Value;
            }

            if (userTime is not null)
            {
                UserTime = userTime.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "KernelTime")]
        public uint KernelTime;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "UserTime")]
        public uint UserTime;
    }
}
