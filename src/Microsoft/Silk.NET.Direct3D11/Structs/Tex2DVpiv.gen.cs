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
    [NativeName("Name", "D3D11_TEX2D_VPIV")]
    public unsafe partial struct Tex2DVpiv
    {
        public Tex2DVpiv
        (
            uint? mipSlice = null,
            uint? arraySlice = null
        ) : this()
        {
            if (mipSlice is not null)
            {
                MipSlice = mipSlice.Value;
            }

            if (arraySlice is not null)
            {
                ArraySlice = arraySlice.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipSlice")]
        public uint MipSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySlice")]
        public uint ArraySlice;
    }
}
