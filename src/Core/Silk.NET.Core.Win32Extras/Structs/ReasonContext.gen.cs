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
    [NativeName("Name", "_REASON_CONTEXT")]
    public unsafe partial struct ReasonContext
    {
        public ReasonContext
        (
            uint? version = null,
            uint? flags = null,
            ReasonContextReason? reason = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (reason is not null)
            {
                Reason = reason.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Version")]
        public uint Version;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "union (unnamed union at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:276:5)")]
        [NativeName("Type.Name", "union (unnamed union at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:276:5)")]
        [NativeName("Name", "Reason")]
        public ReasonContextReason Reason;
    }
}
