// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_CUSTOM_DECOMPRESSION_FLAGS")]
    public enum CustomDecompressionFlags : uint
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "DSTORAGE_CUSTOM_DECOMPRESSION_FLAG_NONE")]
        CustomDecompressionFlagNone = 0x0,
        [NativeName("Name", "DSTORAGE_CUSTOM_DECOMPRESSION_FLAG_DEST_IN_UPLOAD_HEAP")]
        CustomDecompressionFlagDestInUploadHeap = 0x1,
    }
}
