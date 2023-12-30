// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_OBJECT_FLAGS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS"]/*'/>
[Flags]
public enum D3D12_STATE_OBJECT_FLAGS
{
    /// <include file='D3D12_STATE_OBJECT_FLAGS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS.D3D12_STATE_OBJECT_FLAG_NONE"]/*'/>

    D3D12_STATE_OBJECT_FLAG_NONE = 0,

    /// <include file='D3D12_STATE_OBJECT_FLAGS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS.D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS"]/*'/>

    D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS = 0x1,

    /// <include file='D3D12_STATE_OBJECT_FLAGS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS.D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS"]/*'/>

    D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS = 0x2,

    /// <include file='D3D12_STATE_OBJECT_FLAGS.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS.D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS"]/*'/>

    D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS = 0x4,
}
