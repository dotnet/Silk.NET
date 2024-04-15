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
            NativeLimits? limits = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (limits is not null)
            {
                Limits = limits.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUNativeLimits")]
        [NativeName("Type.Name", "WGPUNativeLimits")]
        [NativeName("Name", "limits")]
        public NativeLimits Limits;
    }
}
