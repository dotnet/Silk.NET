// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE"]/*'/>
public partial struct D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.IOCoherent"]/*'/>

    public BOOL IOCoherent;
}
