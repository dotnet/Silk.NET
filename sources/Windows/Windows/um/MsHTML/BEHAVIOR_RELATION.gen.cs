// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION"]/*' />
public enum BEHAVIOR_RELATION
{
    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_FIRSTRELATION"]/*' />
    BEHAVIOR_FIRSTRELATION = 0,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_SAMEELEMENT"]/*' />
    BEHAVIOR_SAMEELEMENT = 0,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_PARENT"]/*' />
    BEHAVIOR_PARENT = 1,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_CHILD"]/*' />
    BEHAVIOR_CHILD = 2,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_SIBLING"]/*' />
    BEHAVIOR_SIBLING = 3,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_LASTRELATION"]/*' />
    BEHAVIOR_LASTRELATION = 3,

    /// <include file='BEHAVIOR_RELATION.xml' path='doc/member[@name="BEHAVIOR_RELATION.BEHAVIOR_RELATION_Max"]/*' />
    BEHAVIOR_RELATION_Max = 2147483647,
}
