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
    [NativeName("Name", "WGPUPipelineLayoutPixelLocalStorage")]
    public unsafe partial struct PipelineLayoutPixelLocalStorage
    {
        public PipelineLayoutPixelLocalStorage
        (
            ChainedStruct? chain = null,
            ulong? totalPixelLocalStorageSize = null,
            nuint? storageAttachmentCount = null,
            PipelineLayoutStorageAttachment* storageAttachments = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (totalPixelLocalStorageSize is not null)
            {
                TotalPixelLocalStorageSize = totalPixelLocalStorageSize.Value;
            }

            if (storageAttachmentCount is not null)
            {
                StorageAttachmentCount = storageAttachmentCount.Value;
            }

            if (storageAttachments is not null)
            {
                StorageAttachments = storageAttachments;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "totalPixelLocalStorageSize")]
        public ulong TotalPixelLocalStorageSize;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "storageAttachmentCount")]
        public nuint StorageAttachmentCount;

        [NativeName("Type", "const WGPUPipelineLayoutStorageAttachment *")]
        [NativeName("Type.Name", "const WGPUPipelineLayoutStorageAttachment *")]
        [NativeName("Name", "storageAttachments")]
        public PipelineLayoutStorageAttachment* StorageAttachments;
    }
}
