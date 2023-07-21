// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BEHAVIOR_LAYOUT_INFO.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_INFO"]/*' />
public enum BEHAVIOR_LAYOUT_INFO
{
    /// <include file='BEHAVIOR_LAYOUT_INFO.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_INFO.BEHAVIORLAYOUTINFO_FULLDELEGATION"]/*' />
    BEHAVIORLAYOUTINFO_FULLDELEGATION = 0x1,

    /// <include file='BEHAVIOR_LAYOUT_INFO.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_INFO.BEHAVIORLAYOUTINFO_MODIFYNATURAL"]/*' />
    BEHAVIORLAYOUTINFO_MODIFYNATURAL = 0x2,

    /// <include file='BEHAVIOR_LAYOUT_INFO.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_INFO.BEHAVIORLAYOUTINFO_MAPSIZE"]/*' />
    BEHAVIORLAYOUTINFO_MAPSIZE = 0x4,

    /// <include file='BEHAVIOR_LAYOUT_INFO.xml' path='doc/member[@name="BEHAVIOR_LAYOUT_INFO.BEHAVIOR_LAYOUT_INFO_Max"]/*' />
    BEHAVIOR_LAYOUT_INFO_Max = 2147483647,
}
