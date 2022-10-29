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
    [NativeName("Name", "WGPUImageCopyTexture")]
    public unsafe partial struct ImageCopyTexture
    {
        public ImageCopyTexture
        (
            ChainedStruct* nextInChain = null,
            Texture* texture = null,
            uint? mipLevel = null,
            Origin3D? origin = null,
            TextureAspect? aspect = null
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

            if (mipLevel is not null)
            {
                MipLevel = mipLevel.Value;
            }

            if (origin is not null)
            {
                Origin = origin.Value;
            }

            if (aspect is not null)
            {
                Aspect = aspect.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTexture")]
        [NativeName("Type.Name", "WGPUTexture")]
        [NativeName("Name", "texture")]
        public Texture* Texture;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevel")]
        public uint MipLevel;

        [NativeName("Type", "WGPUOrigin3D")]
        [NativeName("Type.Name", "WGPUOrigin3D")]
        [NativeName("Name", "origin")]
        public Origin3D Origin;

        [NativeName("Type", "WGPUTextureAspect")]
        [NativeName("Type.Name", "WGPUTextureAspect")]
        [NativeName("Name", "aspect")]
        public TextureAspect Aspect;
    }
}
