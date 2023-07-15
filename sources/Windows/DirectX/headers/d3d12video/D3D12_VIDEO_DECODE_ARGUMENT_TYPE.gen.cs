// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE"]/*'/>
public enum D3D12_VIDEO_DECODE_ARGUMENT_TYPE
{
    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS"]/*'/>
    D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS = 0,
    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX"]/*'/>
    D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX = 1,
    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL"]/*'/>
    D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL = 2,
    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID"]/*'/>
    D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID = 3,
}