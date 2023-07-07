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
    [NativeName("Name", "WGPUInstanceEnumerateAdapterOptions")]
    public unsafe partial struct InstanceEnumerateAdapterOptions
    {
        public InstanceEnumerateAdapterOptions
        (
            ChainedStruct* nextInChain = null,
            Silk.NET.WebGPU.Extensions.WGPU.InstanceBackend? backends = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (backends is not null)
            {
                Backends = backends.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUInstanceBackendFlags")]
        [NativeName("Type.Name", "WGPUInstanceBackendFlags")]
        [NativeName("Name", "backends")]
        public Silk.NET.WebGPU.Extensions.WGPU.InstanceBackend Backends;
    }
}
