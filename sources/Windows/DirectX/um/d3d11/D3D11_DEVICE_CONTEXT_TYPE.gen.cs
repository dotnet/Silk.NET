// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_DEVICE_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_DEVICE_CONTEXT_TYPE"]/*' />
public enum D3D11_DEVICE_CONTEXT_TYPE
{
    /// <include file='D3D11_DEVICE_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_DEVICE_CONTEXT_TYPE.D3D11_DEVICE_CONTEXT_IMMEDIATE"]/*' />
    D3D11_DEVICE_CONTEXT_IMMEDIATE = 0,

    /// <include file='D3D11_DEVICE_CONTEXT_TYPE.xml' path='doc/member[@name="D3D11_DEVICE_CONTEXT_TYPE.D3D11_DEVICE_CONTEXT_DEFERRED"]/*' />
    D3D11_DEVICE_CONTEXT_DEFERRED = (D3D11_DEVICE_CONTEXT_IMMEDIATE + 1),
}
