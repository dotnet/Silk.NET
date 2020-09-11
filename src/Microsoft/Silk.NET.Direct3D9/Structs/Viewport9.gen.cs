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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVIEWPORT9")]
    public unsafe partial struct Viewport9
    {
        public Viewport9
        (
            uint x = default,
            uint y = default,
            uint width = default,
            uint height = default,
            float minZ = default,
            float maxZ = default
        )
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            MinZ = minZ;
            MaxZ = maxZ;
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "X")]
        public uint X;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Y")]
        public uint Y;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MinZ")]
        public float MinZ;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxZ")]
        public float MaxZ;
    }
}
