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
    [NativeName("Name", "CD3D11_TEXTURE2D_DESC1")]
    public unsafe partial struct CD3D11Texture2DDesc1
    {
        public CD3D11Texture2DDesc1
        (
            uint? width = null,
            uint? height = null,
            uint? mipLevels = null,
            uint? arraySize = null,
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.DXGI.SampleDesc? sampleDesc = null,
            Usage? usage = null,
            uint? bindFlags = null,
            uint? cPUAccessFlags = null,
            uint? miscFlags = null,
            TextureLayout? textureLayout = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (arraySize is not null)
            {
                ArraySize = arraySize.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (sampleDesc is not null)
            {
                SampleDesc = sampleDesc.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (bindFlags is not null)
            {
                BindFlags = bindFlags.Value;
            }

            if (cPUAccessFlags is not null)
            {
                CPUAccessFlags = cPUAccessFlags.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }

            if (textureLayout is not null)
            {
                TextureLayout = textureLayout.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySize")]
        public uint ArraySize;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public Silk.NET.DXGI.SampleDesc SampleDesc;

        [NativeName("Type", "D3D11_USAGE")]
        [NativeName("Type.Name", "D3D11_USAGE")]
        [NativeName("Name", "Usage")]
        public Usage Usage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindFlags")]
        public uint BindFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CPUAccessFlags")]
        public uint CPUAccessFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;

        [NativeName("Type", "D3D11_TEXTURE_LAYOUT")]
        [NativeName("Type.Name", "D3D11_TEXTURE_LAYOUT")]
        [NativeName("Name", "TextureLayout")]
        public TextureLayout TextureLayout;
    }
}
