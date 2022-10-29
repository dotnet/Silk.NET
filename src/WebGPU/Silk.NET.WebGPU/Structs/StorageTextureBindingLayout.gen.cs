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
    [NativeName("Name", "WGPUStorageTextureBindingLayout")]
    public unsafe partial struct StorageTextureBindingLayout
    {
        public StorageTextureBindingLayout
        (
            ChainedStruct* nextInChain = null,
            StorageTextureAccess? access = null,
            TextureFormat? format = null,
            TextureViewDimension? viewDimension = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (access is not null)
            {
                Access = access.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStorageTextureAccess")]
        [NativeName("Type.Name", "WGPUStorageTextureAccess")]
        [NativeName("Name", "access")]
        public StorageTextureAccess Access;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "WGPUTextureViewDimension")]
        [NativeName("Type.Name", "WGPUTextureViewDimension")]
        [NativeName("Name", "viewDimension")]
        public TextureViewDimension ViewDimension;
    }
}
