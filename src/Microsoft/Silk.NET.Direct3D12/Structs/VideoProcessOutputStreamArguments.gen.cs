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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoProcessOutputStreamArguments
    {
        public VideoProcessOutputStreamArguments
        (
            Silk.NET.Core.Runtime.Windows.TagRect targetRectangle = default
        )
        {
           OutputStream_0 = default;
           OutputStream_1 = default;
            TargetRectangle = targetRectangle;
        }

        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM [2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM [2]")]
        [NativeName("Name", "OutputStream")]
        public VideoProcessOutputStream OutputStream_0;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM [2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM [2]")]
        [NativeName("Name", "OutputStream")]
        public VideoProcessOutputStream OutputStream_1;

        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "TargetRectangle")]
        public Silk.NET.Core.Runtime.Windows.TagRect TargetRectangle;
    }
}
