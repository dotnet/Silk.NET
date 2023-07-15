// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DISPLAYABLE"]/*'/>
public partial struct D3D12_FEATURE_DATA_DISPLAYABLE
{
    /// <include file='D3D12_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DISPLAYABLE.DisplayableTexture"]/*'/>
    public BOOL DisplayableTexture;
    /// <include file='D3D12_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DISPLAYABLE.SharedResourceCompatibilityTier"]/*'/>
    public D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier;
}