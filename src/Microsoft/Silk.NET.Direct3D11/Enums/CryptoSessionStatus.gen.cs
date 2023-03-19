// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS")]
    public enum CryptoSessionStatus : int
    {
        [Obsolete("Deprecated in favour of \"OK\"")]
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_OK")]
        CryptoSessionStatusOK = 0x0,
        [Obsolete("Deprecated in favour of \"KeyLost\"")]
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_LOST")]
        CryptoSessionStatusKeyLost = 0x1,
        [Obsolete("Deprecated in favour of \"KeyAndContentLost\"")]
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST")]
        CryptoSessionStatusKeyAndContentLost = 0x2,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_OK")]
        OK = 0x0,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_LOST")]
        KeyLost = 0x1,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_STATUS_KEY_AND_CONTENT_LOST")]
        KeyAndContentLost = 0x2,
    }
}
