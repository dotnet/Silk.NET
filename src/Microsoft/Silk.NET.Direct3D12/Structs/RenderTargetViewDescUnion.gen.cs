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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3773_C5")]
    public unsafe partial struct RenderTargetViewDescUnion
    {
        public RenderTargetViewDescUnion
        (
            BufferRtv? buffer = null,
            Tex1DRtv? texture1D = null,
            Tex1DArrayRtv? texture1DArray = null,
            Tex2DRtv? texture2D = null,
            Tex2DArrayRtv? texture2DArray = null,
            Tex2DmsRtv? texture2DMS = null,
            Tex2DmsArrayRtv? texture2DMSArray = null,
            Tex3DRtv? texture3D = null
        ) : this()
        {
            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture2DMS is not null)
            {
                Texture2DMS = texture2DMS.Value;
            }

            if (texture2DMSArray is not null)
            {
                Texture2DMSArray = texture2DMSArray.Value;
            }

            if (texture3D is not null)
            {
                Texture3D = texture3D.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_BUFFER_RTV")]
        [NativeName("Type.Name", "D3D12_BUFFER_RTV")]
        [NativeName("Name", "Buffer")]
        public BufferRtv Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_RTV")]
        [NativeName("Type.Name", "D3D12_TEX1D_RTV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DRtv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_ARRAY_RTV")]
        [NativeName("Type.Name", "D3D12_TEX1D_ARRAY_RTV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayRtv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_RTV")]
        [NativeName("Type.Name", "D3D12_TEX2D_RTV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DRtv Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_ARRAY_RTV")]
        [NativeName("Type.Name", "D3D12_TEX2D_ARRAY_RTV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayRtv Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_RTV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_RTV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsRtv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_ARRAY_RTV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_ARRAY_RTV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArrayRtv Texture2DMSArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX3D_RTV")]
        [NativeName("Type.Name", "D3D12_TEX3D_RTV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DRtv Texture3D;
    }
}
