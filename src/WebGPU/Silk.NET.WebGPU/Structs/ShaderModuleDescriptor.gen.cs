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
    [NativeName("Name", "WGPUShaderModuleDescriptor")]
    public unsafe partial struct ShaderModuleDescriptor
    {
        public ShaderModuleDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            nuint? hintCount = null,
            ShaderModuleCompilationHint* hints = null
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

            if (hintCount is not null)
            {
                HintCount = hintCount.Value;
            }

            if (hints is not null)
            {
                Hints = hints;
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

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "hintCount")]
        public nuint HintCount;

        [NativeName("Type", "const WGPUShaderModuleCompilationHint *")]
        [NativeName("Type.Name", "const WGPUShaderModuleCompilationHint *")]
        [NativeName("Name", "hints")]
        public ShaderModuleCompilationHint* Hints;
    }
}
