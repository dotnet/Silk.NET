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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTRIPATCH_INFO")]
    public unsafe partial struct TripatchInfo
    {
        public TripatchInfo
        (
            uint? startVertexOffset = null,
            uint? numVertices = null,
            Basistype? basis = null,
            Degreetype? degree = null
        ) : this()
        {
            if (startVertexOffset is not null)
            {
                StartVertexOffset = startVertexOffset.Value;
            }

            if (numVertices is not null)
            {
                NumVertices = numVertices.Value;
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
        [NativeName("Name", "StartVertexOffset")]
        public uint StartVertexOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumVertices")]
        public uint NumVertices;

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
