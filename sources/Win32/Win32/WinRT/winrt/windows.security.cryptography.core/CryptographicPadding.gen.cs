// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CryptographicPadding
{
    CryptographicPadding_None = 0,
    CryptographicPadding_RsaOaep = 1,
    CryptographicPadding_RsaPkcs1V15 = 2,
    CryptographicPadding_RsaPss = 3,
}
