// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SCROLLBARPARTS
{
    SBP_ARROWBTN = 1,
    SBP_THUMBBTNHORZ = 2,
    SBP_THUMBBTNVERT = 3,
    SBP_LOWERTRACKHORZ = 4,
    SBP_UPPERTRACKHORZ = 5,
    SBP_LOWERTRACKVERT = 6,
    SBP_UPPERTRACKVERT = 7,
    SBP_GRIPPERHORZ = 8,
    SBP_GRIPPERVERT = 9,
    SBP_SIZEBOX = 10,
    SBP_SIZEBOXBKGND = 11,
}
