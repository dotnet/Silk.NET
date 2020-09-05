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
    [NativeName("Name", "__AnonymousRecord_d3d11_L3381_C5")]
    public unsafe partial struct AnonymousRecordD3d11L3381C5
    {
        public AnonymousRecordD3d11L3381C5
        (
            BufferSrv buffer = default,
            Tex1DSrv texture1D = default,
            Tex1DArraySrv texture1DArray = default,
            Tex2DSrv texture2D = default,
            Tex2DArraySrv texture2DArray = default,
            Tex2DmsSrv texture2DMS = default,
            Tex2DmsArraySrv texture2DMSArray = default,
            Tex3DSrv texture3D = default,
            TexcubeSrv textureCube = default,
            TexcubeArraySrv textureCubeArray = default,
            BufferexSrv bufferEx = default
        )
        {
            Buffer = buffer;
            Texture1D = texture1D;
            Texture1DArray = texture1DArray;
            Texture2D = texture2D;
            Texture2DArray = texture2DArray;
            Texture2DMS = texture2DMS;
            Texture2DMSArray = texture2DMSArray;
            Texture3D = texture3D;
            TextureCube = textureCube;
            TextureCubeArray = textureCubeArray;
            BufferEx = bufferEx;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_BUFFER_SRV")]
        [NativeName("Type.Name", "D3D11_BUFFER_SRV")]
        [NativeName("Name", "Buffer")]
        public BufferSrv Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_SRV")]
        [NativeName("Type.Name", "D3D11_TEX1D_SRV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DSrv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D11_TEX1D_ARRAY_SRV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArraySrv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_SRV")]
        [NativeName("Type.Name", "D3D11_TEX2D_SRV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DSrv Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_SRV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArraySrv Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_SRV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_SRV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsSrv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2DMS_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D11_TEX2DMS_ARRAY_SRV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArraySrv Texture2DMSArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX3D_SRV")]
        [NativeName("Type.Name", "D3D11_TEX3D_SRV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DSrv Texture3D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEXCUBE_SRV")]
        [NativeName("Type.Name", "D3D11_TEXCUBE_SRV")]
        [NativeName("Name", "TextureCube")]
        public TexcubeSrv TextureCube;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEXCUBE_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D11_TEXCUBE_ARRAY_SRV")]
        [NativeName("Name", "TextureCubeArray")]
        public TexcubeArraySrv TextureCubeArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_BUFFEREX_SRV")]
        [NativeName("Type.Name", "D3D11_BUFFEREX_SRV")]
        [NativeName("Name", "BufferEx")]
        public BufferexSrv BufferEx;
    }
}
