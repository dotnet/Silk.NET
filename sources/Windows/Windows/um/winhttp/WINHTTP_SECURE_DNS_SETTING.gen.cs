// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING"]/*'/>
public enum WINHTTP_SECURE_DNS_SETTING
{
    /// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING.WinHttpSecureDnsSettingDefault"]/*'/>
    WinHttpSecureDnsSettingDefault = 0,
    /// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING.WinHttpSecureDnsSettingForcePlaintext"]/*'/>
    WinHttpSecureDnsSettingForcePlaintext = 1,
    /// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING.WinHttpSecureDnsSettingRequireEncryption"]/*'/>
    WinHttpSecureDnsSettingRequireEncryption = 2,
    /// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING.WinHttpSecureDnsSettingTryEncryptionWithFallback"]/*'/>
    WinHttpSecureDnsSettingTryEncryptionWithFallback = 3,
    /// <include file='WINHTTP_SECURE_DNS_SETTING.xml' path='doc/member[@name="WINHTTP_SECURE_DNS_SETTING.WinHttpSecureDnsSettingMax"]/*'/>
    WinHttpSecureDnsSettingMax = 4,
}