// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_device_integer_dot_product_capabilities_khr")]
    public enum DeviceIntegerDotProductCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_KHR")]
        Khr = 0x2,
        [NativeName("Name", "CL_DEVICE_INTEGER_DOT_PRODUCT_INPUT_4x8BIT_PACKED_KHR")]
        Packed = 0x1,
    }
}
