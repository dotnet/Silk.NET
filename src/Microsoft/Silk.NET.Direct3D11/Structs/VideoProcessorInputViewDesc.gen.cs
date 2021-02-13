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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC")]
    public unsafe partial struct VideoProcessorInputViewDesc
    {
        public VideoProcessorInputViewDesc
        (
            uint? fourCC = null,
            VpivDimension? viewDimension = null,
            VideoProcessorInputViewDescUnion? anonymous = null,
            Tex2DVpiv? texture2D = null
        ) : this()
        {
            if (fourCC is not null)
            {
                FourCC = fourCC.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FourCC")]
        public uint FourCC;

        [NativeName("Type", "D3D11_VPIV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VPIV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VpivDimension ViewDimension;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L11375_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoProcessorInputViewDescUnion Anonymous;
#if NETSTANDARD2_1
        public ref Tex2DVpiv Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Texture2D;
        }
#else
        public Tex2DVpiv Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

    }
}
