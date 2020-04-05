// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct StencilOpState
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
        public StencilOp FailOp;
/// <summary></summary>
        public StencilOp PassOp;
/// <summary></summary>
        public StencilOp DepthFailOp;
/// <summary></summary>
        public CompareOp CompareOp;
/// <summary></summary>
        public uint CompareMask;
/// <summary></summary>
        public uint WriteMask;
/// <summary></summary>
        public uint Reference;
    }
}
