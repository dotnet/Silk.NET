// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum OFFSETTYPE
{
    OT_TOPLEFT = 0,
    OT_TOPRIGHT = 1,
    OT_TOPMIDDLE = 2,
    OT_BOTTOMLEFT = 3,
    OT_BOTTOMRIGHT = 4,
    OT_BOTTOMMIDDLE = 5,
    OT_MIDDLELEFT = 6,
    OT_MIDDLERIGHT = 7,
    OT_LEFTOFCAPTION = 8,
    OT_RIGHTOFCAPTION = 9,
    OT_LEFTOFLASTBUTTON = 10,
    OT_RIGHTOFLASTBUTTON = 11,
    OT_ABOVELASTBUTTON = 12,
    OT_BELOWLASTBUTTON = 13,
}
