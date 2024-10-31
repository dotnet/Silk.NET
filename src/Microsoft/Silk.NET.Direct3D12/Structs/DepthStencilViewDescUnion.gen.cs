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
    [NativeName("Name", "__AnonymousRecord_d3d12_L3847_C5")]
    public unsafe partial struct DepthStencilViewDescUnion
    {
        public DepthStencilViewDescUnion
        (
            Tex1DDsv? texture1D = null,
            Tex1DArrayDsv? texture1DArray = null,
            Tex2DDsv? texture2D = null,
            Tex2DArrayDsv? texture2DArray = null,
            Tex2DmsDsv? texture2DMS = null,
            Tex2DmsArrayDsv? texture2DMSArray = null
        ) : this()
        {
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
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_DSV")]
        [NativeName("Type.Name", "D3D12_TEX1D_DSV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DDsv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D12_TEX1D_ARRAY_DSV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArrayDsv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_DSV")]
        [NativeName("Type.Name", "D3D12_TEX2D_DSV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DDsv Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D12_TEX2D_ARRAY_DSV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArrayDsv Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_DSV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_DSV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsDsv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_ARRAY_DSV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_ARRAY_DSV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArrayDsv Texture2DMSArray;
    }
}
