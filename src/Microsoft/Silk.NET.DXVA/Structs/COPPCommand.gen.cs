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
    [NativeName("Name", "_DXVA_COPPCommand")]
    public unsafe partial struct COPPCommand
    {
        public COPPCommand
        (
            Guid? macKDI = null,
            Guid? guidCommandID = null,
            uint? dwSequence = null,
            uint? cbSizeData = null
        ) : this()
        {
            if (macKDI is not null)
            {
                MacKDI = macKDI.Value;
            }

            if (guidCommandID is not null)
            {
                GuidCommandID = guidCommandID.Value;
            }

            if (dwSequence is not null)
            {
                DwSequence = dwSequence.Value;
            }

            if (cbSizeData is not null)
            {
                CbSizeData = cbSizeData.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "macKDI")]
        public Guid MacKDI;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidCommandID")]
        public Guid GuidCommandID;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "dwSequence")]
        public uint DwSequence;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSizeData")]
        public uint CbSizeData;
        [NativeName("Type", "UCHAR[4056]")]
        [NativeName("Type.Name", "UCHAR[4056]")]
        [NativeName("Name", "CommandData")]
        public fixed byte CommandData[4056];
    }
}
