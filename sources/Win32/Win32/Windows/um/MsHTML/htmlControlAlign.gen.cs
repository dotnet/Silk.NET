// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum htmlControlAlign
{
    htmlControlAlignNotSet = 0,
    htmlControlAlignLeft = 1,
    htmlControlAlignCenter = 2,
    htmlControlAlignRight = 3,
    htmlControlAlignTextTop = 4,
    htmlControlAlignAbsMiddle = 5,
    htmlControlAlignBaseline = 6,
    htmlControlAlignAbsBottom = 7,
    htmlControlAlignBottom = 8,
    htmlControlAlignMiddle = 9,
    htmlControlAlignTop = 10,
    htmlControlAlign_Max = 2147483647,
}
