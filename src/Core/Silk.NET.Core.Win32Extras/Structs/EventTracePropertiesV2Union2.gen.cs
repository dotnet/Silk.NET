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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1286_C5")]
    public unsafe partial struct EventTracePropertiesV2Union2
    {
        public EventTracePropertiesV2Union2
        (
            EventTracePropertiesV2Union2Union? anonymous = null,
            uint? v2Control = null,
            uint? versionNumber = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (v2Control is not null)
            {
                V2Control = v2Control.Value;
            }

            if (versionNumber is not null)
            {
                VersionNumber = versionNumber.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1287_C9")]
        [NativeName("Name", "anonymous1")]
        public EventTracePropertiesV2Union2Union Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "V2Control")]
        public uint V2Control;
        public uint VersionNumber
        {
            get => Anonymous.VersionNumber;
            set => Anonymous.VersionNumber = value;
        }

    }
}
