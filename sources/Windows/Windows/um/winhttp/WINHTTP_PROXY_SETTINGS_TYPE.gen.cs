// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_PROXY_SETTINGS_TYPE.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_TYPE"]/*'/>
public enum WINHTTP_PROXY_SETTINGS_TYPE
{
    /// <include file='WINHTTP_PROXY_SETTINGS_TYPE.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_TYPE.WinHttpProxySettingsTypeUnknown"]/*'/>
    WinHttpProxySettingsTypeUnknown,
    /// <include file='WINHTTP_PROXY_SETTINGS_TYPE.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_TYPE.WinHttpProxySettingsTypeWsl"]/*'/>
    WinHttpProxySettingsTypeWsl,
    /// <include file='WINHTTP_PROXY_SETTINGS_TYPE.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_TYPE.WinHttpProxySettingsTypeWsa"]/*'/>
    WinHttpProxySettingsTypeWsa,
}