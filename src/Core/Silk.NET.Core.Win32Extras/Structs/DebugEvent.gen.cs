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
    [NativeName("Name", "_DEBUG_EVENT")]
    public unsafe partial struct DebugEvent
    {
        public DebugEvent
        (
            uint? dwDebugEventCode = null,
            uint? dwProcessId = null,
            uint? dwThreadId = null,
            DebugEventU? u = null
        ) : this()
        {
            if (dwDebugEventCode is not null)
            {
                DwDebugEventCode = dwDebugEventCode.Value;
            }

            if (dwProcessId is not null)
            {
                DwProcessId = dwProcessId.Value;
            }

            if (dwThreadId is not null)
            {
                DwThreadId = dwThreadId.Value;
            }

            if (u is not null)
            {
                U = u.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwDebugEventCode")]
        public uint DwDebugEventCode;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwProcessId")]
        public uint DwProcessId;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwThreadId")]
        public uint DwThreadId;

        [NativeName("Type", "union (unnamed union at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:373:5)")]
        [NativeName("Type.Name", "union (unnamed union at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:373:5)")]
        [NativeName("Name", "u")]
        public DebugEventU U;
    }
}
