// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_khronos_vendor_id")]
    public enum KhronosVendorId : int
    {
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_CODEPLAY")]
        Codeplay = 0x10004,
        [NativeName("Name", "CL_KHRONOS_VENDOR_ID_POCL")]
        Pocl = 0x10006,
    }
}
