// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition"]/*' />
public enum styleTextUnderlinePosition
{
    /// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition.styleTextUnderlinePositionBelow"]/*' />
    styleTextUnderlinePositionBelow = 0,

    /// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition.styleTextUnderlinePositionAbove"]/*' />
    styleTextUnderlinePositionAbove = 1,

    /// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition.styleTextUnderlinePositionAuto"]/*' />
    styleTextUnderlinePositionAuto = 2,

    /// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition.styleTextUnderlinePositionNotSet"]/*' />
    styleTextUnderlinePositionNotSet = 3,

    /// <include file='styleTextUnderlinePosition.xml' path='doc/member[@name="styleTextUnderlinePosition.styleTextUnderlinePosition_Max"]/*' />
    styleTextUnderlinePosition_Max = 2147483647,
}
