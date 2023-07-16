// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D11_FENCE_FLAG.xml' path='doc/member[@name="D3D11_FENCE_FLAG"]/*'/>
[Flags]
public enum D3D11_FENCE_FLAG
{
    /// <include file='D3D11_FENCE_FLAG.xml' path='doc/member[@name="D3D11_FENCE_FLAG.D3D11_FENCE_FLAG_NONE"]/*'/>
    D3D11_FENCE_FLAG_NONE = 0,
    /// <include file='D3D11_FENCE_FLAG.xml' path='doc/member[@name="D3D11_FENCE_FLAG.D3D11_FENCE_FLAG_SHARED"]/*'/>
    D3D11_FENCE_FLAG_SHARED = 0x2,
    /// <include file='D3D11_FENCE_FLAG.xml' path='doc/member[@name="D3D11_FENCE_FLAG.D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER"]/*'/>
    D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER = 0x4,
    /// <include file='D3D11_FENCE_FLAG.xml' path='doc/member[@name="D3D11_FENCE_FLAG.D3D11_FENCE_FLAG_NON_MONITORED"]/*'/>
    D3D11_FENCE_FLAG_NON_MONITORED = 0x8,
}