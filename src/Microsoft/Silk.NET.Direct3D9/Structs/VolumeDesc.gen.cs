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
    [NativeName("Name", "_D3DVOLUME_DESC")]
    public unsafe partial struct VolumeDesc
    {
        public VolumeDesc
        (
            Format format = default,
            Resourcetype type = default,
            uint usage = default,
            Pool pool = default,
            uint width = default,
            uint height = default,
            uint depth = default
        )
        {
            Format = format;
            Type = type;
            Usage = usage;
            Pool = pool;
            Width = width;
            Height = height;
            Depth = depth;
        }


        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Format Format;

        [NativeName("Type", "D3DRESOURCETYPE")]
        [NativeName("Type.Name", "D3DRESOURCETYPE")]
        [NativeName("Name", "Type")]
        public Resourcetype Type;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Usage")]
        public uint Usage;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "Pool")]
        public Pool Pool;

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
        [NativeName("Name", "Depth")]
        public uint Depth;
    }
}
