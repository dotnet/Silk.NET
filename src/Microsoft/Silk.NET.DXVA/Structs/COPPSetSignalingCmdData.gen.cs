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
    [NativeName("Name", "_DXVA_COPPSetSignalingCmdData")]
    public unsafe partial struct COPPSetSignalingCmdData
    {
        public COPPSetSignalingCmdData
        (
            uint? activeTVProtectionStandard = null,
            uint? aspectRatioChangeMask1 = null,
            uint? aspectRatioData1 = null,
            uint? aspectRatioChangeMask2 = null,
            uint? aspectRatioData2 = null,
            uint? aspectRatioChangeMask3 = null,
            uint? aspectRatioData3 = null,
            uint? reserved = null
        ) : this()
        {
            if (activeTVProtectionStandard is not null)
            {
                ActiveTVProtectionStandard = activeTVProtectionStandard.Value;
            }

            if (aspectRatioChangeMask1 is not null)
            {
                AspectRatioChangeMask1 = aspectRatioChangeMask1.Value;
            }

            if (aspectRatioData1 is not null)
            {
                AspectRatioData1 = aspectRatioData1.Value;
            }

            if (aspectRatioChangeMask2 is not null)
            {
                AspectRatioChangeMask2 = aspectRatioChangeMask2.Value;
            }

            if (aspectRatioData2 is not null)
            {
                AspectRatioData2 = aspectRatioData2.Value;
            }

            if (aspectRatioChangeMask3 is not null)
            {
                AspectRatioChangeMask3 = aspectRatioChangeMask3.Value;
            }

            if (aspectRatioData3 is not null)
            {
                AspectRatioData3 = aspectRatioData3.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ActiveTVProtectionStandard")]
        public uint ActiveTVProtectionStandard;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioChangeMask1")]
        public uint AspectRatioChangeMask1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData1")]
        public uint AspectRatioData1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioChangeMask2")]
        public uint AspectRatioChangeMask2;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData2")]
        public uint AspectRatioData2;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioChangeMask3")]
        public uint AspectRatioChangeMask3;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "AspectRatioData3")]
        public uint AspectRatioData3;
        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "ExtendedInfoChangeMask")]
        public fixed uint ExtendedInfoChangeMask[4];
        [NativeName("Type", "ULONG[4]")]
        [NativeName("Type.Name", "ULONG[4]")]
        [NativeName("Name", "ExtendedInfoData")]
        public fixed uint ExtendedInfoData[4];

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;
    }
}
