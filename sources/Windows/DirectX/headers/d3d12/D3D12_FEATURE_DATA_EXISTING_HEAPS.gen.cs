// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_EXISTING_HEAPS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_EXISTING_HEAPS"]/*' />
public partial struct D3D12_FEATURE_DATA_EXISTING_HEAPS
{
    /// <include file='D3D12_FEATURE_DATA_EXISTING_HEAPS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_EXISTING_HEAPS.Supported"]/*' />
    public BOOL Supported;
}
