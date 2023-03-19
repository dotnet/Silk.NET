// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_COMPRESSION")]
    public enum Compression : int
    {
        [Obsolete("Deprecated in favour of \"Fastest\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_FASTEST")]
        CompressionFastest = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_DEFAULT")]
        CompressionDefault = 0x0,
        [Obsolete("Deprecated in favour of \"BestRatio\"")]
        [NativeName("Name", "DSTORAGE_COMPRESSION_BEST_RATIO")]
        CompressionBestRatio = 0x1,
        [NativeName("Name", "DSTORAGE_COMPRESSION_FASTEST")]
        Fastest = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DSTORAGE_COMPRESSION_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DSTORAGE_COMPRESSION_BEST_RATIO")]
        BestRatio = 0x1,
    }
}
