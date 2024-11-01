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
    [NativeName("Name", "__AnonymousRecord_minwinbase_L373_C5")]
    public unsafe partial struct DebugEventU
    {
        public DebugEventU
        (
            ExceptionDebugInfo? exception = null,
            CreateThreadDebugInfo? createThread = null,
            CreateProcessDebugInfo? createProcessInfo = null,
            ExitThreadDebugInfo? exitThread = null,
            ExitProcessDebugInfo? exitProcess = null,
            LoadDllDebugInfo? loadDll = null,
            UnloadDllDebugInfo? unloadDll = null,
            OutputDebugStringInfo? debugString = null,
            RipInfo? ripInfo = null
        ) : this()
        {
            if (exception is not null)
            {
                Exception = exception.Value;
            }

            if (createThread is not null)
            {
                CreateThread = createThread.Value;
            }

            if (createProcessInfo is not null)
            {
                CreateProcessInfo = createProcessInfo.Value;
            }

            if (exitThread is not null)
            {
                ExitThread = exitThread.Value;
            }

            if (exitProcess is not null)
            {
                ExitProcess = exitProcess.Value;
            }

            if (loadDll is not null)
            {
                LoadDll = loadDll.Value;
            }

            if (unloadDll is not null)
            {
                UnloadDll = unloadDll.Value;
            }

            if (debugString is not null)
            {
                DebugString = debugString.Value;
            }

            if (ripInfo is not null)
            {
                RipInfo = ripInfo.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "EXCEPTION_DEBUG_INFO")]
        [NativeName("Type.Name", "EXCEPTION_DEBUG_INFO")]
        [NativeName("Name", "Exception")]
        public ExceptionDebugInfo Exception;

        [FieldOffset(0)]
        [NativeName("Type", "CREATE_THREAD_DEBUG_INFO")]
        [NativeName("Type.Name", "CREATE_THREAD_DEBUG_INFO")]
        [NativeName("Name", "CreateThread")]
        public CreateThreadDebugInfo CreateThread;

        [FieldOffset(0)]
        [NativeName("Type", "CREATE_PROCESS_DEBUG_INFO")]
        [NativeName("Type.Name", "CREATE_PROCESS_DEBUG_INFO")]
        [NativeName("Name", "CreateProcessInfo")]
        public CreateProcessDebugInfo CreateProcessInfo;

        [FieldOffset(0)]
        [NativeName("Type", "EXIT_THREAD_DEBUG_INFO")]
        [NativeName("Type.Name", "EXIT_THREAD_DEBUG_INFO")]
        [NativeName("Name", "ExitThread")]
        public ExitThreadDebugInfo ExitThread;

        [FieldOffset(0)]
        [NativeName("Type", "EXIT_PROCESS_DEBUG_INFO")]
        [NativeName("Type.Name", "EXIT_PROCESS_DEBUG_INFO")]
        [NativeName("Name", "ExitProcess")]
        public ExitProcessDebugInfo ExitProcess;

        [FieldOffset(0)]
        [NativeName("Type", "LOAD_DLL_DEBUG_INFO")]
        [NativeName("Type.Name", "LOAD_DLL_DEBUG_INFO")]
        [NativeName("Name", "LoadDll")]
        public LoadDllDebugInfo LoadDll;

        [FieldOffset(0)]
        [NativeName("Type", "UNLOAD_DLL_DEBUG_INFO")]
        [NativeName("Type.Name", "UNLOAD_DLL_DEBUG_INFO")]
        [NativeName("Name", "UnloadDll")]
        public UnloadDllDebugInfo UnloadDll;

        [FieldOffset(0)]
        [NativeName("Type", "OUTPUT_DEBUG_STRING_INFO")]
        [NativeName("Type.Name", "OUTPUT_DEBUG_STRING_INFO")]
        [NativeName("Name", "DebugString")]
        public OutputDebugStringInfo DebugString;

        [FieldOffset(0)]
        [NativeName("Type", "RIP_INFO")]
        [NativeName("Type.Name", "RIP_INFO")]
        [NativeName("Name", "RipInfo")]
        public RipInfo RipInfo;
    }
}
