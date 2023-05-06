// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_CONTAINER_TYPE")]
    public enum ContainerType : int
    {
        [NativeName("Name", "DWRITE_CONTAINER_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "DWRITE_CONTAINER_TYPE_WOFF")]
        Woff = 0x1,
        [NativeName("Name", "DWRITE_CONTAINER_TYPE_WOFF2")]
        Woff2 = 0x2,
    }
}
