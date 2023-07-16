// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D11_COPY_FLAGS.xml' path='doc/member[@name="D3D11_COPY_FLAGS"]/*'/>
[Flags]
public enum D3D11_COPY_FLAGS
{
    /// <include file='D3D11_COPY_FLAGS.xml' path='doc/member[@name="D3D11_COPY_FLAGS.D3D11_COPY_NO_OVERWRITE"]/*'/>
    D3D11_COPY_NO_OVERWRITE = 0x1,
    /// <include file='D3D11_COPY_FLAGS.xml' path='doc/member[@name="D3D11_COPY_FLAGS.D3D11_COPY_DISCARD"]/*'/>
    D3D11_COPY_DISCARD = 0x2,
}