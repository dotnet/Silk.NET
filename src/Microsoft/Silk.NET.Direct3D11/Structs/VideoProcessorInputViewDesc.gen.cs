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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC")]
    public unsafe partial struct VideoProcessorInputViewDesc
    {
        public VideoProcessorInputViewDesc
        (
            uint fourCC = default,
            VpivDimension viewDimension = default
        )
        {
            FourCC = fourCC;
            ViewDimension = viewDimension;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FourCC")]
        public uint FourCC;

        [NativeName("Type", "D3D11_VPIV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VPIV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VpivDimension ViewDimension;
    }
}
