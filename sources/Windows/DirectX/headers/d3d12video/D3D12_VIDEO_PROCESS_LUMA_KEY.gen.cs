// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_LUMA_KEY
{
    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Enable"]/*'/>
    public BOOL Enable;
    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Lower"]/*'/>
    public float Lower;
    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Upper"]/*'/>
    public float Upper;
}