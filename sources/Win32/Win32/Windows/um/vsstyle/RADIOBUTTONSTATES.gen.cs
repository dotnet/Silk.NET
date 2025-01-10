// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum RADIOBUTTONSTATES
{
    RBS_UNCHECKEDNORMAL = 1,
    RBS_UNCHECKEDHOT = 2,
    RBS_UNCHECKEDPRESSED = 3,
    RBS_UNCHECKEDDISABLED = 4,
    RBS_CHECKEDNORMAL = 5,
    RBS_CHECKEDHOT = 6,
    RBS_CHECKEDPRESSED = 7,
    RBS_CHECKEDDISABLED = 8,
}
