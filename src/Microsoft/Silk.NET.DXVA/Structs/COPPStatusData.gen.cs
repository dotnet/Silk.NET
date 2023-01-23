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
    [NativeName("Name", "_DXVA_COPPStatusData")]
    public unsafe partial struct COPPStatusData
    {
        public COPPStatusData
        (
            Guid? rApp = null,
            uint? dwFlags = null,
            uint? dwData = null,
            uint? extendedInfoValidMask = null,
            uint? extendedInfoData = null
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

            if (dwData is not null)
            {
                DwData = dwData.Value;
            }

            if (extendedInfoValidMask is not null)
            {
                ExtendedInfoValidMask = extendedInfoValidMask.Value;
            }

            if (extendedInfoData is not null)
            {
                ExtendedInfoData = extendedInfoData.Value;
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
        [NativeName("Name", "dwData")]
        public uint DwData;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ExtendedInfoValidMask")]
        public uint ExtendedInfoValidMask;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ExtendedInfoData")]
        public uint ExtendedInfoData;
    }
}
