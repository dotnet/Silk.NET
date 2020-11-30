// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEX2D_RTV1")]
    public unsafe partial struct Tex2DRtv1
    {
        public Tex2DRtv1
        (
            uint? mipSlice = null,
            uint? planeSlice = null
        ) : this()
        {
            if (mipSlice is not null)
            {
                MipSlice = mipSlice.Value;
            }

            if (planeSlice is not null)
            {
                PlaneSlice = planeSlice.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipSlice")]
        public uint MipSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PlaneSlice")]
        public uint PlaneSlice;
    }
}
