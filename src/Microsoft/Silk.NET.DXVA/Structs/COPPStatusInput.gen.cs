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
    [NativeName("Name", "_DXVA_COPPStatusInput")]
    public unsafe partial struct COPPStatusInput
    {
        public COPPStatusInput
        (
            Guid? rApp = null,
            Guid? guidStatusRequestID = null,
            uint? dwSequence = null,
            uint? cbSizeData = null
        ) : this()
        {
            if (rApp is not null)
            {
                RApp = rApp.Value;
            }

            if (guidStatusRequestID is not null)
            {
                GuidStatusRequestID = guidStatusRequestID.Value;
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
        [NativeName("Name", "rApp")]
        public Guid RApp;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidStatusRequestID")]
        public Guid GuidStatusRequestID;

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
        [NativeName("Name", "StatusData")]
        public fixed byte StatusData[4056];
    }
}
