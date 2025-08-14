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
    [NativeName("Name", "__AnonymousRecord_minwinbase_L253_C9")]
    public unsafe partial struct ProcessHeapEntryUnionBlock
    {
        public ProcessHeapEntryUnionBlock
        (
            void* hMem = null
        ) : this()
        {
            if (hMem is not null)
            {
                HMem = hMem;
            }
        }


        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hMem")]
        public void* HMem;
        [NativeName("Type", "DWORD[3]")]
        [NativeName("Type.Name", "DWORD[3]")]
        [NativeName("Name", "dwReserved")]
        public fixed uint DwReserved[3];
    }
}
