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
    [NativeName("Name", "_CREATE_THREAD_DEBUG_INFO")]
    public unsafe partial struct CreateThreadDebugInfo
    {
        public CreateThreadDebugInfo
        (
            void* hThread = null,
            void* lpThreadLocalBase = null,
            PfnPthreadStartRoutine? lpStartAddress = null
        ) : this()
        {
            if (hThread is not null)
            {
                HThread = hThread;
            }

            if (lpThreadLocalBase is not null)
            {
                LpThreadLocalBase = lpThreadLocalBase;
            }

            if (lpStartAddress is not null)
            {
                LpStartAddress = lpStartAddress.Value;
            }
        }


        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hThread")]
        public void* HThread;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpThreadLocalBase")]
        public void* LpThreadLocalBase;

        [NativeName("Type", "LPTHREAD_START_ROUTINE")]
        [NativeName("Type.Name", "LPTHREAD_START_ROUTINE")]
        [NativeName("Name", "lpStartAddress")]
        public PfnPthreadStartRoutine LpStartAddress;
    }
}
