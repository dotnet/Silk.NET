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
    [NativeName("Name", "_DXVA_COPPStatusDisplayData")]
    public unsafe partial struct COPPStatusDisplayData
    {
        public COPPStatusDisplayData
        (
            Guid? rApp = null,
            uint? dwFlags = null,
            uint? displayWidth = null,
            uint? displayHeight = null,
            uint? format = null,
            uint? d3dFormat = null,
            uint? freqNumerator = null,
            uint? freqDenominator = null
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

            if (displayWidth is not null)
            {
                DisplayWidth = displayWidth.Value;
            }

            if (displayHeight is not null)
            {
                DisplayHeight = displayHeight.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (d3dFormat is not null)
            {
                D3dFormat = d3dFormat.Value;
            }

            if (freqNumerator is not null)
            {
                FreqNumerator = freqNumerator.Value;
            }

            if (freqDenominator is not null)
            {
                FreqDenominator = freqDenominator.Value;
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
        [NativeName("Name", "DisplayWidth")]
        public uint DisplayWidth;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "DisplayHeight")]
        public uint DisplayHeight;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Format")]
        public uint Format;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "d3dFormat")]
        public uint D3dFormat;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FreqNumerator")]
        public uint FreqNumerator;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "FreqDenominator")]
        public uint FreqDenominator;
    }
}
