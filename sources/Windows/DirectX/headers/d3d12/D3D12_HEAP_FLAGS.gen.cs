// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS"]/*'/>
[Flags]
public enum D3D12_HEAP_FLAGS
{
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_NONE"]/*'/>
    D3D12_HEAP_FLAG_NONE = 0,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_SHARED"]/*'/>
    D3D12_HEAP_FLAG_SHARED = 0x1,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_BUFFERS"]/*'/>
    D3D12_HEAP_FLAG_DENY_BUFFERS = 0x4,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_DISPLAY"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_DISPLAY = 0x8,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER"]/*'/>
    D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER = 0x20,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES"]/*'/>
    D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES = 0x40,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES"]/*'/>
    D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES = 0x80,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_HARDWARE_PROTECTED"]/*'/>
    D3D12_HEAP_FLAG_HARDWARE_PROTECTED = 0x100,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH = 0x200,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS = 0x400,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT"]/*'/>
    D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT = 0x800,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_CREATE_NOT_ZEROED"]/*'/>
    D3D12_HEAP_FLAG_CREATE_NOT_ZEROED = 0x1000,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES = 0,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS = 0xc0,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES = 0x44,
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES"]/*'/>
    D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES = 0x84,
}