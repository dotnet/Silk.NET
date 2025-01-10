// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WINHTTP_SECURE_DNS_SETTING
{
    WinHttpSecureDnsSettingDefault = 0,
    WinHttpSecureDnsSettingForcePlaintext = 1,
    WinHttpSecureDnsSettingRequireEncryption = 2,
    WinHttpSecureDnsSettingTryEncryptionWithFallback = 3,
    WinHttpSecureDnsSettingMax = 4,
}
