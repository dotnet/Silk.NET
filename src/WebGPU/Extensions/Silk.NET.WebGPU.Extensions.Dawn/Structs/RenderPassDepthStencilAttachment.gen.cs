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
    [NativeName("Name", "WGPURenderPassDepthStencilAttachment")]
    public unsafe partial struct RenderPassDepthStencilAttachment
    {
        public RenderPassDepthStencilAttachment
        (
            TextureView* view = null,
            LoadOp? depthLoadOp = null,
            StoreOp? depthStoreOp = null,
            float? clearDepth = null,
            float? depthClearValue = null,
            bool? depthReadOnly = null,
            LoadOp? stencilLoadOp = null,
            StoreOp? stencilStoreOp = null,
            uint? clearStencil = null,
            uint? stencilClearValue = null,
            bool? stencilReadOnly = null
        ) : this()
        {
            if (view is not null)
            {
                View = view;
            }

            if (depthLoadOp is not null)
            {
                DepthLoadOp = depthLoadOp.Value;
            }

            if (depthStoreOp is not null)
            {
                DepthStoreOp = depthStoreOp.Value;
            }

            if (clearDepth is not null)
            {
                ClearDepth = clearDepth.Value;
            }

            if (depthClearValue is not null)
            {
                DepthClearValue = depthClearValue.Value;
            }

            if (depthReadOnly is not null)
            {
                DepthReadOnly = depthReadOnly.Value;
            }

            if (stencilLoadOp is not null)
            {
                StencilLoadOp = stencilLoadOp.Value;
            }

            if (stencilStoreOp is not null)
            {
                StencilStoreOp = stencilStoreOp.Value;
            }

            if (clearStencil is not null)
            {
                ClearStencil = clearStencil.Value;
            }

            if (stencilClearValue is not null)
            {
                StencilClearValue = stencilClearValue.Value;
            }

            if (stencilReadOnly is not null)
            {
                StencilReadOnly = stencilReadOnly.Value;
            }
        }


        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "view")]
        public TextureView* View;

        [NativeName("Type", "WGPULoadOp")]
        [NativeName("Type.Name", "WGPULoadOp")]
        [NativeName("Name", "depthLoadOp")]
        public LoadOp DepthLoadOp;

        [NativeName("Type", "WGPUStoreOp")]
        [NativeName("Type.Name", "WGPUStoreOp")]
        [NativeName("Name", "depthStoreOp")]
        public StoreOp DepthStoreOp;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "clearDepth")]
        public float ClearDepth;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthClearValue")]
        public float DepthClearValue;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "depthReadOnly")]
        public bool DepthReadOnly;

        [NativeName("Type", "WGPULoadOp")]
        [NativeName("Type.Name", "WGPULoadOp")]
        [NativeName("Name", "stencilLoadOp")]
        public LoadOp StencilLoadOp;

        [NativeName("Type", "WGPUStoreOp")]
        [NativeName("Type.Name", "WGPUStoreOp")]
        [NativeName("Name", "stencilStoreOp")]
        public StoreOp StencilStoreOp;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "clearStencil")]
        public uint ClearStencil;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stencilClearValue")]
        public uint StencilClearValue;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "stencilReadOnly")]
        public bool StencilReadOnly;
    }
}
