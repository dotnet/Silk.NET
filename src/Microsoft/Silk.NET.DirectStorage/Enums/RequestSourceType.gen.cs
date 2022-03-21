// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_TYPE")]
    public enum RequestSourceType : ulong
    {
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_FILE")]
        RequestSourceFile = 0x0,
        [NativeName("Name", "DSTORAGE_REQUEST_SOURCE_MEMORY")]
        RequestSourceMemory = 0x1,
    }
}
