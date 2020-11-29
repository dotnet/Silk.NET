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
    [NativeName("Name", "D3D11_TILED_RESOURCE_COORDINATE")]
    public unsafe partial struct TiledResourceCoordinate
    {
        public TiledResourceCoordinate
        (
            uint? x = null,
            uint? y = null,
            uint? z = null,
            uint? subresource = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (z is not null)
            {
                Z = z.Value;
            }

            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "X")]
        public uint X;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Y")]
        public uint Y;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Z")]
        public uint Z;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Subresource")]
        public uint Subresource;
    }
}
