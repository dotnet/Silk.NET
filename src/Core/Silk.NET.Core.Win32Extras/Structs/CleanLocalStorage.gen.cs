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
    [NativeName("Name", "tagCLEANLOCALSTORAGE")]
    public unsafe partial struct CleanLocalStorage
    {
        public CleanLocalStorage
        (
            Silk.NET.Core.Native.IUnknown* pInterface = null,
            void* pStorage = null,
            uint? flags = null
        ) : this()
        {
            if (pInterface is not null)
            {
                PInterface = pInterface;
            }

            if (pStorage is not null)
            {
                PStorage = pStorage;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pInterface")]
        public Silk.NET.Core.Native.IUnknown* PInterface;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pStorage")]
        public void* PStorage;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "flags")]
        public uint Flags;
    }
}
