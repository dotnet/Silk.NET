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
    [NativeName("Name", "D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC")]
    public unsafe partial struct VideoDecoderOutputViewDesc
    {
        public VideoDecoderOutputViewDesc
        (
            Guid? decodeProfile = null,
            VdovDimension? viewDimension = null,
            VideoDecoderOutputViewDescUnion? anonymous = null,
            Tex2DVdov? texture2D = null
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

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
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

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L11668_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoDecoderOutputViewDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DVdov Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2D;
        }
#else
        public Tex2DVdov Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

    }
}
