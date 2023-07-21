// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.CopyQueueTimestampQueriesSupported"]/*' />
    public BOOL CopyQueueTimestampQueriesSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.CastingFullyTypedFormatSupported"]/*' />
    public BOOL CastingFullyTypedFormatSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.WriteBufferImmediateSupportFlags"]/*' />
    public D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.ViewInstancingTier"]/*' />
    public D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.BarycentricsSupported"]/*' />
    public BOOL BarycentricsSupported;
}
