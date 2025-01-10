// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_MOVE_TO
{
    WS_MOVE_TO_ROOT_ELEMENT = 0,
    WS_MOVE_TO_NEXT_ELEMENT = 1,
    WS_MOVE_TO_PREVIOUS_ELEMENT = 2,
    WS_MOVE_TO_CHILD_ELEMENT = 3,
    WS_MOVE_TO_END_ELEMENT = 4,
    WS_MOVE_TO_PARENT_ELEMENT = 5,
    WS_MOVE_TO_NEXT_NODE = 6,
    WS_MOVE_TO_PREVIOUS_NODE = 7,
    WS_MOVE_TO_FIRST_NODE = 8,
    WS_MOVE_TO_BOF = 9,
    WS_MOVE_TO_EOF = 10,
    WS_MOVE_TO_CHILD_NODE = 11,
}
