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
    [NativeName("Name", "WGPUImageCopyBuffer")]
    public unsafe partial struct ImageCopyBuffer
    {
        public ImageCopyBuffer
        (
            ChainedStruct* nextInChain = null,
            TextureDataLayout? layout = null,
            Buffer* buffer = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTextureDataLayout")]
        [NativeName("Type.Name", "WGPUTextureDataLayout")]
        [NativeName("Name", "layout")]
        public TextureDataLayout Layout;

        [NativeName("Type", "WGPUBuffer")]
        [NativeName("Type.Name", "WGPUBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer* Buffer;
    }
}
