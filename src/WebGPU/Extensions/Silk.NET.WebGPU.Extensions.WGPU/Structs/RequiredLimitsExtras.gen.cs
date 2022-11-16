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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPURequiredLimitsExtras")]
    public unsafe partial struct RequiredLimitsExtras
    {
        public RequiredLimitsExtras
        (
            ChainedStruct? chain = null,
            uint? maxPushConstantSize = null,
            ulong? maxBufferSize = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (maxPushConstantSize is not null)
            {
                MaxPushConstantSize = maxPushConstantSize.Value;
            }

            if (maxBufferSize is not null)
            {
                MaxBufferSize = maxBufferSize.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPushConstantSize")]
        public uint MaxPushConstantSize;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxBufferSize")]
        public ulong MaxBufferSize;
    }
}
