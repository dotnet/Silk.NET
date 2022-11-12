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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "_COSERVERINFO")]
    public unsafe partial struct Coserverinfo
    {
        public Coserverinfo
        (
            uint? dwReserved1 = null,
            char* pwszName = null,
            Coauthinfo* pAuthInfo = null,
            uint? dwReserved2 = null
        ) : this()
        {
            if (dwReserved1 is not null)
            {
                DwReserved1 = dwReserved1.Value;
            }

            if (pwszName is not null)
            {
                PwszName = pwszName;
            }

            if (pAuthInfo is not null)
            {
                PAuthInfo = pAuthInfo;
            }

            if (dwReserved2 is not null)
            {
                DwReserved2 = dwReserved2.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved1")]
        public uint DwReserved1;

        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "pwszName")]
        public char* PwszName;

        [NativeName("Type", "COAUTHINFO *")]
        [NativeName("Type.Name", "COAUTHINFO *")]
        [NativeName("Name", "pAuthInfo")]
        public Coauthinfo* PAuthInfo;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved2")]
        public uint DwReserved2;
    }
}
