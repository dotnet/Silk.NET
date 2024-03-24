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
    [NativeName("Name", "WGPURenderPassColorAttachment")]
    public unsafe partial struct RenderPassColorAttachment
    {
        public RenderPassColorAttachment
        (
            ChainedStruct* nextInChain = null,
            TextureView* view = null,
            uint? depthSlice = null,
            TextureView* resolveTarget = null,
            LoadOp? loadOp = null,
            StoreOp? storeOp = null,
            Color? clearValue = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (view is not null)
            {
                View = view;
            }

            if (depthSlice is not null)
            {
                DepthSlice = depthSlice.Value;
            }

            if (resolveTarget is not null)
            {
                ResolveTarget = resolveTarget;
            }

            if (loadOp is not null)
            {
                LoadOp = loadOp.Value;
            }

            if (storeOp is not null)
            {
                StoreOp = storeOp.Value;
            }

            if (clearValue is not null)
            {
                ClearValue = clearValue.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "view")]
        public TextureView* View;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "depthSlice")]
        public uint DepthSlice;

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "resolveTarget")]
        public TextureView* ResolveTarget;

        [NativeName("Type", "WGPULoadOp")]
        [NativeName("Type.Name", "WGPULoadOp")]
        [NativeName("Name", "loadOp")]
        public LoadOp LoadOp;

        [NativeName("Type", "WGPUStoreOp")]
        [NativeName("Type.Name", "WGPUStoreOp")]
        [NativeName("Name", "storeOp")]
        public StoreOp StoreOp;

        [NativeName("Type", "WGPUColor")]
        [NativeName("Type.Name", "WGPUColor")]
        [NativeName("Name", "clearValue")]
        public Color ClearValue;
    }
}
