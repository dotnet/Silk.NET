// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_svm_pointer_info_khr")]
    public enum SvmPointerInfo : int
    {
        [NativeName("Name", "CL_SVM_INFO_TYPE_INDEX_KHR")]
        TypeIndex = 0x2088,
        [NativeName("Name", "CL_SVM_INFO_CAPABILITIES_KHR")]
        Capabilities = 0x2089,
        [NativeName("Name", "CL_SVM_INFO_PROPERTIES_KHR")]
        Properties = 0x208A,
        [NativeName("Name", "CL_SVM_INFO_ACCESS_FLAGS_KHR")]
        AccessFlags = 0x208B,
        [NativeName("Name", "CL_SVM_INFO_BASE_PTR_KHR")]
        BasePtr = 0x419B,
        [NativeName("Name", "CL_SVM_INFO_SIZE_KHR")]
        Size = 0x419C,
        [NativeName("Name", "CL_SVM_INFO_ASSOCIATED_DEVICE_HANDLE_KHR")]
        AssociatedDeviceHandle = 0x419D,
    }
}
