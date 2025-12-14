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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialMeshDataEXT")]
    public unsafe partial struct SpatialMeshDataEXT
    {
        public SpatialMeshDataEXT
        (
            Posef? origin = null,
            SpatialBufferEXT? vertexBuffer = null,
            SpatialBufferEXT? indexBuffer = null
        ) : this()
        {
            if (origin is not null)
            {
                Origin = origin.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "origin")]
        public Posef Origin;
/// <summary></summary>
        [NativeName("Type", "XrSpatialBufferEXT")]
        [NativeName("Type.Name", "XrSpatialBufferEXT")]
        [NativeName("Name", "vertexBuffer")]
        public SpatialBufferEXT VertexBuffer;
/// <summary></summary>
        [NativeName("Type", "XrSpatialBufferEXT")]
        [NativeName("Type.Name", "XrSpatialBufferEXT")]
        [NativeName("Name", "indexBuffer")]
        public SpatialBufferEXT IndexBuffer;
    }
}
