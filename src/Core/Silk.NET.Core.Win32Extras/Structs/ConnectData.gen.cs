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
    [NativeName("Name", "tagCONNECTDATA")]
    public unsafe partial struct ConnectData
    {
        public ConnectData
        (
            Silk.NET.Core.Native.IUnknown* pUnk = null,
            uint? dwCookie = null
        ) : this()
        {
            if (pUnk is not null)
            {
                PUnk = pUnk;
            }

            if (dwCookie is not null)
            {
                DwCookie = dwCookie.Value;
            }
        }


        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pUnk")]
        public Silk.NET.Core.Native.IUnknown* PUnk;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwCookie")]
        public uint DwCookie;
    }
}
