// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [NativeName("Name", "cl_icdl_info")]
    public enum IcdlInfo : int
    {
        [NativeName("Name", "CL_ICDL_OCL_VERSION")]
        OclVersion = 0x1,
        [NativeName("Name", "CL_ICDL_VERSION")]
        Version = 0x2,
        [NativeName("Name", "CL_ICDL_NAME")]
        Name = 0x3,
        [NativeName("Name", "CL_ICDL_VENDOR")]
        Vendor = 0x4,
    }
}
