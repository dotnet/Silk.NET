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
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC")]
    public unsafe partial struct VideoProcessorOutputViewDesc
    {
        public VideoProcessorOutputViewDesc
        (
            VpovDimension? viewDimension = null,
            VideoProcessorOutputViewDescUnion? anonymous = null,
            Tex2DVpov? texture2D = null,
            Tex2DArrayVpov? texture2DArray = null
        ) : this()
        {
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

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }
        }


        [NativeName("Type", "D3D11_VPOV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VPOV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VpovDimension ViewDimension;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L12022_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoProcessorOutputViewDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DVpov Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2D;
        }
#else
        public Tex2DVpov Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DArrayVpov Texture2DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DArray;
        }
#else
        public Tex2DArrayVpov Texture2DArray
        {
            get => Anonymous.Texture2DArray;
            set => Anonymous.Texture2DArray = value;
        }
#endif

    }
}
