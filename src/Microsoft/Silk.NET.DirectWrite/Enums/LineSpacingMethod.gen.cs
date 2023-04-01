// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_LINE_SPACING_METHOD")]
    public enum LineSpacingMethod : int
    {
        [NativeName("Name", "DWRITE_LINE_SPACING_METHOD_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_LINE_SPACING_METHOD_UNIFORM")]
        Uniform = 0x1,
        [NativeName("Name", "DWRITE_LINE_SPACING_METHOD_PROPORTIONAL")]
        Proportional = 0x2,
    }
}
