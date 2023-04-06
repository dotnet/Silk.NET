// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_OPTICAL_ALIGNMENT")]
    public enum OpticalAlignment : int
    {
        [NativeName("Name", "DWRITE_OPTICAL_ALIGNMENT_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_OPTICAL_ALIGNMENT_NO_SIDE_BEARINGS")]
        NoSideBearings = 0x1,
    }
}
