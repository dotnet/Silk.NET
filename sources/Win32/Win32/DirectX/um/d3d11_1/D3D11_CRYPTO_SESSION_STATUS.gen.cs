// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_CRYPTO_SESSION_STATUS
{
    D3D11_CRYPTO_SESSION_STATUS_OK = 0,
    D3D11_CRYPTO_SESSION_STATUS_KEY_LOST = 1,
    D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST = 2,
}
