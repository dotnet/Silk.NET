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
    [NativeName("Name", "WGPUSharedBufferMemoryBeginAccessDescriptor")]
    public unsafe partial struct SharedBufferMemoryBeginAccessDescriptor
    {
        public SharedBufferMemoryBeginAccessDescriptor
        (
            ChainedStruct* nextInChain = null,
            Silk.NET.Core.Bool32? initialized = null,
            nuint? fenceCount = null,
            SharedFenceImpl** fences = null,
            ulong* signaledValues = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (initialized is not null)
            {
                Initialized = initialized.Value;
            }

            if (fenceCount is not null)
            {
                FenceCount = fenceCount.Value;
            }

            if (fences is not null)
            {
                Fences = fences;
            }

            if (signaledValues is not null)
            {
                SignaledValues = signaledValues;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "initialized")]
        public Silk.NET.Core.Bool32 Initialized;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "fenceCount")]
        public nuint FenceCount;

        [NativeName("Type", "const WGPUSharedFence *")]
        [NativeName("Type.Name", "const WGPUSharedFence *")]
        [NativeName("Name", "fences")]
        public SharedFenceImpl** Fences;

        [NativeName("Type", "const uint64_t *")]
        [NativeName("Type.Name", "const uint64_t *")]
        [NativeName("Name", "signaledValues")]
        public ulong* SignaledValues;
    }
}
