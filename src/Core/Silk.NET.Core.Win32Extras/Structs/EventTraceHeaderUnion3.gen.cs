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
    [NativeName("Name", "__AnonymousRecord_evntrace_L932_C5")]
    public unsafe partial struct EventTraceHeaderUnion3
    {
        public EventTraceHeaderUnion3
        (
            Guid? guid = null,
            ulong? guidPtr = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (guidPtr is not null)
            {
                GuidPtr = guidPtr.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Guid")]
        public Guid Guid;

        [FieldOffset(0)]
        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "GuidPtr")]
        public ulong GuidPtr;
    }
}
