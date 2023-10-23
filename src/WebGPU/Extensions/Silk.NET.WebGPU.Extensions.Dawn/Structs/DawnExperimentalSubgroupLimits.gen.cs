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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUDawnExperimentalSubgroupLimits")]
    public unsafe partial struct DawnExperimentalSubgroupLimits
    {
        public DawnExperimentalSubgroupLimits
        (
            ChainedStructOut? chain = null,
            uint? minSubgroupSize = null,
            uint? maxSubgroupSize = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (minSubgroupSize is not null)
            {
                MinSubgroupSize = minSubgroupSize.Value;
            }

            if (maxSubgroupSize is not null)
            {
                MaxSubgroupSize = maxSubgroupSize.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minSubgroupSize")]
        public uint MinSubgroupSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubgroupSize")]
        public uint MaxSubgroupSize;
    }
}
