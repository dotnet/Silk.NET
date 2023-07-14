// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_STAGING_BUFFER_SIZE")]
    public enum StagingBufferSize : uint
    {
        [Obsolete("Deprecated in favour of \"Size0\"")]
        [NativeName("Name", "DSTORAGE_STAGING_BUFFER_SIZE_0")]
        StagingBufferSize0 = 0x0,
        [Obsolete("Deprecated in favour of \"Size32MB\"")]
        [NativeName("Name", "DSTORAGE_STAGING_BUFFER_SIZE_32MB")]
        StagingBufferSize32MB = 0x2000000,
        [NativeName("Name", "DSTORAGE_STAGING_BUFFER_SIZE_0")]
        Size0 = 0x0,
        [NativeName("Name", "DSTORAGE_STAGING_BUFFER_SIZE_32MB")]
        Size32MB = 0x2000000,
    }
}
