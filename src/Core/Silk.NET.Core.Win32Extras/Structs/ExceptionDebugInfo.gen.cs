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
    [NativeName("Name", "_EXCEPTION_DEBUG_INFO")]
    public unsafe partial struct ExceptionDebugInfo
    {
        public ExceptionDebugInfo
        (
            ExceptionRecord? exceptionRecord = null,
            int? dwFirstChance = null
        ) : this()
        {
            if (exceptionRecord is not null)
            {
                ExceptionRecord = exceptionRecord.Value;
            }

            if (dwFirstChance is not null)
            {
                DwFirstChance = dwFirstChance.Value;
            }
        }


        [NativeName("Type", "EXCEPTION_RECORD")]
        [NativeName("Type.Name", "EXCEPTION_RECORD")]
        [NativeName("Name", "ExceptionRecord")]
        public ExceptionRecord ExceptionRecord;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFirstChance")]
        public int DwFirstChance;
    }
}
