// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum ELEMENT_CORNER
{
    ELEMENT_CORNER_NONE = 0,
    ELEMENT_CORNER_TOP = 1,
    ELEMENT_CORNER_LEFT = 2,
    ELEMENT_CORNER_BOTTOM = 3,
    ELEMENT_CORNER_RIGHT = 4,
    ELEMENT_CORNER_TOPLEFT = 5,
    ELEMENT_CORNER_TOPRIGHT = 6,
    ELEMENT_CORNER_BOTTOMLEFT = 7,
    ELEMENT_CORNER_BOTTOMRIGHT = 8,
    ELEMENT_CORNER_Max = 2147483647,
}
