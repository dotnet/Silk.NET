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
    [NativeName("Name", "VkClearDepthStencilValue")]
    public unsafe partial struct ClearDepthStencilValue
    {
        public ClearDepthStencilValue
        (
            float? depth = null,
            uint? stencil = null
        ) : this()
        {
            if (depth is not null)
            {
                Depth = depth.Value;
            }

            if (stencil is not null)
            {
                Stencil = stencil.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depth")]
        public float Depth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stencil")]
        public uint Stencil;
    }
}
