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
    [NativeName("Name", "tagRemSTGMEDIUM")]
    public unsafe partial struct RemSTGMEDIUM
    {
        public RemSTGMEDIUM
        (
            uint? tymed = null,
            uint? dwHandleType = null,
            uint? pData = null,
            uint? pUnkForRelease = null,
            uint? cbData = null
        ) : this()
        {
            if (tymed is not null)
            {
                Tymed = tymed.Value;
            }

            if (dwHandleType is not null)
            {
                DwHandleType = dwHandleType.Value;
            }

            if (pData is not null)
            {
                PData = pData.Value;
            }

            if (pUnkForRelease is not null)
            {
                PUnkForRelease = pUnkForRelease.Value;
            }

            if (cbData is not null)
            {
                CbData = cbData.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "tymed")]
        public uint Tymed;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwHandleType")]
        public uint DwHandleType;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "pData")]
        public uint PData;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "pUnkForRelease")]
        public uint PUnkForRelease;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbData")]
        public uint CbData;
        [NativeName("Type", "byte[1]")]
        [NativeName("Type.Name", "byte[1]")]
        [NativeName("Name", "data")]
        public fixed byte Data[1];
    }
}
