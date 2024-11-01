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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L12022_C5")]
    public unsafe partial struct VideoProcessorOutputViewDescUnion
    {
        public VideoProcessorOutputViewDescUnion
        (
            Tex2DVpov? texture2D = null,
            Tex2DArrayVpov? texture2DArray = null
        ) : this()
        {
            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_VPOV")]
        [NativeName("Type.Name", "D3D11_TEX2D_VPOV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DVpov Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_VPOV")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_VPOV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayVpov Texture2DArray;
    }
}
