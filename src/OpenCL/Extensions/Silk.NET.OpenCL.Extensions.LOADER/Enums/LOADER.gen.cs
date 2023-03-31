// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [Flags]
    [NativeName("Name", "CLenum")]
    public enum LOADER : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_ICDL_OCL_VERSION")]
        OclVersion = 0x1,
        [NativeName("Name", "CL_ICDL_OCL_VERSION")]
        IcdlOclVersion = 0x1,
        [NativeName("Name", "CL_ICDL_VERSION")]
        Version = 0x2,
        [NativeName("Name", "CL_ICDL_VERSION")]
        IcdlVersion = 0x2,
        [NativeName("Name", "CL_ICDL_NAME")]
        Name = 0x3,
        [NativeName("Name", "CL_ICDL_NAME")]
        IcdlName = 0x3,
        [NativeName("Name", "CL_ICDL_VENDOR")]
        Vendor = 0x4,
        [NativeName("Name", "CL_ICDL_VENDOR")]
        IcdlVendor = 0x4,
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        ApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        LayerApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_NAME")]
        LayerName = 0x4241,
    }
}
