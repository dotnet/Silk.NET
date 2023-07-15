// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.Mode"]/*'/>
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE Mode;
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.Flags"]/*'/>
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS Flags;
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.ConfigParams"]/*'/>
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS ConfigParams;
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.TargetFrameRate"]/*'/>
    public DXGI_RATIONAL TargetFrameRate;
}