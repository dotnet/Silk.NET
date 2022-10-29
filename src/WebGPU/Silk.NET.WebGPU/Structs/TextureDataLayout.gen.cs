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
    [NativeName("Name", "WGPUTextureDataLayout")]
    public unsafe partial struct TextureDataLayout
    {
        public TextureDataLayout
        (
            ChainedStruct* nextInChain = null,
            ulong? offset = null,
            uint? bytesPerRow = null,
            uint? rowsPerImage = null
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

            if (bytesPerRow is not null)
            {
                BytesPerRow = bytesPerRow.Value;
            }

            if (rowsPerImage is not null)
            {
                RowsPerImage = rowsPerImage.Value;
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

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bytesPerRow")]
        public uint BytesPerRow;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "rowsPerImage")]
        public uint RowsPerImage;
    }
}
