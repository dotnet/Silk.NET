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
    [NativeName("Name", "_DXVA_COPPStatusSignalingCmdData")]
    public unsafe partial struct COPPStatusSignalingCmdData
    {
        public COPPStatusSignalingCmdData
        (
            Guid? rApp = null,
            uint? dwFlags = null,
            uint? availableTVProtectionStandards = null,
            uint? activeTVProtectionStandard = null,
            uint? tVType = null,
            uint? aspectRatioValidMask1 = null,
            uint? aspectRatioData1 = null,
            uint? aspectRatioValidMask2 = null,
            uint? aspectRatioData2 = null,
            uint? aspectRatioValidMask3 = null,
            uint? aspectRatioData3 = null
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

            if (availableTVProtectionStandards is not null)
            {
                AvailableTVProtectionStandards = availableTVProtectionStandards.Value;
            }

            if (activeTVProtectionStandard is not null)
            {
                ActiveTVProtectionStandard = activeTVProtectionStandard.Value;
            }

            if (tVType is not null)
            {
                TVType = tVType.Value;
            }

            if (aspectRatioValidMask1 is not null)
            {
                AspectRatioValidMask1 = aspectRatioValidMask1.Value;
            }

            if (aspectRatioData1 is not null)
            {
                AspectRatioData1 = aspectRatioData1.Value;
            }

            if (aspectRatioValidMask2 is not null)
            {
                AspectRatioValidMask2 = aspectRatioValidMask2.Value;
            }

            if (aspectRatioData2 is not null)
            {
                AspectRatioData2 = aspectRatioData2.Value;
            }

            if (aspectRatioValidMask3 is not null)
            {
                AspectRatioValidMask3 = aspectRatioValidMask3.Value;
            }

            if (aspectRatioData3 is not null)
            {
                AspectRatioData3 = aspectRatioData3.Value;
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
        [NativeName("Name", "AvailableTVProtectionStandards")]
        public uint AvailableTVProtectionStandards;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ActiveTVProtectionStandard")]
        public uint ActiveTVProtectionStandard;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "TVType")]
        public uint TVType;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioValidMask1")]
        public uint AspectRatioValidMask1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData1")]
        public uint AspectRatioData1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioValidMask2")]
        public uint AspectRatioValidMask2;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData2")]
        public uint AspectRatioData2;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioValidMask3")]
        public uint AspectRatioValidMask3;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData3")]
        public uint AspectRatioData3;
        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "ExtendedInfoValidMask")]
        public fixed uint ExtendedInfoValidMask[4];
        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "ExtendedInfoData")]
        public fixed uint ExtendedInfoData[4];
    }
}
