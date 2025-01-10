// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleBreak
{
    styleBreakNotSet = 0,
    styleBreakAuto = 1,
    styleBreakAlways = 2,
    styleBreakAvoid = 3,
    styleBreakLeft = 4,
    styleBreakRight = 5,
    styleBreakPage = 6,
    styleBreakColumn = 7,
    styleBreakAvoidPage = 8,
    styleBreakAvoidColumn = 9,
    styleBreak_Max = 2147483647,
}
