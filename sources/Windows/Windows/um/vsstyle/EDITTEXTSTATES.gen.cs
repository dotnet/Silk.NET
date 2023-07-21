// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES"]/*' />
public enum EDITTEXTSTATES
{
    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_NORMAL"]/*' />
    ETS_NORMAL = 1,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_HOT"]/*' />
    ETS_HOT = 2,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_SELECTED"]/*' />
    ETS_SELECTED = 3,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_DISABLED"]/*' />
    ETS_DISABLED = 4,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_FOCUSED"]/*' />
    ETS_FOCUSED = 5,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_READONLY"]/*' />
    ETS_READONLY = 6,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_ASSIST"]/*' />
    ETS_ASSIST = 7,

    /// <include file='EDITTEXTSTATES.xml' path='doc/member[@name="EDITTEXTSTATES.ETS_CUEBANNER"]/*' />
    ETS_CUEBANNER = 8,
}
