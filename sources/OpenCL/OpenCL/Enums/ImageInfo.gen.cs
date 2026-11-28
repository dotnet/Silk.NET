// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_image_info")]
public enum ImageInfo : uint
{
    [NativeName("CL_IMAGE_FORMAT")]
    Format = 4368,

    [NativeName("CL_IMAGE_ELEMENT_SIZE")]
    ElementSize = 4369,

    [NativeName("CL_IMAGE_ROW_PITCH")]
    RowPitch = 4370,

    [NativeName("CL_IMAGE_SLICE_PITCH")]
    SlicePitch = 4371,

    [NativeName("CL_IMAGE_WIDTH")]
    Width = 4372,

    [NativeName("CL_IMAGE_HEIGHT")]
    Height = 4373,

    [NativeName("CL_IMAGE_DEPTH")]
    Depth = 4374,

    [NativeName("CL_IMAGE_ARRAY_SIZE")]
    ArraySize = 4375,

    [NativeName("CL_IMAGE_BUFFER")]
    Buffer = 4376,

    [NativeName("CL_IMAGE_NUM_MIP_LEVELS")]
    NumMipLevels = 4377,

    [NativeName("CL_IMAGE_NUM_SAMPLES")]
    NumSamples = 4378,

    [NativeName("CL_IMAGE_DX9_MEDIA_PLANE_KHR")]
    Dx9MediaPlaneKHR = 8234,

    [NativeName("CL_IMAGE_D3D10_SUBRESOURCE_KHR")]
    D3D10SubresourceKHR = 16406,

    [NativeName("CL_IMAGE_D3D11_SUBRESOURCE_KHR")]
    D3D11SubresourceKHR = 16415,

    [NativeName("CL_IMAGE_DX9_PLANE_INTEL")]
    Dx9PlaneINTEL = 16501,

    [NativeName("CL_IMAGE_VA_API_PLANE_INTEL")]
    VaApiPlaneINTEL = 16537,
}
