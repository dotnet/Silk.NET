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
    [NativeName("Name", "tagQACONTROL")]
    public unsafe partial struct QAControl
    {
        public QAControl
        (
            uint? cbSize = null,
            uint? dwMiscStatus = null,
            uint? dwViewStatus = null,
            uint? dwEventCookie = null,
            uint? dwPropNotifyCookie = null,
            uint? dwPointerActivationPolicy = null
        ) : this()
        {
            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (dwMiscStatus is not null)
            {
                DwMiscStatus = dwMiscStatus.Value;
            }

            if (dwViewStatus is not null)
            {
                DwViewStatus = dwViewStatus.Value;
            }

            if (dwEventCookie is not null)
            {
                DwEventCookie = dwEventCookie.Value;
            }

            if (dwPropNotifyCookie is not null)
            {
                DwPropNotifyCookie = dwPropNotifyCookie.Value;
            }

            if (dwPointerActivationPolicy is not null)
            {
                DwPointerActivationPolicy = dwPointerActivationPolicy.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwMiscStatus")]
        public uint DwMiscStatus;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwViewStatus")]
        public uint DwViewStatus;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwEventCookie")]
        public uint DwEventCookie;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwPropNotifyCookie")]
        public uint DwPropNotifyCookie;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwPointerActivationPolicy")]
        public uint DwPointerActivationPolicy;
    }
}
