// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L10354_C5")]
    public unsafe partial struct AnonymousRecordD3d11L10354C5
    {
        public AnonymousRecordD3d11L10354C5
        (
            VIDEOCOLORYCbCrA? yCbCr = null,
            VideoColorRgba? rGBA = null
        ) : this()
        {
            if (yCbCr is not null)
            {
                YCbCr = yCbCr.Value;
            }

            if (rGBA is not null)
            {
                RGBA = rGBA.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_VIDEO_COLOR_YCbCrA")]
        [NativeName("Type.Name", "D3D11_VIDEO_COLOR_YCbCrA")]
        [NativeName("Name", "YCbCr")]
        public VIDEOCOLORYCbCrA YCbCr;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_VIDEO_COLOR_RGBA")]
        [NativeName("Type.Name", "D3D11_VIDEO_COLOR_RGBA")]
        [NativeName("Name", "RGBA")]
        public VideoColorRgba RGBA;
    }
}
