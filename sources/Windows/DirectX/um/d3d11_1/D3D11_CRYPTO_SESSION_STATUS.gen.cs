// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_CRYPTO_SESSION_STATUS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_STATUS"]/*'/>
public enum D3D11_CRYPTO_SESSION_STATUS
{
    /// <include file='D3D11_CRYPTO_SESSION_STATUS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_STATUS.D3D11_CRYPTO_SESSION_STATUS_OK"]/*'/>
    D3D11_CRYPTO_SESSION_STATUS_OK = 0,
    /// <include file='D3D11_CRYPTO_SESSION_STATUS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_STATUS.D3D11_CRYPTO_SESSION_STATUS_KEY_LOST"]/*'/>
    D3D11_CRYPTO_SESSION_STATUS_KEY_LOST = 1,
    /// <include file='D3D11_CRYPTO_SESSION_STATUS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_STATUS.D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST"]/*'/>
    D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST = 2,
}