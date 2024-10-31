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
    [NativeName("Name", "VkStencilOpState")]
    public unsafe partial struct StencilOpState
    {
        public StencilOpState
        (
            StencilOp? failOp = null,
            StencilOp? passOp = null,
            StencilOp? depthFailOp = null,
            CompareOp? compareOp = null,
            uint? compareMask = null,
            uint? writeMask = null,
            uint? reference = null
        ) : this()
        {
            if (failOp is not null)
            {
                FailOp = failOp.Value;
            }

            if (passOp is not null)
            {
                PassOp = passOp.Value;
            }

            if (depthFailOp is not null)
            {
                DepthFailOp = depthFailOp.Value;
            }

            if (compareOp is not null)
            {
                CompareOp = compareOp.Value;
            }

            if (compareMask is not null)
            {
                CompareMask = compareMask.Value;
            }

            if (writeMask is not null)
            {
                WriteMask = writeMask.Value;
            }

            if (reference is not null)
            {
                Reference = reference.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStencilOp")]
        [NativeName("Type.Name", "VkStencilOp")]
        [NativeName("Name", "failOp")]
        public StencilOp FailOp;
/// <summary></summary>
        [NativeName("Type", "VkStencilOp")]
        [NativeName("Type.Name", "VkStencilOp")]
        [NativeName("Name", "passOp")]
        public StencilOp PassOp;
/// <summary></summary>
        [NativeName("Type", "VkStencilOp")]
        [NativeName("Type.Name", "VkStencilOp")]
        [NativeName("Name", "depthFailOp")]
        public StencilOp DepthFailOp;
/// <summary></summary>
        [NativeName("Type", "VkCompareOp")]
        [NativeName("Type.Name", "VkCompareOp")]
        [NativeName("Name", "compareOp")]
        public CompareOp CompareOp;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "compareMask")]
        public uint CompareMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "writeMask")]
        public uint WriteMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "reference")]
        public uint Reference;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
