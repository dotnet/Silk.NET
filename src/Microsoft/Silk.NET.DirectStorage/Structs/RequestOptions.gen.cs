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
    [NativeName("Name", "DSTORAGE_REQUEST_OPTIONS")]
    public unsafe partial struct RequestOptions
    {
        public RequestOptions
        (
            CompressionFormat? compressionFormat = null,
            RequestSourceType? sourceType = null,
            RequestDestinationType? destinationType = null,
            ulong? reserved = null
        ) : this()
        {
            if (compressionFormat is not null)
            {
                CompressionFormat = compressionFormat.Value;
            }

            if (sourceType is not null)
            {
                SourceType = sourceType.Value;
            }

            if (destinationType is not null)
            {
                DestinationType = destinationType.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private byte _bitfield1;

        public CompressionFormat CompressionFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (CompressionFormat)(_bitfield1 & 0xFF);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((CompressionFormat)(_bitfield1 & ~0xFF) | (CompressionFormat)((byte)(value) & 0xFF));
        }
        [NativeName("Type", "UINT8[7]")]
        [NativeName("Type.Name", "UINT8[7]")]
        [NativeName("Name", "Reserved1")]
        public fixed byte Reserved1[7];

        private ulong _bitfield2;

        public RequestSourceType SourceType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (RequestSourceType)(_bitfield2 & 0x1UL);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (ulong)((RequestSourceType)(_bitfield2 & ~0x1UL) | (RequestSourceType)((ulong)(value) & 0x1UL));
        }

        public RequestDestinationType DestinationType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (RequestDestinationType)((_bitfield2 >> 1) & 0x7FUL);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (ulong)((RequestDestinationType)(_bitfield2 & ~(0x7FUL << 1)) | (RequestDestinationType)(((ulong)(value) & 0x7FUL) << 1));
        }

        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ulong)((_bitfield2 >> 8) & 0xFFFFUL);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield2 = (ulong)((ulong)(_bitfield2 & ~(0xFFFFUL << 8)) | (ulong)(((ulong)(value) & 0xFFFFUL) << 8));
        }
    }
}
