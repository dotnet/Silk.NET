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
    [NativeName("Name", "WGPUColorTargetStateExpandResolveTextureDawn")]
    public unsafe partial struct ColorTargetStateExpandResolveTextureDawn
    {
        public ColorTargetStateExpandResolveTextureDawn
        (
            ChainedStruct? chain = null,
            Silk.NET.Core.Bool32? enabled = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "enabled")]
        public Silk.NET.Core.Bool32 Enabled;
    }
}
