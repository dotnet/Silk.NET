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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUShaderSourceGLSL")]
    public unsafe partial struct ShaderSourceGLSL
    {
        public ShaderSourceGLSL
        (
            ChainedStruct? chain = null,
            ulong? stage = null,
            StringView? code = null,
            uint? defineCount = null,
            ShaderDefine* defines = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (code is not null)
            {
                Code = code.Value;
            }

            if (defineCount is not null)
            {
                DefineCount = defineCount.Value;
            }

            if (defines is not null)
            {
                Defines = defines;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUShaderStage")]
        [NativeName("Type.Name", "WGPUShaderStage")]
        [NativeName("Name", "stage")]
        public ulong Stage;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "code")]
        public StringView Code;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "defineCount")]
        public uint DefineCount;

        [NativeName("Type", "WGPUShaderDefine *")]
        [NativeName("Type.Name", "WGPUShaderDefine *")]
        [NativeName("Name", "defines")]
        public ShaderDefine* Defines;
    }
}
