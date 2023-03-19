// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_TYPE")]
    public enum RequestSourceType : ulong
    {
        [Obsolete("Deprecated in favour of \"File\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_FILE")]
        RequestSourceFile = 0x0,
        [Obsolete("Deprecated in favour of \"Memory\"")]
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_MEMORY")]
        RequestSourceMemory = 0x1,
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_FILE")]
        File = 0x0,
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_MEMORY")]
        Memory = 0x1,
    }
}
