// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_svm_alloc_access_flags_khr")]
    public enum SvmAllocAccessFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_SVM_ALLOC_ACCESS_HOST_NOREAD_KHR")]
        HostNoread = 0x1,
        [NativeName("Name", "CL_SVM_ALLOC_ACCESS_HOST_NOWRITE_KHR")]
        HostNowrite = 0x2,
        [NativeName("Name", "CL_SVM_ALLOC_ACCESS_DEVICE_NOREAD_KHR")]
        DeviceNoread = 0x100,
        [NativeName("Name", "CL_SVM_ALLOC_ACCESS_DEVICE_NOWRITE_KHR")]
        DeviceNowrite = 0x200,
    }
}
