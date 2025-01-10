// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CryptographicPublicKeyBlobType
{
    CryptographicPublicKeyBlobType_X509SubjectPublicKeyInfo = 0,
    CryptographicPublicKeyBlobType_Pkcs1RsaPublicKey = 1,
    CryptographicPublicKeyBlobType_BCryptPublicKey = 2,
    CryptographicPublicKeyBlobType_Capi1PublicKey = 3,
    CryptographicPublicKeyBlobType_BCryptEccFullPublicKey = 4,
}
