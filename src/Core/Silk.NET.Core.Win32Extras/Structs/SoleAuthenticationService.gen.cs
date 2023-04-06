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
    [NativeName("Name", "tagSOLE_AUTHENTICATION_SERVICE")]
    public unsafe partial struct SoleAuthenticationService
    {
        public SoleAuthenticationService
        (
            uint? dwAuthnSvc = null,
            uint? dwAuthzSvc = null,
            char* pPrincipalName = null,
            int? hr = null
        ) : this()
        {
            if (dwAuthnSvc is not null)
            {
                DwAuthnSvc = dwAuthnSvc.Value;
            }

            if (dwAuthzSvc is not null)
            {
                DwAuthzSvc = dwAuthzSvc.Value;
            }

            if (pPrincipalName is not null)
            {
                PPrincipalName = pPrincipalName;
            }

            if (hr is not null)
            {
                Hr = hr.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAuthnSvc")]
        public uint DwAuthnSvc;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAuthzSvc")]
        public uint DwAuthzSvc;

        [NativeName("Type", "OLECHAR *")]
        [NativeName("Type.Name", "OLECHAR *")]
        [NativeName("Name", "pPrincipalName")]
        public char* PPrincipalName;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "hr")]
        public int Hr;
    }
}
