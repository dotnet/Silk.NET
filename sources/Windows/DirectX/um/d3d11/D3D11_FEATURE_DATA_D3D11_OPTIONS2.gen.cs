// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.PSSpecifiedStencilRefSupported"]/*'/>
    public BOOL PSSpecifiedStencilRefSupported;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.TypedUAVLoadAdditionalFormats"]/*'/>
    public BOOL TypedUAVLoadAdditionalFormats;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.ROVsSupported"]/*'/>
    public BOOL ROVsSupported;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.ConservativeRasterizationTier"]/*'/>
    public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.TiledResourcesTier"]/*'/>
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.MapOnDefaultTextures"]/*'/>
    public BOOL MapOnDefaultTextures;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.StandardSwizzle"]/*'/>
    public BOOL StandardSwizzle;
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS2.UnifiedMemoryArchitecture"]/*'/>
    public BOOL UnifiedMemoryArchitecture;
}