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
    [NativeName("Name", "tagFORMATETC")]
    public unsafe partial struct FORMATETC
    {
        public FORMATETC
        (
            ushort? cfFormat = null,
            DVTargetDevice* ptd = null,
            uint? dwAspect = null,
            int? lindex = null,
            uint? tymed = null
        ) : this()
        {
            if (cfFormat is not null)
            {
                CfFormat = cfFormat.Value;
            }

            if (ptd is not null)
            {
                Ptd = ptd;
            }

            if (dwAspect is not null)
            {
                DwAspect = dwAspect.Value;
            }

            if (lindex is not null)
            {
                Lindex = lindex.Value;
            }

            if (tymed is not null)
            {
                Tymed = tymed.Value;
            }
        }


        [NativeName("Type", "CLIPFORMAT")]
        [NativeName("Type.Name", "CLIPFORMAT")]
        [NativeName("Name", "cfFormat")]
        public ushort CfFormat;

        [NativeName("Type", "DVTARGETDEVICE *")]
        [NativeName("Type.Name", "DVTARGETDEVICE *")]
        [NativeName("Name", "ptd")]
        public DVTargetDevice* Ptd;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAspect")]
        public uint DwAspect;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "lindex")]
        public int Lindex;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "tymed")]
        public uint Tymed;
    }
}
