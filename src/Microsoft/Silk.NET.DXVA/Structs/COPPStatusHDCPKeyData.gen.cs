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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_COPPStatusHDCPKeyData")]
    public unsafe partial struct COPPStatusHDCPKeyData
    {
        public COPPStatusHDCPKeyData
        (
            Guid? rApp = null,
            uint? dwFlags = null,
            uint? dwHDCPFlags = null,
            Guid? bKey = null,
            Guid? reserved1 = null,
            Guid? reserved2 = null
        ) : this()
        {
            if (rApp is not null)
            {
                RApp = rApp.Value;
            }

            if (dwFlags is not null)
            {
                DwFlags = dwFlags.Value;
            }

            if (dwHDCPFlags is not null)
            {
                DwHDCPFlags = dwHDCPFlags.Value;
            }

            if (bKey is not null)
            {
                BKey = bKey.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "rApp")]
        public Guid RApp;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "dwFlags")]
        public uint DwFlags;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "dwHDCPFlags")]
        public uint DwHDCPFlags;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "BKey")]
        public Guid BKey;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Reserved1")]
        public Guid Reserved1;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Reserved2")]
        public Guid Reserved2;
    }
}
