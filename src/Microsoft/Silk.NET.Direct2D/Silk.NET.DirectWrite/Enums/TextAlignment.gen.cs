// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TEXT_ALIGNMENT")]
    public enum TextAlignment : int
    {
        [NativeName("Name", "DWRITE_TEXT_ALIGNMENT_LEADING")]
        Leading = 0x0,
        [NativeName("Name", "DWRITE_TEXT_ALIGNMENT_TRAILING")]
        Trailing = 0x1,
        [NativeName("Name", "DWRITE_TEXT_ALIGNMENT_CENTER")]
        Center = 0x2,
        [NativeName("Name", "DWRITE_TEXT_ALIGNMENT_JUSTIFIED")]
        Justified = 0x3,
    }
}
