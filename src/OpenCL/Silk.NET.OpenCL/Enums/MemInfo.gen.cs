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
        MemType = 0x1100,
        [NativeName("Name", "CL_MEM_FLAGS")]
        MemFlags = 0x1101,
        [NativeName("Name", "CL_MEM_SIZE")]
        MemSize = 0x1102,
        [NativeName("Name", "CL_MEM_HOST_PTR")]
        MemHostPtr = 0x1103,
        [NativeName("Name", "CL_MEM_MAP_COUNT")]
        MemMapCount = 0x1104,
        [NativeName("Name", "CL_MEM_REFERENCE_COUNT")]
        MemReferenceCount = 0x1105,
        [NativeName("Name", "CL_MEM_CONTEXT")]
        MemContext = 0x1106,
        [NativeName("Name", "CL_MEM_ASSOCIATED_MEMOBJECT")]
        MemAssociatedMemobject = 0x1107,
        [NativeName("Name", "CL_MEM_OFFSET")]
        MemOffset = 0x1108,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER")]
        MemUsesSvmPointer = 0x1109,
        [NativeName("Name", "CL_MEM_PROPERTIES")]
        MemProperties = 0x110A,
        [NativeName("Name", "CL_MEM_D3D10_RESOURCE_KHR")]
        MemD3D10ResourceKhr = 0x4015,
        [NativeName("Name", "CL_MEM_D3D11_RESOURCE_KHR")]
        MemD3D11ResourceKhr = 0x401E,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_ADAPTER_TYPE_KHR")]
        MemDX9MediaAdapterTypeKhr = 0x2028,
        [NativeName("Name", "CL_MEM_DX9_MEDIA_SURFACE_INFO_KHR")]
        MemDX9MediaSurfaceInfoKhr = 0x2029,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER_ARM")]
        MemUsesSvmPointerArm = 0x40B7,
        [NativeName("Name", "CL_MEM_VA_API_MEDIA_SURFACE_INTEL")]
        MemVAApiMediaSurfaceIntel = 0x4098,
        [NativeName("Name", "CL_MEM_DX9_RESOURCE_INTEL")]
        MemDX9ResourceIntel = 0x4027,
        [NativeName("Name", "CL_MEM_DX9_SHARED_HANDLE_INTEL")]
        MemDX9SharedHandleIntel = 0x4074,
    }
}
