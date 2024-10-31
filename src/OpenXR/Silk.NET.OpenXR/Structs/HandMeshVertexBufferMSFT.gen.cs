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
    [NativeName("Name", "XrHandMeshVertexBufferMSFT")]
    public unsafe partial struct HandMeshVertexBufferMSFT
    {
        public HandMeshVertexBufferMSFT
        (
            long? vertexUpdateTime = null,
            uint? vertexCapacityInput = null,
            uint? vertexCountOutput = null,
            HandMeshVertexMSFT* vertices = null
        ) : this()
        {
            if (vertexUpdateTime is not null)
            {
                VertexUpdateTime = vertexUpdateTime.Value;
            }

            if (vertexCapacityInput is not null)
            {
                VertexCapacityInput = vertexCapacityInput.Value;
            }

            if (vertexCountOutput is not null)
            {
                VertexCountOutput = vertexCountOutput.Value;
            }

            if (vertices is not null)
            {
                Vertices = vertices;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "vertexUpdateTime")]
        public long VertexUpdateTime;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCapacityInput")]
        public uint VertexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCountOutput")]
        public uint VertexCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrHandMeshVertexMSFT*")]
        [NativeName("Type.Name", "XrHandMeshVertexMSFT")]
        [NativeName("Name", "vertices")]
        public HandMeshVertexMSFT* Vertices;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
