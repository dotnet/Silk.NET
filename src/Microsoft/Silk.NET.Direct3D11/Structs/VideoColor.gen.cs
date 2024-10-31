// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "D3D11_VIDEO_COLOR")]
    public unsafe partial struct VideoColor
    {
        public VideoColor
        (
            VideoColorUnion? anonymous = null,
            VIDEOCOLORYCbCrA? yCbCr = null,
            VideoColorRgba? rGBA = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (yCbCr is not null)
            {
                YCbCr = yCbCr.Value;
            }

            if (rGBA is not null)
            {
                RGBA = rGBA.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L10781_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoColorUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VIDEOCOLORYCbCrA YCbCr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].YCbCr;
        }
#else
        public VIDEOCOLORYCbCrA YCbCr
        {
            get => Anonymous.YCbCr;
            set => Anonymous.YCbCr = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoColorRgba RGBA
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].RGBA;
        }
#else
        public VideoColorRgba RGBA
        {
            get => Anonymous.RGBA;
            set => Anonymous.RGBA = value;
        }
#endif

    }
}
