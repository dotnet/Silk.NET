// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint pastFrames = default,
            uint futureFrames = default,
            uint processorCaps = default,
            uint iTelecineCaps = default,
            uint customRateCount = default
        )
        {
            PastFrames = pastFrames;
            FutureFrames = futureFrames;
            ProcessorCaps = processorCaps;
            ITelecineCaps = iTelecineCaps;
            CustomRateCount = customRateCount;
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
