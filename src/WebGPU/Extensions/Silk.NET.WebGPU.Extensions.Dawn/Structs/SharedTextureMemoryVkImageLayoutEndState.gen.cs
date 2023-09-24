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
    [NativeName("Name", "WGPUSharedTextureMemoryVkImageLayoutEndState")]
    public unsafe partial struct SharedTextureMemoryVkImageLayoutEndState
    {
        public SharedTextureMemoryVkImageLayoutEndState
        (
            ChainedStructOut? chain = null,
            int? oldLayout = null,
            int? newLayout = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (oldLayout is not null)
            {
                OldLayout = oldLayout.Value;
            }

            if (newLayout is not null)
            {
                NewLayout = newLayout.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "oldLayout")]
        public int OldLayout;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "newLayout")]
        public int NewLayout;
    }
}
