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
    [NativeName("Name", "__AnonymousRecord_evntrace_L961_C5")]
    public unsafe partial struct EventInstanceHeaderUnion2
    {
        public EventInstanceHeaderUnion2
        (
            uint? version = null,
            EventInstanceHeaderUnion2Class? @class = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (@class is not null)
            {
                Class = @class.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Version")]
        public uint Version;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\shared\\evntrace.h:963:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\shared\\evntrace.h:963:9)")]
        [NativeName("Name", "Class")]
        public EventInstanceHeaderUnion2Class Class;
    }
}
