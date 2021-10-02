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
    [NativeName("Name", "_DXVAHD_VPCAPS")]
    public unsafe partial struct HDVpcaps
    {
        public HDVpcaps
        (
            Guid? vPGuid = null,
            uint? pastFrames = null,
            uint? futureFrames = null,
            uint? processorCaps = null,
            uint? iTelecineCaps = null,
            uint? customRateCount = null
        ) : this()
        {
            if (vPGuid is not null)
            {
                VPGuid = vPGuid.Value;
            }

            if (pastFrames is not null)
            {
                PastFrames = pastFrames.Value;
            }

            if (futureFrames is not null)
            {
                FutureFrames = futureFrames.Value;
            }

            if (processorCaps is not null)
            {
                ProcessorCaps = processorCaps.Value;
            }

            if (iTelecineCaps is not null)
            {
                ITelecineCaps = iTelecineCaps.Value;
            }

            if (customRateCount is not null)
            {
                CustomRateCount = customRateCount.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "VPGuid")]
        public Guid VPGuid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PastFrames")]
        public uint PastFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FutureFrames")]
        public uint FutureFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProcessorCaps")]
        public uint ProcessorCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ITelecineCaps")]
        public uint ITelecineCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CustomRateCount")]
        public uint CustomRateCount;
    }
}
