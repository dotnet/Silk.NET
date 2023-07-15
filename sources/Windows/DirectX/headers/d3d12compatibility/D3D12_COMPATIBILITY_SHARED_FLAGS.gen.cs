// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_COMPATIBILITY_SHARED_FLAGS.xml' path='doc/member[@name="D3D12_COMPATIBILITY_SHARED_FLAGS"]/*'/>
[Flags]
public enum D3D12_COMPATIBILITY_SHARED_FLAGS
{
    /// <include file='D3D12_COMPATIBILITY_SHARED_FLAGS.xml' path='doc/member[@name="D3D12_COMPATIBILITY_SHARED_FLAGS.D3D12_COMPATIBILITY_SHARED_FLAG_NONE"]/*'/>
    D3D12_COMPATIBILITY_SHARED_FLAG_NONE = 0,
    /// <include file='D3D12_COMPATIBILITY_SHARED_FLAGS.xml' path='doc/member[@name="D3D12_COMPATIBILITY_SHARED_FLAGS.D3D12_COMPATIBILITY_SHARED_FLAG_NON_NT_HANDLE"]/*'/>
    D3D12_COMPATIBILITY_SHARED_FLAG_NON_NT_HANDLE = 0x1,
    /// <include file='D3D12_COMPATIBILITY_SHARED_FLAGS.xml' path='doc/member[@name="D3D12_COMPATIBILITY_SHARED_FLAGS.D3D12_COMPATIBILITY_SHARED_FLAG_KEYED_MUTEX"]/*'/>
    D3D12_COMPATIBILITY_SHARED_FLAG_KEYED_MUTEX = 0x2,
    /// <include file='D3D12_COMPATIBILITY_SHARED_FLAGS.xml' path='doc/member[@name="D3D12_COMPATIBILITY_SHARED_FLAGS.D3D12_COMPATIBILITY_SHARED_FLAG_9_ON_12"]/*'/>
    D3D12_COMPATIBILITY_SHARED_FLAG_9_ON_12 = 0x4,
}