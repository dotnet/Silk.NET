// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE")]
    public enum VideoDecodeArgumentType
    {
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS")]
        VideoDecodeArgumentTypePictureParameters = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX")]
        VideoDecodeArgumentTypeInverseQuantizationMatrix = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL")]
        VideoDecodeArgumentTypeSliceControl = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID")]
        VideoDecodeArgumentTypeMaxValid = 0x3,
    }
}
