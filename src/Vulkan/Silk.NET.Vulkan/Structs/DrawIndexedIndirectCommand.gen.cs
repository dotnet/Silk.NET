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
    [NativeName("Name", "VkDrawIndexedIndirectCommand")]
    public unsafe partial struct DrawIndexedIndirectCommand
    {
        public DrawIndexedIndirectCommand
        (
            uint? indexCount = null,
            uint? instanceCount = null,
            uint? firstIndex = null,
            int? vertexOffset = null,
            uint? firstInstance = null
        ) : this()
        {
            if (indexCount is not null)
            {
                IndexCount = indexCount.Value;
            }

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (firstIndex is not null)
            {
                FirstIndex = firstIndex.Value;
            }

            if (vertexOffset is not null)
            {
                VertexOffset = vertexOffset.Value;
            }

            if (firstInstance is not null)
            {
                FirstInstance = firstInstance.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCount")]
        public uint IndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCount")]
        public uint InstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstIndex")]
        public uint FirstIndex;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "vertexOffset")]
        public int VertexOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstInstance")]
        public uint FirstInstance;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
