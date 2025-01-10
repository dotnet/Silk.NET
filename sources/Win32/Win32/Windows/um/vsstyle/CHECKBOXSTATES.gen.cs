// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CHECKBOXSTATES
{
    CBS_UNCHECKEDNORMAL = 1,
    CBS_UNCHECKEDHOT = 2,
    CBS_UNCHECKEDPRESSED = 3,
    CBS_UNCHECKEDDISABLED = 4,
    CBS_CHECKEDNORMAL = 5,
    CBS_CHECKEDHOT = 6,
    CBS_CHECKEDPRESSED = 7,
    CBS_CHECKEDDISABLED = 8,
    CBS_MIXEDNORMAL = 9,
    CBS_MIXEDHOT = 10,
    CBS_MIXEDPRESSED = 11,
    CBS_MIXEDDISABLED = 12,
    CBS_IMPLICITNORMAL = 13,
    CBS_IMPLICITHOT = 14,
    CBS_IMPLICITPRESSED = 15,
    CBS_IMPLICITDISABLED = 16,
    CBS_EXCLUDEDNORMAL = 17,
    CBS_EXCLUDEDHOT = 18,
    CBS_EXCLUDEDPRESSED = 19,
    CBS_EXCLUDEDDISABLED = 20,
}
