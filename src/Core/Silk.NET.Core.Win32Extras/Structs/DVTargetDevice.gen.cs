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
    [NativeName("Name", "tagDVTARGETDEVICE")]
    public unsafe partial struct DVTargetDevice
    {
        public DVTargetDevice
        (
            uint? tdSize = null,
            ushort? tdDriverNameOffset = null,
            ushort? tdDeviceNameOffset = null,
            ushort? tdPortNameOffset = null,
            ushort? tdExtDevmodeOffset = null
        ) : this()
        {
            if (tdSize is not null)
            {
                TdSize = tdSize.Value;
            }

            if (tdDriverNameOffset is not null)
            {
                TdDriverNameOffset = tdDriverNameOffset.Value;
            }

            if (tdDeviceNameOffset is not null)
            {
                TdDeviceNameOffset = tdDeviceNameOffset.Value;
            }

            if (tdPortNameOffset is not null)
            {
                TdPortNameOffset = tdPortNameOffset.Value;
            }

            if (tdExtDevmodeOffset is not null)
            {
                TdExtDevmodeOffset = tdExtDevmodeOffset.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "tdSize")]
        public uint TdSize;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "tdDriverNameOffset")]
        public ushort TdDriverNameOffset;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "tdDeviceNameOffset")]
        public ushort TdDeviceNameOffset;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "tdPortNameOffset")]
        public ushort TdPortNameOffset;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "tdExtDevmodeOffset")]
        public ushort TdExtDevmodeOffset;
        [NativeName("Type", "BYTE[1]")]
        [NativeName("Type.Name", "BYTE[1]")]
        [NativeName("Name", "tdData")]
        public fixed byte TdData[1];
    }
}
