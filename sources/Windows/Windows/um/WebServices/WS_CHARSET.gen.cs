// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_CHARSET.xml' path='doc/member[@name="WS_CHARSET"]/*'/>
public enum WS_CHARSET
{
    /// <include file='WS_CHARSET.xml' path='doc/member[@name="WS_CHARSET.WS_CHARSET_AUTO"]/*'/>
    WS_CHARSET_AUTO = 0,
    /// <include file='WS_CHARSET.xml' path='doc/member[@name="WS_CHARSET.WS_CHARSET_UTF8"]/*'/>
    WS_CHARSET_UTF8 = 1,
    /// <include file='WS_CHARSET.xml' path='doc/member[@name="WS_CHARSET.WS_CHARSET_UTF16LE"]/*'/>
    WS_CHARSET_UTF16LE = 2,
    /// <include file='WS_CHARSET.xml' path='doc/member[@name="WS_CHARSET.WS_CHARSET_UTF16BE"]/*'/>
    WS_CHARSET_UTF16BE = 3,
}