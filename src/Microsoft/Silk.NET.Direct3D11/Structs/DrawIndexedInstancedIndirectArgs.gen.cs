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
    [NativeName("Name", "D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS")]
    public unsafe partial struct DrawIndexedInstancedIndirectArgs
    {
        public DrawIndexedInstancedIndirectArgs
        (
            uint? indexCountPerInstance = null,
            uint? instanceCount = null,
            uint? startIndexLocation = null,
            int? baseVertexLocation = null,
            uint? startInstanceLocation = null
        ) : this()
        {
            if (indexCountPerInstance is not null)
            {
                IndexCountPerInstance = indexCountPerInstance.Value;
            }

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (startIndexLocation is not null)
            {
                StartIndexLocation = startIndexLocation.Value;
            }

            if (baseVertexLocation is not null)
            {
                BaseVertexLocation = baseVertexLocation.Value;
            }

            if (startInstanceLocation is not null)
            {
                StartInstanceLocation = startInstanceLocation.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IndexCountPerInstance")]
        public uint IndexCountPerInstance;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceCount")]
        public uint InstanceCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartIndexLocation")]
        public uint StartIndexLocation;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "BaseVertexLocation")]
        public int BaseVertexLocation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartInstanceLocation")]
        public uint StartInstanceLocation;
    }
}
