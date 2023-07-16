// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13"]/*'/>
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS13
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.UnrestrictedBufferTextureCopyPitchSupported"]/*'/>
    public BOOL UnrestrictedBufferTextureCopyPitchSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.UnrestrictedVertexElementAlignmentSupported"]/*'/>
    public BOOL UnrestrictedVertexElementAlignmentSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.InvertedViewportHeightFlipsYSupported"]/*'/>
    public BOOL InvertedViewportHeightFlipsYSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.InvertedViewportDepthFlipsZSupported"]/*'/>
    public BOOL InvertedViewportDepthFlipsZSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.TextureCopyBetweenDimensionsSupported"]/*'/>
    public BOOL TextureCopyBetweenDimensionsSupported;
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.AlphaBlendFactorSupported"]/*'/>
    public BOOL AlphaBlendFactorSupported;
}