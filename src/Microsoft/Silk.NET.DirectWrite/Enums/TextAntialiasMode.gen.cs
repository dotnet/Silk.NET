// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TEXT_ANTIALIAS_MODE")]
    public enum TextAntialiasMode : int
    {
        [NativeName("Name", "DWRITE_TEXT_ANTIALIAS_MODE_CLEARTYPE")]
        Cleartype = 0x0,
        [NativeName("Name", "DWRITE_TEXT_ANTIALIAS_MODE_GRAYSCALE")]
        Grayscale = 0x1,
    }
}
