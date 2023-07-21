// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlCompatMode.xml' path='doc/member[@name="htmlCompatMode"]/*' />
public enum htmlCompatMode
{
    /// <include file='htmlCompatMode.xml' path='doc/member[@name="htmlCompatMode.htmlCompatModeBackCompat"]/*' />
    htmlCompatModeBackCompat = 0,

    /// <include file='htmlCompatMode.xml' path='doc/member[@name="htmlCompatMode.htmlCompatModeCSS1Compat"]/*' />
    htmlCompatModeCSS1Compat = 1,

    /// <include file='htmlCompatMode.xml' path='doc/member[@name="htmlCompatMode.htmlCompatMode_Max"]/*' />
    htmlCompatMode_Max = 2147483647,
}
