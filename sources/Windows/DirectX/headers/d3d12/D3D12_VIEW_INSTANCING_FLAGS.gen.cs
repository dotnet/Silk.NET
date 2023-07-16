// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D12_VIEW_INSTANCING_FLAGS.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_FLAGS"]/*'/>
[Flags]
public enum D3D12_VIEW_INSTANCING_FLAGS
{
    /// <include file='D3D12_VIEW_INSTANCING_FLAGS.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_FLAGS.D3D12_VIEW_INSTANCING_FLAG_NONE"]/*'/>
    D3D12_VIEW_INSTANCING_FLAG_NONE = 0,
    /// <include file='D3D12_VIEW_INSTANCING_FLAGS.xml' path='doc/member[@name="D3D12_VIEW_INSTANCING_FLAGS.D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING"]/*'/>
    D3D12_VIEW_INSTANCING_FLAG_ENABLE_VIEW_INSTANCE_MASKING = 0x1,
}