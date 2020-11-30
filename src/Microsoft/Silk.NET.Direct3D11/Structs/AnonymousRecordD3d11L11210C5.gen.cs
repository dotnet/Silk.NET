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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L11210_C5")]
    public unsafe partial struct AnonymousRecordD3d11L11210C5
    {
        public AnonymousRecordD3d11L11210C5
        (
            Tex2DVdov? texture2D = null
        ) : this()
        {
            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_VDOV")]
        [NativeName("Type.Name", "D3D11_TEX2D_VDOV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DVdov Texture2D;
    }
}
