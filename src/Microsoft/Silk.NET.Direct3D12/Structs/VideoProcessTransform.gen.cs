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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_TRANSFORM")]
    public unsafe partial struct VideoProcessTransform
    {
        public VideoProcessTransform
        (
            Silk.NET.Core.Runtime.Windows.TagRect sourceRectangle = default,
            Silk.NET.Core.Runtime.Windows.TagRect destinationRectangle = default,
            VideoProcessOrientation orientation = default
        )
        {
            SourceRectangle = sourceRectangle;
            DestinationRectangle = destinationRectangle;
            Orientation = orientation;
        }


        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "SourceRectangle")]
        public Silk.NET.Core.Runtime.Windows.TagRect SourceRectangle;

        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "DestinationRectangle")]
        public Silk.NET.Core.Runtime.Windows.TagRect DestinationRectangle;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_ORIENTATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_ORIENTATION")]
        [NativeName("Name", "Orientation")]
        public VideoProcessOrientation Orientation;
    }
}
