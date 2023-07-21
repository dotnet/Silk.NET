// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE"]/*' />
public enum OFFSETTYPE
{
    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_TOPLEFT"]/*' />
    OT_TOPLEFT = 0,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_TOPRIGHT"]/*' />
    OT_TOPRIGHT = 1,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_TOPMIDDLE"]/*' />
    OT_TOPMIDDLE = 2,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_BOTTOMLEFT"]/*' />
    OT_BOTTOMLEFT = 3,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_BOTTOMRIGHT"]/*' />
    OT_BOTTOMRIGHT = 4,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_BOTTOMMIDDLE"]/*' />
    OT_BOTTOMMIDDLE = 5,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_MIDDLELEFT"]/*' />
    OT_MIDDLELEFT = 6,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_MIDDLERIGHT"]/*' />
    OT_MIDDLERIGHT = 7,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_LEFTOFCAPTION"]/*' />
    OT_LEFTOFCAPTION = 8,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_RIGHTOFCAPTION"]/*' />
    OT_RIGHTOFCAPTION = 9,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_LEFTOFLASTBUTTON"]/*' />
    OT_LEFTOFLASTBUTTON = 10,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_RIGHTOFLASTBUTTON"]/*' />
    OT_RIGHTOFLASTBUTTON = 11,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_ABOVELASTBUTTON"]/*' />
    OT_ABOVELASTBUTTON = 12,

    /// <include file='OFFSETTYPE.xml' path='doc/member[@name="OFFSETTYPE.OT_BELOWLASTBUTTON"]/*' />
    OT_BELOWLASTBUTTON = 13,
}
