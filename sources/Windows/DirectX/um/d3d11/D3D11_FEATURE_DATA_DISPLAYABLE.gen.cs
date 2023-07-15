// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D11_FEATURE_DATA_DISPLAYABLE"]/*'/>
public partial struct D3D11_FEATURE_DATA_DISPLAYABLE
{
    /// <include file='D3D11_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D11_FEATURE_DATA_DISPLAYABLE.DisplayableTexture"]/*'/>
    public BOOL DisplayableTexture;
    /// <include file='D3D11_FEATURE_DATA_DISPLAYABLE.xml' path='doc/member[@name="D3D11_FEATURE_DATA_DISPLAYABLE.SharedResourceTier"]/*'/>
    public D3D11_SHARED_RESOURCE_TIER SharedResourceTier;
}