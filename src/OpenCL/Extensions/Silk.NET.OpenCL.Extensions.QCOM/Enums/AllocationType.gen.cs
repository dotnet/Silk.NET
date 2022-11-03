// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "cl_uint allocation_type")]
    public enum AllocationType : int
    {
        [NativeName("Name", "CL_MEM_ION_HOST_PTR_QCOM")]
        IonHostPtr = 0x40A8,
        [NativeName("Name", "CL_MEM_ANDROID_NATIVE_BUFFER_HOST_PTR_QCOM")]
        AndroidNativeBufferHostPtr = 0x40C6,
    }
}
