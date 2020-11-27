// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEX3D_RTV")]
    public unsafe partial struct Tex3DRtv
    {
        public Tex3DRtv
        (
            uint? mipSlice = null,
            uint? firstWSlice = null,
            uint? wSize = null
        ) : this()
        {
            if (mipSlice is not null)
            {
                MipSlice = mipSlice.Value;
            }

            if (firstWSlice is not null)
            {
                FirstWSlice = firstWSlice.Value;
            }

            if (wSize is not null)
            {
                WSize = wSize.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipSlice")]
        public uint MipSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstWSlice")]
        public uint FirstWSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "WSize")]
        public uint WSize;
    }
}
