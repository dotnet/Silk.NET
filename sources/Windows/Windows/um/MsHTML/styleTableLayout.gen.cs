// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleTableLayout.xml' path='doc/member[@name="styleTableLayout"]/*' />
public enum styleTableLayout
{
    /// <include file='styleTableLayout.xml' path='doc/member[@name="styleTableLayout.styleTableLayoutNotSet"]/*' />
    styleTableLayoutNotSet = 0,

    /// <include file='styleTableLayout.xml' path='doc/member[@name="styleTableLayout.styleTableLayoutAuto"]/*' />
    styleTableLayoutAuto = 1,

    /// <include file='styleTableLayout.xml' path='doc/member[@name="styleTableLayout.styleTableLayoutFixed"]/*' />
    styleTableLayoutFixed = 2,

    /// <include file='styleTableLayout.xml' path='doc/member[@name="styleTableLayout.styleTableLayout_Max"]/*' />
    styleTableLayout_Max = 2147483647,
}
