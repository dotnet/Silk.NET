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
    [NativeName("Name", "__AnonymousRecord_evntrace_L923_C9")]
    public unsafe partial struct EventTraceHeaderUnion2Class
    {
        public EventTraceHeaderUnion2Class
        (
            byte? type = null,
            byte? level = null,
            ushort? version = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Type")]
        public byte Type;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Level")]
        public byte Level;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Version")]
        public ushort Version;
    }
}
