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
    [NativeName("Name", "WGPURenderPassStorageAttachment")]
    public unsafe partial struct RenderPassStorageAttachment
    {
        public RenderPassStorageAttachment
        (
            ChainedStruct* nextInChain = null,
            ulong? offset = null,
            TextureView* storage = null,
            LoadOp? loadOp = null,
            StoreOp? storeOp = null,
            Color? clearValue = null
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

            if (storage is not null)
            {
                Storage = storage;
            }

            if (loadOp is not null)
            {
                LoadOp = loadOp.Value;
            }

            if (storeOp is not null)
            {
                StoreOp = storeOp.Value;
            }

            if (clearValue is not null)
            {
                ClearValue = clearValue.Value;
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

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "storage")]
        public TextureView* Storage;

        [NativeName("Type", "WGPULoadOp")]
        [NativeName("Type.Name", "WGPULoadOp")]
        [NativeName("Name", "loadOp")]
        public LoadOp LoadOp;

        [NativeName("Type", "WGPUStoreOp")]
        [NativeName("Type.Name", "WGPUStoreOp")]
        [NativeName("Name", "storeOp")]
        public StoreOp StoreOp;

        [NativeName("Type", "WGPUColor")]
        [NativeName("Type.Name", "WGPUColor")]
        [NativeName("Name", "clearValue")]
        public Color ClearValue;
    }
}
