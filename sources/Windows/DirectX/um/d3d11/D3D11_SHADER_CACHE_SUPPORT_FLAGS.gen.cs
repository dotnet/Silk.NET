// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D11_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D11_SHADER_CACHE_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum D3D11_SHADER_CACHE_SUPPORT_FLAGS
{
    /// <include file='D3D11_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D11_SHADER_CACHE_SUPPORT_FLAGS.D3D11_SHADER_CACHE_SUPPORT_NONE"]/*'/>
    D3D11_SHADER_CACHE_SUPPORT_NONE = 0,
    /// <include file='D3D11_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D11_SHADER_CACHE_SUPPORT_FLAGS.D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE"]/*'/>
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x1,
    /// <include file='D3D11_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D11_SHADER_CACHE_SUPPORT_FLAGS.D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE"]/*'/>
    D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x2,
}