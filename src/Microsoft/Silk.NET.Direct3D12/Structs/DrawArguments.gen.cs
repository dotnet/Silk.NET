// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRAW_ARGUMENTS")]
    public unsafe partial struct DrawArguments
    {
        public DrawArguments
        (
            uint? vertexCountPerInstance = null,
            uint? instanceCount = null,
            uint? startVertexLocation = null,
            uint? startInstanceLocation = null
        ) : this()
        {
            if (vertexCountPerInstance is not null)
            {
                VertexCountPerInstance = vertexCountPerInstance.Value;
            }

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (startVertexLocation is not null)
            {
                StartVertexLocation = startVertexLocation.Value;
            }

            if (startInstanceLocation is not null)
            {
                StartInstanceLocation = startInstanceLocation.Value;
            }
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
