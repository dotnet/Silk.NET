// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIDEO_FIELD_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FIELD_TYPE"]/*'/>
public enum D3D12_VIDEO_FIELD_TYPE
{
    /// <include file='D3D12_VIDEO_FIELD_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FIELD_TYPE.D3D12_VIDEO_FIELD_TYPE_NONE"]/*'/>
    D3D12_VIDEO_FIELD_TYPE_NONE = 0,
    /// <include file='D3D12_VIDEO_FIELD_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FIELD_TYPE.D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST"]/*'/>
    D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST = 1,
    /// <include file='D3D12_VIDEO_FIELD_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FIELD_TYPE.D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST"]/*'/>
    D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST = 2,
}