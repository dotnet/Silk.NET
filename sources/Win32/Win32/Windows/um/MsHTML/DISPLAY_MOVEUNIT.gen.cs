// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPLAY_MOVEUNIT
{
    DISPLAY_MOVEUNIT_PreviousLine = 1,
    DISPLAY_MOVEUNIT_NextLine = 2,
    DISPLAY_MOVEUNIT_CurrentLineStart = 3,
    DISPLAY_MOVEUNIT_CurrentLineEnd = 4,
    DISPLAY_MOVEUNIT_TopOfWindow = 5,
    DISPLAY_MOVEUNIT_BottomOfWindow = 6,
    DISPLAY_MOVEUNIT_Max = 2147483647,
}
