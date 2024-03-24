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
    [NativeName("Name", "WGPUAdapterPropertiesD3D")]
    public unsafe partial struct AdapterPropertiesD3D
    {
        public AdapterPropertiesD3D
        (
            ChainedStructOut? chain = null,
            uint? shaderModel = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (shaderModel is not null)
            {
                ShaderModel = shaderModel.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderModel")]
        public uint ShaderModel;
    }
}
