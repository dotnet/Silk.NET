// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT"]/*' />
public enum DISPLAY_MOVEUNIT
{
    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_PreviousLine"]/*' />
    DISPLAY_MOVEUNIT_PreviousLine = 1,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_NextLine"]/*' />
    DISPLAY_MOVEUNIT_NextLine = 2,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_CurrentLineStart"]/*' />
    DISPLAY_MOVEUNIT_CurrentLineStart = 3,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_CurrentLineEnd"]/*' />
    DISPLAY_MOVEUNIT_CurrentLineEnd = 4,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_TopOfWindow"]/*' />
    DISPLAY_MOVEUNIT_TopOfWindow = 5,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_BottomOfWindow"]/*' />
    DISPLAY_MOVEUNIT_BottomOfWindow = 6,

    /// <include file='DISPLAY_MOVEUNIT.xml' path='doc/member[@name="DISPLAY_MOVEUNIT.DISPLAY_MOVEUNIT_Max"]/*' />
    DISPLAY_MOVEUNIT_Max = 2147483647,
}
