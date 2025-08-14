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
    [NativeName("Name", "VkIndirectCommandsVertexBufferTokenEXT")]
    public unsafe partial struct IndirectCommandsVertexBufferTokenEXT
    {
        public IndirectCommandsVertexBufferTokenEXT
        (
            uint? vertexBindingUnit = null
        ) : this()
        {
            if (vertexBindingUnit is not null)
            {
                VertexBindingUnit = vertexBindingUnit.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexBindingUnit")]
        public uint VertexBindingUnit;
    }
}
