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
    [NativeName("Name", "_COAUTHINFO")]
    public unsafe partial struct Coauthinfo
    {
        public Coauthinfo
        (
            uint? dwAuthnSvc = null,
            uint? dwAuthzSvc = null,
            char* pwszServerPrincName = null,
            uint? dwAuthnLevel = null,
            uint? dwImpersonationLevel = null,
            Coauthidentity* pAuthIdentityData = null,
            uint? dwCapabilities = null
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

            if (pwszServerPrincName is not null)
            {
                PwszServerPrincName = pwszServerPrincName;
            }

            if (dwAuthnLevel is not null)
            {
                DwAuthnLevel = dwAuthnLevel.Value;
            }

            if (dwImpersonationLevel is not null)
            {
                DwImpersonationLevel = dwImpersonationLevel.Value;
            }

            if (pAuthIdentityData is not null)
            {
                PAuthIdentityData = pAuthIdentityData;
            }

            if (dwCapabilities is not null)
            {
                DwCapabilities = dwCapabilities.Value;
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

        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "pwszServerPrincName")]
        public char* PwszServerPrincName;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAuthnLevel")]
        public uint DwAuthnLevel;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwImpersonationLevel")]
        public uint DwImpersonationLevel;

        [NativeName("Type", "COAUTHIDENTITY *")]
        [NativeName("Type.Name", "COAUTHIDENTITY *")]
        [NativeName("Name", "pAuthIdentityData")]
        public Coauthidentity* PAuthIdentityData;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwCapabilities")]
        public uint DwCapabilities;
    }
}
