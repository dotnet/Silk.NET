// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [NativeName("Name", "cl_image_requirements_info_ext")]
    public enum ImageRequirementsInfo : int
    {
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_BASE_ADDRESS_ALIGNMENT_EXT")]
        BaseAddressAlignment = 0x1292,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_ROW_PITCH_ALIGNMENT_EXT")]
        RowPitchAlignment = 0x1290,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SIZE_EXT")]
        Size = 0x12B2,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_WIDTH_EXT")]
        MaxWidth = 0x12B3,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_HEIGHT_EXT")]
        MaxHeight = 0x12B4,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_DEPTH_EXT")]
        MaxDepth = 0x12B5,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_MAX_ARRAY_SIZE_EXT")]
        MaxArraySize = 0x12B6,
        [NativeName("Name", "CL_IMAGE_REQUIREMENTS_SLICE_PITCH_ALIGNMENT_EXT")]
        SlicePitchAlignment = 0x1291,
    }
}
