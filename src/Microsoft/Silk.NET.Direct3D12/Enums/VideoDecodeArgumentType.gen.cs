// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE")]
    public enum VideoDecodeArgumentType : int
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
