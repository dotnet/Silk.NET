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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSupportedLimits")]
    public unsafe partial struct SupportedLimits
    {
        public SupportedLimits
        (
            ChainedStructOut* nextInChain = null,
            Limits? limits = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (limits is not null)
            {
                Limits = limits.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut *")]
        [NativeName("Type.Name", "WGPUChainedStructOut *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStructOut* NextInChain;

        [NativeName("Type", "WGPULimits")]
        [NativeName("Type.Name", "WGPULimits")]
        [NativeName("Name", "limits")]
        public Limits Limits;
    }
}
