// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak"]/*' />
public enum stylePageBreak
{
    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakNotSet"]/*' />
    stylePageBreakNotSet = 0,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakAuto"]/*' />
    stylePageBreakAuto = 1,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakAlways"]/*' />
    stylePageBreakAlways = 2,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakLeft"]/*' />
    stylePageBreakLeft = 3,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakRight"]/*' />
    stylePageBreakRight = 4,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreakAvoid"]/*' />
    stylePageBreakAvoid = 5,

    /// <include file='stylePageBreak.xml' path='doc/member[@name="stylePageBreak.stylePageBreak_Max"]/*' />
    stylePageBreak_Max = 2147483647,
}
