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
    [NativeName("Name", "_LOAD_DLL_DEBUG_INFO")]
    public unsafe partial struct LoadDllDebugInfo
    {
        public LoadDllDebugInfo
        (
            void* hFile = null,
            void* lpBaseOfDll = null,
            uint? dwDebugInfoFileOffset = null,
            uint? nDebugInfoSize = null,
            void* lpImageName = null,
            ushort? fUnicode = null
        ) : this()
        {
            if (hFile is not null)
            {
                HFile = hFile;
            }

            if (lpBaseOfDll is not null)
            {
                LpBaseOfDll = lpBaseOfDll;
            }

            if (dwDebugInfoFileOffset is not null)
            {
                DwDebugInfoFileOffset = dwDebugInfoFileOffset.Value;
            }

            if (nDebugInfoSize is not null)
            {
                NDebugInfoSize = nDebugInfoSize.Value;
            }

            if (lpImageName is not null)
            {
                LpImageName = lpImageName;
            }

            if (fUnicode is not null)
            {
                FUnicode = fUnicode.Value;
            }
        }


        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hFile")]
        public void* HFile;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpBaseOfDll")]
        public void* LpBaseOfDll;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwDebugInfoFileOffset")]
        public uint DwDebugInfoFileOffset;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nDebugInfoSize")]
        public uint NDebugInfoSize;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpImageName")]
        public void* LpImageName;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "fUnicode")]
        public ushort FUnicode;
    }
}
