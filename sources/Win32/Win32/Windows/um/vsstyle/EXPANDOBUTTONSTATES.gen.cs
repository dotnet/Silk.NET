// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum EXPANDOBUTTONSTATES
{
    TDLGEBS_NORMAL = 1,
    TDLGEBS_HOVER = 2,
    TDLGEBS_PRESSED = 3,
    TDLGEBS_EXPANDEDNORMAL = 4,
    TDLGEBS_EXPANDEDHOVER = 5,
    TDLGEBS_EXPANDEDPRESSED = 6,
    TDLGEBS_NORMALDISABLED = 7,
    TDLGEBS_EXPANDEDDISABLED = 8,
}
