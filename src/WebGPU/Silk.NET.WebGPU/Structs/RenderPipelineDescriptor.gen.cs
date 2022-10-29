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
    [NativeName("Name", "WGPURenderPipelineDescriptor")]
    public unsafe partial struct RenderPipelineDescriptor
    {
        public RenderPipelineDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            PipelineLayout* layout = null,
            VertexState? vertex = null,
            PrimitiveState? primitive = null,
            DepthStencilState* depthStencil = null,
            MultisampleState? multisample = null,
            FragmentState* fragment = null
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

            if (layout is not null)
            {
                Layout = layout;
            }

            if (vertex is not null)
            {
                Vertex = vertex.Value;
            }

            if (primitive is not null)
            {
                Primitive = primitive.Value;
            }

            if (depthStencil is not null)
            {
                DepthStencil = depthStencil;
            }

            if (multisample is not null)
            {
                Multisample = multisample.Value;
            }

            if (fragment is not null)
            {
                Fragment = fragment;
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

        [NativeName("Type", "WGPUPipelineLayout")]
        [NativeName("Type.Name", "WGPUPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout* Layout;

        [NativeName("Type", "WGPUVertexState")]
        [NativeName("Type.Name", "WGPUVertexState")]
        [NativeName("Name", "vertex")]
        public VertexState Vertex;

        [NativeName("Type", "WGPUPrimitiveState")]
        [NativeName("Type.Name", "WGPUPrimitiveState")]
        [NativeName("Name", "primitive")]
        public PrimitiveState Primitive;

        [NativeName("Type", "const WGPUDepthStencilState *")]
        [NativeName("Type.Name", "const WGPUDepthStencilState *")]
        [NativeName("Name", "depthStencil")]
        public DepthStencilState* DepthStencil;

        [NativeName("Type", "WGPUMultisampleState")]
        [NativeName("Type.Name", "WGPUMultisampleState")]
        [NativeName("Name", "multisample")]
        public MultisampleState Multisample;

        [NativeName("Type", "const WGPUFragmentState *")]
        [NativeName("Type.Name", "const WGPUFragmentState *")]
        [NativeName("Name", "fragment")]
        public FragmentState* Fragment;
    }
}
