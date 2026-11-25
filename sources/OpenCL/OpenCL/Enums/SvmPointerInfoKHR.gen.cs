// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_svm_pointer_info_khr")]
public enum SvmPointerInfoKHR : uint
{
    [NativeName("CL_SVM_INFO_TYPE_INDEX_KHR")]
    TypeIndex = 8328,

    [NativeName("CL_SVM_INFO_CAPABILITIES_KHR")]
    Capabilities = 8329,

    [NativeName("CL_SVM_INFO_PROPERTIES_KHR")]
    Properties = 8330,

    [NativeName("CL_SVM_INFO_ACCESS_FLAGS_KHR")]
    AccessFlags = 8331,

    [NativeName("CL_SVM_INFO_BASE_PTR_KHR")]
    BasePtr = 16795,

    [NativeName("CL_SVM_INFO_SIZE_KHR")]
    Size = 16796,

    [NativeName("CL_SVM_INFO_ASSOCIATED_DEVICE_HANDLE_KHR")]
    AssociatedDeviceHandle = 16797,
}
