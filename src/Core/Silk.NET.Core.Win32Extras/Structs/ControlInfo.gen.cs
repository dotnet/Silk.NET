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
    [NativeName("Name", "tagCONTROLINFO")]
    public unsafe partial struct ControlInfo
    {
        public ControlInfo
        (
            uint? cb = null,
            void* hAccel = null,
            ushort? cAccel = null,
            uint? dwFlags = null
        ) : this()
        {
            if (cb is not null)
            {
                Cb = cb.Value;
            }

            if (hAccel is not null)
            {
                HAccel = hAccel;
            }

            if (cAccel is not null)
            {
                CAccel = cAccel.Value;
            }

            if (dwFlags is not null)
            {
                DwFlags = dwFlags.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cb")]
        public uint Cb;

        [NativeName("Type", "HACCEL")]
        [NativeName("Type.Name", "HACCEL")]
        [NativeName("Name", "hAccel")]
        public void* HAccel;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "cAccel")]
        public ushort CAccel;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFlags")]
        public uint DwFlags;
    }
}
