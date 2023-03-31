// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_OUTLINE_THRESHOLD")]
    public enum OutlineThreshold : int
    {
        [NativeName("Name", "DWRITE_OUTLINE_THRESHOLD_ANTIALIASED")]
        Antialiased = 0x0,
        [NativeName("Name", "DWRITE_OUTLINE_THRESHOLD_ALIASED")]
        Aliased = 0x1,
    }
}
