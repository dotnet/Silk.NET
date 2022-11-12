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
    [NativeName("Name", "_EXIT_THREAD_DEBUG_INFO")]
    public unsafe partial struct ExitThreadDebugInfo
    {
        public ExitThreadDebugInfo
        (
            int? dwExitCode = null
        ) : this()
        {
            if (dwExitCode is not null)
            {
                DwExitCode = dwExitCode.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwExitCode")]
        public int DwExitCode;
    }
}
