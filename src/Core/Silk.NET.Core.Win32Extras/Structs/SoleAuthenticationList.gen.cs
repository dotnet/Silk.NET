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
    [NativeName("Name", "tagSOLE_AUTHENTICATION_LIST")]
    public unsafe partial struct SoleAuthenticationList
    {
        public SoleAuthenticationList
        (
            uint? cAuthInfo = null,
            SoleAuthenticationInfo* aAuthInfo = null
        ) : this()
        {
            if (cAuthInfo is not null)
            {
                CAuthInfo = cAuthInfo.Value;
            }

            if (aAuthInfo is not null)
            {
                AAuthInfo = aAuthInfo;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "cAuthInfo")]
        public uint CAuthInfo;

        [NativeName("Type", "SOLE_AUTHENTICATION_INFO *")]
        [NativeName("Type.Name", "SOLE_AUTHENTICATION_INFO *")]
        [NativeName("Name", "aAuthInfo")]
        public SoleAuthenticationInfo* AAuthInfo;
    }
}
