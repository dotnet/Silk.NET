// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPULoadOp")]
    public enum LoadOp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPULoadOp_Undefined")]
        LoadOpUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Clear\"")]
        [NativeName("Name", "WGPULoadOp_Clear")]
        LoadOpClear = 0x1,
        [Obsolete("Deprecated in favour of \"Load\"")]
        [NativeName("Name", "WGPULoadOp_Load")]
        LoadOpLoad = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPULoadOp_Force32")]
        LoadOpForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPULoadOp_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPULoadOp_Clear")]
        Clear = 0x1,
        [NativeName("Name", "WGPULoadOp_Load")]
        Load = 0x2,
        [NativeName("Name", "WGPULoadOp_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
