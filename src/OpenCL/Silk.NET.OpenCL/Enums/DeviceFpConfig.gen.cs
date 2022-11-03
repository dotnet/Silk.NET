// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_fp_config")]
    public enum DeviceFpConfig : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_FP_DENORM")]
        Denorm = 0x1,
        [NativeName("Name", "CL_FP_INF_NAN")]
        InfNan = 0x2,
        [NativeName("Name", "CL_FP_ROUND_TO_NEAREST")]
        RoundToNearest = 0x4,
        [NativeName("Name", "CL_FP_ROUND_TO_ZERO")]
        RoundToZero = 0x8,
        [NativeName("Name", "CL_FP_ROUND_TO_INF")]
        RoundToInf = 0x10,
        [NativeName("Name", "CL_FP_FMA")]
        Fma = 0x20,
        [NativeName("Name", "CL_FP_SOFT_FLOAT")]
        SoftFloat = 0x40,
        [NativeName("Name", "CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
        CorrectlyRoundedDivideSqrt = 0x80,
    }
}
