// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            StencilOp failOp = default,
            StencilOp passOp = default,
            StencilOp depthFailOp = default,
            CompareOp compareOp = default,
            uint compareMask = default,
            uint writeMask = default,
            uint reference = default
        )
        {
            FailOp = failOp;
            PassOp = passOp;
            DepthFailOp = depthFailOp;
            CompareOp = compareOp;
            CompareMask = compareMask;
            WriteMask = writeMask;
            Reference = reference;
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
    }
}
