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
    [NativeName("Name", "WGPUSharedTextureMemoryD3DSwapchainBeginState")]
    public unsafe partial struct SharedTextureMemoryD3DSwapchainBeginState
    {
        public SharedTextureMemoryD3DSwapchainBeginState
        (
            ChainedStruct? chain = null,
            Silk.NET.Core.Bool32? isSwapchain = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (isSwapchain is not null)
            {
                IsSwapchain = isSwapchain.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "isSwapchain")]
        public Silk.NET.Core.Bool32 IsSwapchain;
    }
}
