// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_fp_config")]
    public enum DeviceFpConfig : ulong
    {
        [NativeName("Name", "CL_FP_DENORM")]
        FPDenorm = 0x1,
        [NativeName("Name", "CL_FP_INF_NAN")]
        FPInfNan = 0x2,
        [NativeName("Name", "CL_FP_ROUND_TO_NEAREST")]
        FPRoundToNearest = 0x4,
        [NativeName("Name", "CL_FP_ROUND_TO_ZERO")]
        FPRoundToZero = 0x8,
        [NativeName("Name", "CL_FP_ROUND_TO_INF")]
        FPRoundToInf = 0x10,
        [NativeName("Name", "CL_FP_FMA")]
        FPFma = 0x20,
        [NativeName("Name", "CL_FP_SOFT_FLOAT")]
        FPSoftFloat = 0x40,
        [NativeName("Name", "CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
        FPCorrectlyRoundedDivideSqrt = 0x80,
    }
}
