// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS")]
    public enum CryptoSessionStatus : int
    {
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_OK")]
        CryptoSessionStatusOK = 0x0,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_LOST")]
        CryptoSessionStatusKeyLost = 0x1,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST")]
        CryptoSessionStatusKeyAndContentLost = 0x2,
    }
}
