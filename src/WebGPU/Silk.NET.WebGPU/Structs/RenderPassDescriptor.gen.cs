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
    [NativeName("Name", "WGPURenderPassDescriptor")]
    public unsafe partial struct RenderPassDescriptor
    {
        public RenderPassDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            uint? colorAttachmentCount = null,
            RenderPassColorAttachment* colorAttachments = null,
            RenderPassDepthStencilAttachment* depthStencilAttachment = null,
            QuerySetImpl* occlusionQuerySet = null,
            uint? timestampWriteCount = null,
            RenderPassTimestampWrite* timestampWrites = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (colorAttachmentCount is not null)
            {
                ColorAttachmentCount = colorAttachmentCount.Value;
            }

            if (colorAttachments is not null)
            {
                ColorAttachments = colorAttachments;
            }

            if (depthStencilAttachment is not null)
            {
                DepthStencilAttachment = depthStencilAttachment;
            }

            if (occlusionQuerySet is not null)
            {
                OcclusionQuerySet = occlusionQuerySet;
            }

            if (timestampWriteCount is not null)
            {
                TimestampWriteCount = timestampWriteCount.Value;
            }

            if (timestampWrites is not null)
            {
                TimestampWrites = timestampWrites;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "colorAttachmentCount")]
        public uint ColorAttachmentCount;

        [NativeName("Type", "const WGPURenderPassColorAttachment *")]
        [NativeName("Type.Name", "const WGPURenderPassColorAttachment *")]
        [NativeName("Name", "colorAttachments")]
        public RenderPassColorAttachment* ColorAttachments;

        [NativeName("Type", "const WGPURenderPassDepthStencilAttachment *")]
        [NativeName("Type.Name", "const WGPURenderPassDepthStencilAttachment *")]
        [NativeName("Name", "depthStencilAttachment")]
        public RenderPassDepthStencilAttachment* DepthStencilAttachment;

        [NativeName("Type", "WGPUQuerySet")]
        [NativeName("Type.Name", "WGPUQuerySet")]
        [NativeName("Name", "occlusionQuerySet")]
        public QuerySetImpl* OcclusionQuerySet;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "timestampWriteCount")]
        public uint TimestampWriteCount;

        [NativeName("Type", "const WGPURenderPassTimestampWrite *")]
        [NativeName("Type.Name", "const WGPURenderPassTimestampWrite *")]
        [NativeName("Name", "timestampWrites")]
        public RenderPassTimestampWrite* TimestampWrites;
    }
}
