// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_info")]
    public enum MemInfo : int
    {
        [NativeName("Name", "CL_MEM_TYPE")]
        Type = 0x1100,
        [NativeName("Name", "CL_MEM_FLAGS")]
        Flags = 0x1101,
        [NativeName("Name", "CL_MEM_SIZE")]
        Size = 0x1102,
        [NativeName("Name", "CL_MEM_HOST_PTR")]
        HostPtr = 0x1103,
        [NativeName("Name", "CL_MEM_MAP_COUNT")]
        MapCount = 0x1104,
        [NativeName("Name", "CL_MEM_REFERENCE_COUNT")]
        ReferenceCount = 0x1105,
        [NativeName("Name", "CL_MEM_CONTEXT")]
        Context = 0x1106,
        [NativeName("Name", "CL_MEM_ASSOCIATED_MEMOBJECT")]
        AssociatedMemobject = 0x1107,
        [NativeName("Name", "CL_MEM_OFFSET")]
        Offset = 0x1108,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER")]
        UsesSvmPointer = 0x1109,
        [NativeName("Name", "CL_MEM_PROPERTIES")]
        Properties = 0x110A,
        [NativeName("Name", "CL_MEM_D3D10_RESOURCE_KHR")]
        D3D10ResourceKhr = 0x4015,
        [NativeName("Name", "CL_MEM_D3D11_RESOURCE_KHR")]
        D3D11ResourceKhr = 0x401E,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR")]
        DX9MediaAdapterTypeKhr = 0x2028,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR")]
        DX9MediaSurfaceInfoKhr = 0x2029,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER_ARM")]
        UsesSvmPointerArm = 0x40B7,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        VAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        DX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        DX9SharedHandleIntel = 0x4074,
        [NativeName("Name", "CL_MEM_DEVICE_ADDRESS_EXT")]
        DeviceAddressExt = 0x5001,
    }
}
