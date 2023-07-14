// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_GRID_FIT_MODE")]
    public enum GridFitMode : int
    {
        [NativeName("Name", "DWRITE_GRID_FIT_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_GRID_FIT_MODE_DISABLED")]
        Disabled = 0x1,
        [NativeName("Name", "DWRITE_GRID_FIT_MODE_ENABLED")]
        Enabled = 0x2,
    }
}
