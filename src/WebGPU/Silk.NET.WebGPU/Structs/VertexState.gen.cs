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
    [NativeName("Name", "WGPUVertexState")]
    public unsafe partial struct VertexState
    {
        public VertexState
        (
            ChainedStruct* nextInChain = null,
            ShaderModuleImpl* module = null,
            byte* entryPoint = null,
            uint? constantCount = null,
            ConstantEntry* constants = null,
            uint? bufferCount = null,
            VertexBufferLayout* buffers = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (module is not null)
            {
                Module = module;
            }

            if (entryPoint is not null)
            {
                EntryPoint = entryPoint;
            }

            if (constantCount is not null)
            {
                ConstantCount = constantCount.Value;
            }

            if (constants is not null)
            {
                Constants = constants;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (buffers is not null)
            {
                Buffers = buffers;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUShaderModule")]
        [NativeName("Type.Name", "WGPUShaderModule")]
        [NativeName("Name", "module")]
        public ShaderModuleImpl* Module;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "entryPoint")]
        public byte* EntryPoint;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "constantCount")]
        public uint ConstantCount;

        [NativeName("Type", "const WGPUConstantEntry *")]
        [NativeName("Type.Name", "const WGPUConstantEntry *")]
        [NativeName("Name", "constants")]
        public ConstantEntry* Constants;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferCount")]
        public uint BufferCount;

        [NativeName("Type", "const WGPUVertexBufferLayout *")]
        [NativeName("Type.Name", "const WGPUVertexBufferLayout *")]
        [NativeName("Name", "buffers")]
        public VertexBufferLayout* Buffers;
    }
}
