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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_CUSTOM_DECOMPRESSION_REQUEST")]
    public unsafe partial struct CustomDecompressionRequest
    {
        public CustomDecompressionRequest
        (
            ulong? id = null,
            CompressionFormat? compressionFormat = null,
            CustomDecompressionFlags? flags = null,
            ulong? srcSize = null,
            void* srcBuffer = null,
            ulong? dstSize = null,
            void* dstBuffer = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (compressionFormat is not null)
            {
                CompressionFormat = compressionFormat.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (srcSize is not null)
            {
                SrcSize = srcSize.Value;
            }

            if (srcBuffer is not null)
            {
                SrcBuffer = srcBuffer;
            }

            if (dstSize is not null)
            {
                DstSize = dstSize.Value;
            }

            if (dstBuffer is not null)
            {
                DstBuffer = dstBuffer;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Id")]
        public ulong Id;

        [NativeName("Type", "DSTORAGE_COMPRESSION_FORMAT")]
        [NativeName("Type.Name", "DSTORAGE_COMPRESSION_FORMAT")]
        [NativeName("Name", "CompressionFormat")]
        public CompressionFormat CompressionFormat;
        [NativeName("Type", "UINT8[3]")]
        [NativeName("Type.Name", "UINT8[3]")]
        [NativeName("Name", "Reserved")]
        public fixed byte Reserved[3];

        [NativeName("Type", "DSTORAGE_CUSTOM_DECOMPRESSION_FLAGS")]
        [NativeName("Type.Name", "DSTORAGE_CUSTOM_DECOMPRESSION_FLAGS")]
        [NativeName("Name", "Flags")]
        public CustomDecompressionFlags Flags;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SrcSize")]
        public ulong SrcSize;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "SrcBuffer")]
        public void* SrcBuffer;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DstSize")]
        public ulong DstSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "DstBuffer")]
        public void* DstBuffer;
    }
}
