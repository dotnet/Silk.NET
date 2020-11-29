// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_CAPS")]
    public unsafe partial struct VideoProcessorCaps
    {
        public VideoProcessorCaps
        (
            uint? deviceCaps = null,
            uint? featureCaps = null,
            uint? filterCaps = null,
            uint? inputFormatCaps = null,
            uint? autoStreamCaps = null,
            uint? stereoCaps = null,
            uint? rateConversionCapsCount = null,
            uint? maxInputStreams = null,
            uint? maxStreamStates = null
        ) : this()
        {
            if (deviceCaps is not null)
            {
                DeviceCaps = deviceCaps.Value;
            }

            if (featureCaps is not null)
            {
                FeatureCaps = featureCaps.Value;
            }

            if (filterCaps is not null)
            {
                FilterCaps = filterCaps.Value;
            }

            if (inputFormatCaps is not null)
            {
                InputFormatCaps = inputFormatCaps.Value;
            }

            if (autoStreamCaps is not null)
            {
                AutoStreamCaps = autoStreamCaps.Value;
            }

            if (stereoCaps is not null)
            {
                StereoCaps = stereoCaps.Value;
            }

            if (rateConversionCapsCount is not null)
            {
                RateConversionCapsCount = rateConversionCapsCount.Value;
            }

            if (maxInputStreams is not null)
            {
                MaxInputStreams = maxInputStreams.Value;
            }

            if (maxStreamStates is not null)
            {
                MaxStreamStates = maxStreamStates.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DeviceCaps")]
        public uint DeviceCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FeatureCaps")]
        public uint FeatureCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FilterCaps")]
        public uint FilterCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFormatCaps")]
        public uint InputFormatCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AutoStreamCaps")]
        public uint AutoStreamCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StereoCaps")]
        public uint StereoCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RateConversionCapsCount")]
        public uint RateConversionCapsCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxInputStreams")]
        public uint MaxInputStreams;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxStreamStates")]
        public uint MaxStreamStates;
    }
}
