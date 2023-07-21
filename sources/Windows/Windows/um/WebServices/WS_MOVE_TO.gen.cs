// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO"]/*' />
public enum WS_MOVE_TO
{
    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_ROOT_ELEMENT"]/*' />
    WS_MOVE_TO_ROOT_ELEMENT = 0,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_NEXT_ELEMENT"]/*' />
    WS_MOVE_TO_NEXT_ELEMENT = 1,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_PREVIOUS_ELEMENT"]/*' />
    WS_MOVE_TO_PREVIOUS_ELEMENT = 2,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_CHILD_ELEMENT"]/*' />
    WS_MOVE_TO_CHILD_ELEMENT = 3,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_END_ELEMENT"]/*' />
    WS_MOVE_TO_END_ELEMENT = 4,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_PARENT_ELEMENT"]/*' />
    WS_MOVE_TO_PARENT_ELEMENT = 5,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_NEXT_NODE"]/*' />
    WS_MOVE_TO_NEXT_NODE = 6,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_PREVIOUS_NODE"]/*' />
    WS_MOVE_TO_PREVIOUS_NODE = 7,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_FIRST_NODE"]/*' />
    WS_MOVE_TO_FIRST_NODE = 8,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_BOF"]/*' />
    WS_MOVE_TO_BOF = 9,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_EOF"]/*' />
    WS_MOVE_TO_EOF = 10,

    /// <include file='WS_MOVE_TO.xml' path='doc/member[@name="WS_MOVE_TO.WS_MOVE_TO_CHILD_NODE"]/*' />
    WS_MOVE_TO_CHILD_NODE = 11,
}
