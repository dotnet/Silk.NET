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
    [NativeName("Name", "_D3DRECTPATCH_INFO")]
    public unsafe partial struct RectpatchInfo
    {
        public RectpatchInfo
        (
            uint startVertexOffsetWidth = default,
            uint startVertexOffsetHeight = default,
            uint width = default,
            uint height = default,
            uint stride = default,
            Basistype basis = default,
            Degreetype degree = default
        )
        {
            StartVertexOffsetWidth = startVertexOffsetWidth;
            StartVertexOffsetHeight = startVertexOffsetHeight;
            Width = width;
            Height = height;
            Stride = stride;
            Basis = basis;
            Degree = degree;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartVertexOffsetWidth")]
        public uint StartVertexOffsetWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartVertexOffsetHeight")]
        public uint StartVertexOffsetHeight;

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
        [NativeName("Name", "Stride")]
        public uint Stride;

        [NativeName("Type", "D3DBASISTYPE")]
        [NativeName("Type.Name", "D3DBASISTYPE")]
        [NativeName("Name", "Basis")]
        public Basistype Basis;

        [NativeName("Type", "D3DDEGREETYPE")]
        [NativeName("Type.Name", "D3DDEGREETYPE")]
        [NativeName("Name", "Degree")]
        public Degreetype Degree;
    }
}
