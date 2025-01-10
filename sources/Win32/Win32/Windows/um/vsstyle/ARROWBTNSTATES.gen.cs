// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ARROWBTNSTATES
{
    ABS_UPNORMAL = 1,
    ABS_UPHOT = 2,
    ABS_UPPRESSED = 3,
    ABS_UPDISABLED = 4,
    ABS_DOWNNORMAL = 5,
    ABS_DOWNHOT = 6,
    ABS_DOWNPRESSED = 7,
    ABS_DOWNDISABLED = 8,
    ABS_LEFTNORMAL = 9,
    ABS_LEFTHOT = 10,
    ABS_LEFTPRESSED = 11,
    ABS_LEFTDISABLED = 12,
    ABS_RIGHTNORMAL = 13,
    ABS_RIGHTHOT = 14,
    ABS_RIGHTPRESSED = 15,
    ABS_RIGHTDISABLED = 16,
    ABS_UPHOVER = 17,
    ABS_DOWNHOVER = 18,
    ABS_LEFTHOVER = 19,
    ABS_RIGHTHOVER = 20,
}
