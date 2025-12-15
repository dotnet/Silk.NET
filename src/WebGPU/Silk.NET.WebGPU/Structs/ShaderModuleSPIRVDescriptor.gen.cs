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
    [NativeName("Name", "WGPUShaderModuleSPIRVDescriptor")]
    public unsafe partial struct ShaderModuleSPIRVDescriptor
    {
        public ShaderModuleSPIRVDescriptor
        (
            ChainedStruct? chain = null,
            uint? codeSize = null,
            uint* code = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (codeSize is not null)
            {
                CodeSize = codeSize.Value;
            }

            if (code is not null)
            {
                Code = code;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "codeSize")]
        public uint CodeSize;

        [NativeName("Type", "const uint32_t *")]
        [NativeName("Type.Name", "const uint32_t *")]
        [NativeName("Name", "code")]
        public uint* Code;
    }
}
