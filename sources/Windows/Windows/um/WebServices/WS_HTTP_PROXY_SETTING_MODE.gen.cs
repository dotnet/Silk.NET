// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_HTTP_PROXY_SETTING_MODE.xml' path='doc/member[@name="WS_HTTP_PROXY_SETTING_MODE"]/*'/>
public enum WS_HTTP_PROXY_SETTING_MODE
{
    /// <include file='WS_HTTP_PROXY_SETTING_MODE.xml' path='doc/member[@name="WS_HTTP_PROXY_SETTING_MODE.WS_HTTP_PROXY_SETTING_MODE_AUTO"]/*'/>
    WS_HTTP_PROXY_SETTING_MODE_AUTO = 0x1,
    /// <include file='WS_HTTP_PROXY_SETTING_MODE.xml' path='doc/member[@name="WS_HTTP_PROXY_SETTING_MODE.WS_HTTP_PROXY_SETTING_MODE_NONE"]/*'/>
    WS_HTTP_PROXY_SETTING_MODE_NONE = 0x2,
    /// <include file='WS_HTTP_PROXY_SETTING_MODE.xml' path='doc/member[@name="WS_HTTP_PROXY_SETTING_MODE.WS_HTTP_PROXY_SETTING_MODE_CUSTOM"]/*'/>
    WS_HTTP_PROXY_SETTING_MODE_CUSTOM = 0x3,
}