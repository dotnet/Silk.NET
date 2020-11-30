// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS")]
    public unsafe partial struct VideoProcessorRateConversionCaps
    {
        public VideoProcessorRateConversionCaps
        (
            uint? pastFrames = null,
            uint? futureFrames = null,
            uint? processorCaps = null,
            uint? iTelecineCaps = null,
            uint? customRateCount = null
        ) : this()
        {
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
