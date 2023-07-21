// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D11_BUFFER_UAV_FLAG.xml' path='doc/member[@name="D3D11_BUFFER_UAV_FLAG"]/*' />
[Flags]
public enum D3D11_BUFFER_UAV_FLAG
{
    /// <include file='D3D11_BUFFER_UAV_FLAG.xml' path='doc/member[@name="D3D11_BUFFER_UAV_FLAG.D3D11_BUFFER_UAV_FLAG_RAW"]/*' />
    D3D11_BUFFER_UAV_FLAG_RAW = 0x1,

    /// <include file='D3D11_BUFFER_UAV_FLAG.xml' path='doc/member[@name="D3D11_BUFFER_UAV_FLAG.D3D11_BUFFER_UAV_FLAG_APPEND"]/*' />
    D3D11_BUFFER_UAV_FLAG_APPEND = 0x2,

    /// <include file='D3D11_BUFFER_UAV_FLAG.xml' path='doc/member[@name="D3D11_BUFFER_UAV_FLAG.D3D11_BUFFER_UAV_FLAG_COUNTER"]/*' />
    D3D11_BUFFER_UAV_FLAG_COUNTER = 0x4,
}
