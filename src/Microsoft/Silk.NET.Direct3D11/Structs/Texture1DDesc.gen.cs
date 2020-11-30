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
    [NativeName("Name", "D3D11_TEXTURE1D_DESC")]
    public unsafe partial struct Texture1DDesc
    {
        public Texture1DDesc
        (
            uint? width = null,
            uint? mipLevels = null,
            uint? arraySize = null,
            Silk.NET.DXGI.Format? format = null,
            Usage? usage = null,
            uint? bindFlags = null,
            uint? cPUAccessFlags = null,
            uint? miscFlags = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
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
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

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
    }
}
