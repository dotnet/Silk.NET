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
    [NativeName("Name", "D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC")]
    public unsafe partial struct VideoDecoderOutputViewDesc
    {
        public VideoDecoderOutputViewDesc
        (
            Guid? decodeProfile = null,
            VdovDimension? viewDimension = null
        ) : this()
        {
            if (decodeProfile is not null)
            {
                DecodeProfile = decodeProfile.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DecodeProfile")]
        public Guid DecodeProfile;

        [NativeName("Type", "D3D11_VDOV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VDOV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VdovDimension ViewDimension;
    }
}
