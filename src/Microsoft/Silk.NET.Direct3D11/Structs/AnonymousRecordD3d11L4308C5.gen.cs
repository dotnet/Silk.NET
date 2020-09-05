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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L4308_C5")]
    public unsafe partial struct AnonymousRecordD3d11L4308C5
    {
        public AnonymousRecordD3d11L4308C5
        (
            Tex1DDsv texture1D = default,
            Tex1DArrayDsv texture1DArray = default,
            Tex2DDsv texture2D = default,
            Tex2DArrayDsv texture2DArray = default,
            Tex2DmsDsv texture2DMS = default,
            Tex2DmsArrayDsv texture2DMSArray = default
        )
        {
            Texture1D = texture1D;
            Texture1DArray = texture1DArray;
            Texture2D = texture2D;
            Texture2DArray = texture2DArray;
            Texture2DMS = texture2DMS;
            Texture2DMSArray = texture2DMSArray;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_DSV")]
        [NativeName("Type.Name", "D3D11_TEX1D_DSV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DDsv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D11_TEX1D_ARRAY_DSV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayDsv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_DSV")]
        [NativeName("Type.Name", "D3D11_TEX2D_DSV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DDsv Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_DSV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayDsv Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_DSV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_DSV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsDsv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_ARRAY_DSV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArrayDsv Texture2DMSArray;
    }
}
