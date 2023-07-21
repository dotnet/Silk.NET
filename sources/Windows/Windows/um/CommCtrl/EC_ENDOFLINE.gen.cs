// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='EC_ENDOFLINE.xml' path='doc/member[@name="EC_ENDOFLINE"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public enum EC_ENDOFLINE
{
    /// <include file='EC_ENDOFLINE.xml' path='doc/member[@name="EC_ENDOFLINE.EC_ENDOFLINE_DETECTFROMCONTENT"]/*' />
    EC_ENDOFLINE_DETECTFROMCONTENT = 0,

    /// <include file='EC_ENDOFLINE.xml' path='doc/member[@name="EC_ENDOFLINE.EC_ENDOFLINE_CRLF"]/*' />
    EC_ENDOFLINE_CRLF = 1,

    /// <include file='EC_ENDOFLINE.xml' path='doc/member[@name="EC_ENDOFLINE.EC_ENDOFLINE_CR"]/*' />
    EC_ENDOFLINE_CR = 2,

    /// <include file='EC_ENDOFLINE.xml' path='doc/member[@name="EC_ENDOFLINE.EC_ENDOFLINE_LF"]/*' />
    EC_ENDOFLINE_LF = 3,
}
