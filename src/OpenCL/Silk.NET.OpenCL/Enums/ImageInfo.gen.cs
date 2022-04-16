// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_image_info")]
    public enum ImageInfo : int
    {
        [NativeName("Name", "CL_IMAGE_FORMAT")]
        Format = 0x1110,
        [NativeName("Name", "CL_IMAGE_ELEMENT_SIZE")]
        ElementSize = 0x1111,
        [NativeName("Name", "CL_IMAGE_ROW_PITCH")]
        RowPitch = 0x1112,
        [NativeName("Name", "CL_IMAGE_SLICE_PITCH")]
        SlicePitch = 0x1113,
        [NativeName("Name", "CL_IMAGE_WIDTH")]
        Width = 0x1114,
        [NativeName("Name", "CL_IMAGE_HEIGHT")]
        Height = 0x1115,
        [NativeName("Name", "CL_IMAGE_DEPTH")]
        Depth = 0x1116,
        [NativeName("Name", "CL_IMAGE_ARRAY_SIZE")]
        ArraySize = 0x1117,
        [NativeName("Name", "CL_IMAGE_NUM_MIP_LEVELS")]
        NumMipLevels = 0x1119,
        [NativeName("Name", "CL_IMAGE_NUM_SAMPLES")]
        NumSamples = 0x111A,
        [System.Obsolete("Deprecated in version 2.0")]
        [NativeName("Name", "CL_IMAGE_BUFFER")]
        Buffer = 0x1118,
        [NativeName("Name", "CL_IMAGE_D3D10_SUBRESOURCE_KHR")]
        D3D10SubresourceKhr = 0x4016,
        [NativeName("Name", "CL_IMAGE_D3D11_SUBRESOURCE_KHR")]
        D3D11SubresourceKhr = 0x401F,
        [NativeName("Name", "CL_IMAGE_DX9_MEDIA_PLANE_KHR")]
        DX9MediaPlaneKhr = 0x202A,
        [NativeName("Name", "CL_IMAGE_VA_API_PLANE_INTEL")]
        VAApiPlaneIntel = 0x4099,
        [NativeName("Name", "CL_IMAGE_DX9_PLANE_INTEL")]
        DX9PlaneIntel = 0x4075,
    }
}
