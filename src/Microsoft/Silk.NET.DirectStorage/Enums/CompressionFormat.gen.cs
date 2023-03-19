// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_COMPRESSION_FORMAT")]
    public enum CompressionFormat : byte
    {
        [NativeName("Name", "DSTORAGE_COMPRESSION_FORMAT_NONE")]
        CompressionFormatNone = 0x0,
        [NativeName("Name", "DSTORAGE_COMPRESSION_FORMAT_GDEFLATE")]
        CompressionFormatGdeflate = 0x1,
        [NativeName("Name", "DSTORAGE_CUSTOM_COMPRESSION_0")]
        CustomCompression0 = unchecked((byte) 0xFFFFFFFFFFFFFF80),
    }
}
