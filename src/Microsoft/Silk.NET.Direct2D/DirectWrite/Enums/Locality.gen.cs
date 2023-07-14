// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_LOCALITY")]
    public enum Locality : int
    {
        [NativeName("Name", "DWRITE_LOCALITY_REMOTE")]
        Remote = 0x0,
        [NativeName("Name", "DWRITE_LOCALITY_PARTIAL")]
        Partial = 0x1,
        [NativeName("Name", "DWRITE_LOCALITY_LOCAL")]
        Local = 0x2,
    }
}
