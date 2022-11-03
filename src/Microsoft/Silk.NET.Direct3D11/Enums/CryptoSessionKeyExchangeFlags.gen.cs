// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS")]
    public enum CryptoSessionKeyExchangeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAG_NONE")]
        CryptoSessionKeyExchangeFlagNone = 0x0,
        [NativeName("Name", "D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAG_NONE")]
        None = 0x0,
    }
}
