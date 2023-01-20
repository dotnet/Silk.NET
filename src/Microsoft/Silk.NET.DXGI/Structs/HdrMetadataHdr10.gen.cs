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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_HDR_METADATA_HDR10")]
    public unsafe partial struct HdrMetadataHdr10
    {
        public HdrMetadataHdr10
        (
            uint? maxMasteringLuminance = null,
            uint? minMasteringLuminance = null,
            ushort? maxContentLightLevel = null,
            ushort? maxFrameAverageLightLevel = null
        ) : this()
        {
            if (maxMasteringLuminance is not null)
            {
                MaxMasteringLuminance = maxMasteringLuminance.Value;
            }

            if (minMasteringLuminance is not null)
            {
                MinMasteringLuminance = minMasteringLuminance.Value;
            }

            if (maxContentLightLevel is not null)
            {
                MaxContentLightLevel = maxContentLightLevel.Value;
            }

            if (maxFrameAverageLightLevel is not null)
            {
                MaxFrameAverageLightLevel = maxFrameAverageLightLevel.Value;
            }
        }

        [NativeName("Type", "UINT16[2]")]
        [NativeName("Type.Name", "UINT16[2]")]
        [NativeName("Name", "RedPrimary")]
        public fixed ushort RedPrimary[2];
        [NativeName("Type", "UINT16[2]")]
        [NativeName("Type.Name", "UINT16[2]")]
        [NativeName("Name", "GreenPrimary")]
        public fixed ushort GreenPrimary[2];
        [NativeName("Type", "UINT16[2]")]
        [NativeName("Type.Name", "UINT16[2]")]
        [NativeName("Name", "BluePrimary")]
        public fixed ushort BluePrimary[2];
        [NativeName("Type", "UINT16[2]")]
        [NativeName("Type.Name", "UINT16[2]")]
        [NativeName("Name", "WhitePoint")]
        public fixed ushort WhitePoint[2];

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxMasteringLuminance")]
        public uint MaxMasteringLuminance;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinMasteringLuminance")]
        public uint MinMasteringLuminance;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MaxContentLightLevel")]
        public ushort MaxContentLightLevel;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MaxFrameAverageLightLevel")]
        public ushort MaxFrameAverageLightLevel;
    }
}
