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
    [NativeName("Name", "tagSOLE_AUTHENTICATION_INFO")]
    public unsafe partial struct SoleAuthenticationInfo
    {
        public SoleAuthenticationInfo
        (
            uint? dwAuthnSvc = null,
            uint? dwAuthzSvc = null,
            void* pAuthInfo = null
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

            if (pAuthInfo is not null)
            {
                PAuthInfo = pAuthInfo;
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

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pAuthInfo")]
        public void* PAuthInfo;
    }
}
