// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_filter_mode")]
    public enum FilterMode : int
    {
        [NativeName("Name", "CL_FILTER_NEAREST")]
        Nearest = 0x1140,
        [NativeName("Name", "CL_FILTER_LINEAR")]
        Linear = 0x1141,
    }
}
