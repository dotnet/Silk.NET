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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMultiDrawInfoEXT")]
    public unsafe partial struct MultiDrawInfoEXT
    {
        public MultiDrawInfoEXT
        (
            uint? firstVertex = null,
            uint? vertexCount = null
        ) : this()
        {
            if (firstVertex is not null)
            {
                FirstVertex = firstVertex.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstVertex")]
        public uint FirstVertex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCount")]
        public uint VertexCount;
    }
}
