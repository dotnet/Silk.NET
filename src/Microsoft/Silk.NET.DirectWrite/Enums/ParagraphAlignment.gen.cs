// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PARAGRAPH_ALIGNMENT")]
    public enum ParagraphAlignment : int
    {
        [NativeName("Name", "DWRITE_PARAGRAPH_ALIGNMENT_NEAR")]
        Near = 0x0,
        [NativeName("Name", "DWRITE_PARAGRAPH_ALIGNMENT_FAR")]
        Far = 0x1,
        [NativeName("Name", "DWRITE_PARAGRAPH_ALIGNMENT_CENTER")]
        Center = 0x2,
    }
}
