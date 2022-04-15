// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_accelerator_type_intel")]
    public enum AcceleratorType : int
    {
        [NativeName("Name", "CL_ACCELERATOR_TYPE_MOTION_ESTIMATION_INTEL")]
        MotionEstimation = 0x0,
    }
}
