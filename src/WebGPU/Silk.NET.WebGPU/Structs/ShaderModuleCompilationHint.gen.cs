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
    [NativeName("Name", "WGPUShaderModuleCompilationHint")]
    public unsafe partial struct ShaderModuleCompilationHint
    {
        public ShaderModuleCompilationHint
        (
            ChainedStruct* nextInChain = null,
            byte* entryPoint = null,
            PipelineLayout* layout = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (entryPoint is not null)
            {
                EntryPoint = entryPoint;
            }

            if (layout is not null)
            {
                Layout = layout;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "entryPoint")]
        public byte* EntryPoint;

        [NativeName("Type", "WGPUPipelineLayout")]
        [NativeName("Type.Name", "WGPUPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout* Layout;
    }
}
