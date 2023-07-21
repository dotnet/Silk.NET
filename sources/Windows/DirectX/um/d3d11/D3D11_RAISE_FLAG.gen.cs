// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D11_RAISE_FLAG.xml' path='doc/member[@name="D3D11_RAISE_FLAG"]/*' />
[Flags]
public enum D3D11_RAISE_FLAG
{
    /// <include file='D3D11_RAISE_FLAG.xml' path='doc/member[@name="D3D11_RAISE_FLAG.D3D11_RAISE_FLAG_DRIVER_INTERNAL_ERROR"]/*' />
    D3D11_RAISE_FLAG_DRIVER_INTERNAL_ERROR = 0x1,
}
