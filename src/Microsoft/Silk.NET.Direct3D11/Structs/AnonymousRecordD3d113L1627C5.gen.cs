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
    [NativeName("Name", "__AnonymousRecord_d3d11_3_L1627_C5")]
    public unsafe partial struct AnonymousRecordD3d113L1627C5
    {
        public AnonymousRecordD3d113L1627C5
        (
            BufferUav buffer = default,
            Tex1DUav texture1D = default,
            Tex1DArrayUav texture1DArray = default,
            Tex2DUav1 texture2D = default,
            Tex2DArrayUav1 texture2DArray = default,
            Tex3DUav texture3D = default
        )
        {
            Buffer = buffer;
            Texture1D = texture1D;
            Texture1DArray = texture1DArray;
            Texture2D = texture2D;
            Texture2DArray = texture2DArray;
            Texture3D = texture3D;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_BUFFER_UAV")]
        [NativeName("Type.Name", "D3D11_BUFFER_UAV")]
        [NativeName("Name", "Buffer")]
        public BufferUav Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_UAV")]
        [NativeName("Type.Name", "D3D11_TEX1D_UAV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DUav Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX1D_ARRAY_UAV")]
        [NativeName("Type.Name", "D3D11_TEX1D_ARRAY_UAV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayUav Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_UAV1")]
        [NativeName("Type.Name", "D3D11_TEX2D_UAV1")]
        [NativeName("Name", "Texture2D")]
        public Tex2DUav1 Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_ARRAY_UAV1")]
        [NativeName("Type.Name", "D3D11_TEX2D_ARRAY_UAV1")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayUav1 Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX3D_UAV")]
        [NativeName("Type.Name", "D3D11_TEX3D_UAV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DUav Texture3D;
    }
}
