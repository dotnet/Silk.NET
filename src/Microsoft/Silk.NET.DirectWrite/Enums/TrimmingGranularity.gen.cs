// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TRIMMING_GRANULARITY")]
    public enum TrimmingGranularity : int
    {
        [NativeName("Name", "DWRITE_TRIMMING_GRANULARITY_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_TRIMMING_GRANULARITY_CHARACTER")]
        Character = 0x1,
        [NativeName("Name", "DWRITE_TRIMMING_GRANULARITY_WORD")]
        Word = 0x2,
    }
}
