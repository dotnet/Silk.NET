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
    [NativeName("Name", "WGPUDawnInstanceDescriptor")]
    public unsafe partial struct DawnInstanceDescriptor
    {
        public DawnInstanceDescriptor
        (
            ChainedStruct? chain = null,
            uint? additionalRuntimeSearchPathsCount = null,
            byte** additionalRuntimeSearchPaths = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (additionalRuntimeSearchPathsCount is not null)
            {
                AdditionalRuntimeSearchPathsCount = additionalRuntimeSearchPathsCount.Value;
            }

            if (additionalRuntimeSearchPaths is not null)
            {
                AdditionalRuntimeSearchPaths = additionalRuntimeSearchPaths;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "additionalRuntimeSearchPathsCount")]
        public uint AdditionalRuntimeSearchPathsCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "additionalRuntimeSearchPaths")]
        public byte** AdditionalRuntimeSearchPaths;
    }
}
