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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_CUSTOM_RATE")]
    public unsafe partial struct VideoProcessorCustomRate
    {
        public VideoProcessorCustomRate
        (
            DXGI_RATIONAL customRate = default,
            uint outputFrames = default,
            int inputInterlaced = default,
            uint inputFramesOrFields = default
        )
        {
            CustomRate = customRate;
            OutputFrames = outputFrames;
            InputInterlaced = inputInterlaced;
            InputFramesOrFields = inputFramesOrFields;
        }


        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "CustomRate")]
        public DXGI_RATIONAL CustomRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputFrames")]
        public uint OutputFrames;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InputInterlaced")]
        public int InputInterlaced;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFramesOrFields")]
        public uint InputFramesOrFields;
    }
}
