// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_image_requirements_info_ext")]
public enum ImageRequirementsInfoEXT : uint
{
    [NativeName("CL_IMAGE_REQUIREMENTS_BASE_ADDRESS_ALIGNMENT_EXT")]
    BaseAddressAlignment = 4754,

    [NativeName("CL_IMAGE_REQUIREMENTS_ROW_PITCH_ALIGNMENT_EXT")]
    RowPitchAlignment = 4752,

    [NativeName("CL_IMAGE_REQUIREMENTS_SIZE_EXT")]
    Size = 4786,

    [NativeName("CL_IMAGE_REQUIREMENTS_MAX_WIDTH_EXT")]
    MaxWidth = 4787,

    [NativeName("CL_IMAGE_REQUIREMENTS_MAX_HEIGHT_EXT")]
    MaxHeight = 4788,

    [NativeName("CL_IMAGE_REQUIREMENTS_MAX_DEPTH_EXT")]
    MaxDepth = 4789,

    [NativeName("CL_IMAGE_REQUIREMENTS_MAX_ARRAY_SIZE_EXT")]
    MaxArraySize = 4790,

    [NativeName("CL_IMAGE_REQUIREMENTS_SLICE_PITCH_ALIGNMENT_EXT")]
    SlicePitchAlignment = 4753,
}
