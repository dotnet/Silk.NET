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
    [NativeName("Name", "__AnonymousRecord_minwinbase_L254_C9")]
    public unsafe partial struct ProcessHeapEntryUnionRegion
    {
        public ProcessHeapEntryUnionRegion
        (
            int? dwCommittedSize = null,
            int? dwUnCommittedSize = null,
            nint* lpFirstBlock = null,
            nint* lpLastBlock = null
        ) : this()
        {
            if (dwCommittedSize is not null)
            {
                DwCommittedSize = dwCommittedSize.Value;
            }

            if (dwUnCommittedSize is not null)
            {
                DwUnCommittedSize = dwUnCommittedSize.Value;
            }

            if (lpFirstBlock is not null)
            {
                LpFirstBlock = lpFirstBlock;
            }

            if (lpLastBlock is not null)
            {
                LpLastBlock = lpLastBlock;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwCommittedSize")]
        public int DwCommittedSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwUnCommittedSize")]
        public int DwUnCommittedSize;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpFirstBlock")]
        public nint* LpFirstBlock;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "lpLastBlock")]
        public nint* LpLastBlock;
    }
}
