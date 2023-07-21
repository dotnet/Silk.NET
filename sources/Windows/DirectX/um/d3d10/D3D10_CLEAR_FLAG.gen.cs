// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D10_CLEAR_FLAG.xml' path='doc/member[@name="D3D10_CLEAR_FLAG"]/*' />
[Flags]
public enum D3D10_CLEAR_FLAG
{
    /// <include file='D3D10_CLEAR_FLAG.xml' path='doc/member[@name="D3D10_CLEAR_FLAG.D3D10_CLEAR_DEPTH"]/*' />
    D3D10_CLEAR_DEPTH = 0x1,

    /// <include file='D3D10_CLEAR_FLAG.xml' path='doc/member[@name="D3D10_CLEAR_FLAG.D3D10_CLEAR_STENCIL"]/*' />
    D3D10_CLEAR_STENCIL = 0x2,
}
