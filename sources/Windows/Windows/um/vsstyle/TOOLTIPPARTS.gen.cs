// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS"]/*' />
public enum TOOLTIPPARTS
{
    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_STANDARD"]/*' />
    TTP_STANDARD = 1,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_STANDARDTITLE"]/*' />
    TTP_STANDARDTITLE = 2,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_BALLOON"]/*' />
    TTP_BALLOON = 3,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_BALLOONTITLE"]/*' />
    TTP_BALLOONTITLE = 4,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_CLOSE"]/*' />
    TTP_CLOSE = 5,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_BALLOONSTEM"]/*' />
    TTP_BALLOONSTEM = 6,

    /// <include file='TOOLTIPPARTS.xml' path='doc/member[@name="TOOLTIPPARTS.TTP_WRENCH"]/*' />
    TTP_WRENCH = 7,
}
