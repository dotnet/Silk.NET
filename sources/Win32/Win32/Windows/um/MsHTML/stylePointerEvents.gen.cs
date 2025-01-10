// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum stylePointerEvents
{
    stylePointerEventsNotSet = 0,
    stylePointerEventsVisiblePainted = 1,
    stylePointerEventsVisibleFill = 2,
    stylePointerEventsVisibleStroke = 3,
    stylePointerEventsVisible = 4,
    stylePointerEventsPainted = 5,
    stylePointerEventsFill = 6,
    stylePointerEventsStroke = 7,
    stylePointerEventsAll = 8,
    stylePointerEventsNone = 9,
    stylePointerEventsInitial = 10,
    stylePointerEventsAuto = 11,
    stylePointerEvents_Max = 2147483647,
}
