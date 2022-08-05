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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_VERTEX_RANGE")]
    public unsafe partial struct VertexRange
    {
        public VertexRange
        (
            uint? startVertex = null,
            uint? vertexCount = null
        ) : this()
        {
            if (startVertex is not null)
            {
                StartVertex = startVertex.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "startVertex")]
        public uint StartVertex;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "vertexCount")]
        public uint VertexCount;
    }
}
