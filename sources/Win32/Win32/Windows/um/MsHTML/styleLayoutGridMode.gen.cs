// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleLayoutGridMode
{
    styleLayoutGridModeNotSet = 0,
    styleLayoutGridModeChar = 1,
    styleLayoutGridModeLine = 2,
    styleLayoutGridModeBoth = 3,
    styleLayoutGridModeNone = 4,
    styleLayoutGridMode_Max = 2147483647,
}
