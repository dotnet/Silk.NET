// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CryptographicPrivateKeyBlobType
{
    CryptographicPrivateKeyBlobType_Pkcs8RawPrivateKeyInfo = 0,
    CryptographicPrivateKeyBlobType_Pkcs1RsaPrivateKey = 1,
    CryptographicPrivateKeyBlobType_BCryptPrivateKey = 2,
    CryptographicPrivateKeyBlobType_Capi1PrivateKey = 3,
    CryptographicPrivateKeyBlobType_BCryptEccFullPrivateKey = 4,
}
