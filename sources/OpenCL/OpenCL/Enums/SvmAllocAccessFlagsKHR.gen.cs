// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_svm_alloc_access_flags_khr")]
[Flags]
public enum SvmAllocAccessFlagsKHR : ulong
{
    None = 0x0,

    [NativeName("CL_SVM_ALLOC_ACCESS_HOST_NOREAD_KHR")]
    HostNoread = 0x1,

    [NativeName("CL_SVM_ALLOC_ACCESS_HOST_NOWRITE_KHR")]
    HostNowrite = 0x2,

    [NativeName("CL_SVM_ALLOC_ACCESS_DEVICE_NOREAD_KHR")]
    DeviceNoread = 0x100,

    [NativeName("CL_SVM_ALLOC_ACCESS_DEVICE_NOWRITE_KHR")]
    DeviceNowrite = 0x200,
}
