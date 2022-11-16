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
    [NativeName("Name", "WGPUPrimitiveState")]
    public unsafe partial struct PrimitiveState
    {
        public PrimitiveState
        (
            ChainedStruct* nextInChain = null,
            PrimitiveTopology? topology = null,
            IndexFormat? stripIndexFormat = null,
            FrontFace? frontFace = null,
            CullMode? cullMode = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (topology is not null)
            {
                Topology = topology.Value;
            }

            if (stripIndexFormat is not null)
            {
                StripIndexFormat = stripIndexFormat.Value;
            }

            if (frontFace is not null)
            {
                FrontFace = frontFace.Value;
            }

            if (cullMode is not null)
            {
                CullMode = cullMode.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUPrimitiveTopology")]
        [NativeName("Type.Name", "WGPUPrimitiveTopology")]
        [NativeName("Name", "topology")]
        public PrimitiveTopology Topology;

        [NativeName("Type", "WGPUIndexFormat")]
        [NativeName("Type.Name", "WGPUIndexFormat")]
        [NativeName("Name", "stripIndexFormat")]
        public IndexFormat StripIndexFormat;

        [NativeName("Type", "WGPUFrontFace")]
        [NativeName("Type.Name", "WGPUFrontFace")]
        [NativeName("Name", "frontFace")]
        public FrontFace FrontFace;

        [NativeName("Type", "WGPUCullMode")]
        [NativeName("Type.Name", "WGPUCullMode")]
        [NativeName("Name", "cullMode")]
        public CullMode CullMode;
    }
}
