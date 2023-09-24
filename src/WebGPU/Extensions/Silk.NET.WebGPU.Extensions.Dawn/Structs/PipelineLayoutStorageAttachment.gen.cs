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
    [NativeName("Name", "WGPUPipelineLayoutStorageAttachment")]
    public unsafe partial struct PipelineLayoutStorageAttachment
    {
        public PipelineLayoutStorageAttachment
        (
            ChainedStruct* nextInChain = null,
            ulong? offset = null,
            TextureFormat? format = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;
    }
}
