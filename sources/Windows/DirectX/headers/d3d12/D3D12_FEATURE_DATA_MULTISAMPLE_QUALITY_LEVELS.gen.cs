// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS"]/*' />
public partial struct D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS
{
    /// <include file='D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.SampleCount"]/*' />
    public uint SampleCount;

    /// <include file='D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.Flags"]/*' />
    public D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags;

    /// <include file='D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS.NumQualityLevels"]/*' />
    public uint NumQualityLevels;
}
