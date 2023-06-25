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
    [NativeName("Name", "WGPUImageCopyExternalTexture")]
    public unsafe partial struct ImageCopyExternalTexture
    {
        public ImageCopyExternalTexture
        (
            ChainedStruct* nextInChain = null,
            ExternalTextureImpl* externalTexture = null,
            Origin3D? origin = null,
            Extent2D? naturalSize = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (externalTexture is not null)
            {
                ExternalTexture = externalTexture;
            }

            if (origin is not null)
            {
                Origin = origin.Value;
            }

            if (naturalSize is not null)
            {
                NaturalSize = naturalSize.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUExternalTexture")]
        [NativeName("Type.Name", "WGPUExternalTexture")]
        [NativeName("Name", "externalTexture")]
        public ExternalTextureImpl* ExternalTexture;

        [NativeName("Type", "WGPUOrigin3D")]
        [NativeName("Type.Name", "WGPUOrigin3D")]
        [NativeName("Name", "origin")]
        public Origin3D Origin;

        [NativeName("Type", "WGPUExtent2D")]
        [NativeName("Type.Name", "WGPUExtent2D")]
        [NativeName("Name", "naturalSize")]
        public Extent2D NaturalSize;
    }
}
