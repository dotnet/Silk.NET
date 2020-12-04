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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE")]
    public unsafe partial struct VideoProcessInputStreamRate
    {
        public VideoProcessInputStreamRate
        (
            uint? outputIndex = null,
            uint? inputFrameOrField = null
        ) : this()
        {
            if (outputIndex is not null)
            {
                OutputIndex = outputIndex.Value;
            }

            if (inputFrameOrField is not null)
            {
                InputFrameOrField = inputFrameOrField.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIndex")]
        public uint OutputIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFrameOrField")]
        public uint InputFrameOrField;
    }
}
