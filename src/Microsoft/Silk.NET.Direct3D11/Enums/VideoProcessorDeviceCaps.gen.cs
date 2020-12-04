// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS")]
    public enum VideoProcessorDeviceCaps
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE")]
        VideoProcessorDeviceCapsLinearSpace = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC")]
        VideoProcessorDeviceCapsXvYcc = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION")]
        VideoProcessorDeviceCapsRgbRangeConversion = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION")]
        VideoProcessorDeviceCapsYCbCrMatrixConversion = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE")]
        VideoProcessorDeviceCapsNominalRange = 0x10,
    }
}
