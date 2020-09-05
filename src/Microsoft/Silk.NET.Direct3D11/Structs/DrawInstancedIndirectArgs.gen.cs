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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DRAW_INSTANCED_INDIRECT_ARGS")]
    public unsafe partial struct DrawInstancedIndirectArgs
    {
        public DrawInstancedIndirectArgs
        (
            uint vertexCountPerInstance = default,
            uint instanceCount = default,
            uint startVertexLocation = default,
            uint startInstanceLocation = default
        )
        {
            VertexCountPerInstance = vertexCountPerInstance;
            InstanceCount = instanceCount;
            StartVertexLocation = startVertexLocation;
            StartInstanceLocation = startInstanceLocation;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VertexCountPerInstance")]
        public uint VertexCountPerInstance;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceCount")]
        public uint InstanceCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartVertexLocation")]
        public uint StartVertexLocation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartInstanceLocation")]
        public uint StartInstanceLocation;
    }
}
