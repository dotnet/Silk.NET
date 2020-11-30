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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRECTPATCH_INFO")]
    public unsafe partial struct RectpatchInfo
    {
        public RectpatchInfo
        (
            uint? startVertexOffsetWidth = null,
            uint? startVertexOffsetHeight = null,
            uint? width = null,
            uint? height = null,
            uint? stride = null,
            Basistype? basis = null,
            Degreetype? degree = null
        ) : this()
        {
            if (startVertexOffsetWidth is not null)
            {
                StartVertexOffsetWidth = startVertexOffsetWidth.Value;
            }

            if (startVertexOffsetHeight is not null)
            {
                StartVertexOffsetHeight = startVertexOffsetHeight.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (basis is not null)
            {
                Basis = basis.Value;
            }

            if (degree is not null)
            {
                Degree = degree.Value;
            }
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
