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
    [NativeName("Name", "WGPUMultisampleState")]
    public unsafe partial struct MultisampleState
    {
        public MultisampleState
        (
            ChainedStruct* nextInChain = null,
            uint? count = null,
            uint? mask = null,
            Silk.NET.Core.Bool32? alphaToCoverageEnabled = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (mask is not null)
            {
                Mask = mask.Value;
            }

            if (alphaToCoverageEnabled is not null)
            {
                AlphaToCoverageEnabled = alphaToCoverageEnabled.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "count")]
        public uint Count;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mask")]
        public uint Mask;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "alphaToCoverageEnabled")]
        public Silk.NET.Core.Bool32 AlphaToCoverageEnabled;
    }
}
