// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [NativeName("Name", "cl_image_pitch_info_qcom")]
    public enum ImagePitchInfo : int
    {
        [NativeName("Name", "CL_IMAGE_ROW_ALIGNMENT_QCOM")]
        RowAlignment = 0x40A2,
        [NativeName("Name", "CL_IMAGE_SLICE_ALIGNMENT_QCOM")]
        SliceAlignment = 0x40A3,
    }
}
