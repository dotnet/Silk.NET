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
    [NativeName("Name", "WGPUSurfaceTexture")]
    public unsafe partial struct SurfaceTexture
    {
        public SurfaceTexture
        (
            ChainedStruct* nextInChain = null,
            Texture* texture = null,
            SurfaceGetCurrentTextureStatus? status = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (texture is not null)
            {
                Texture = texture;
            }

            if (status is not null)
            {
                Status = status.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTexture")]
        [NativeName("Type.Name", "WGPUTexture")]
        [NativeName("Name", "texture")]
        public Texture* Texture;

        [NativeName("Type", "WGPUSurfaceGetCurrentTextureStatus")]
        [NativeName("Type.Name", "WGPUSurfaceGetCurrentTextureStatus")]
        [NativeName("Name", "status")]
        public SurfaceGetCurrentTextureStatus Status;
    }
}
