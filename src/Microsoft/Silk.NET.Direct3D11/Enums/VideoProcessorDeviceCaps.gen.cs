// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS")]
    public enum VideoProcessorDeviceCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"LinearSpace\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE")]
        VideoProcessorDeviceCapsLinearSpace = 0x1,
        [Obsolete("Deprecated in favour of \"XvYcc\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC")]
        VideoProcessorDeviceCapsXvYcc = 0x2,
        [Obsolete("Deprecated in favour of \"RgbRangeConversion\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION")]
        VideoProcessorDeviceCapsRgbRangeConversion = 0x4,
        [Obsolete("Deprecated in favour of \"YCbCrMatrixConversion\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION")]
        VideoProcessorDeviceCapsYCbCrMatrixConversion = 0x8,
        [Obsolete("Deprecated in favour of \"NominalRange\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE")]
        VideoProcessorDeviceCapsNominalRange = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE")]
        LinearSpace = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC")]
        XvYcc = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION")]
        RgbRangeConversion = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION")]
        YCbCrMatrixConversion = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE")]
        NominalRange = 0x10,
    }
}
