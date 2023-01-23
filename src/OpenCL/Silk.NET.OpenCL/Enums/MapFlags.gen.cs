// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_map_flags")]
    public enum MapFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MAP_READ")]
        Read = 0x1,
        [NativeName("Name", "CL_MAP_WRITE")]
        Write = 0x2,
        [NativeName("Name", "CL_MAP_WRITE_INVALIDATE_REGION")]
        WriteInvalidateRegion = 0x4,
    }
}
