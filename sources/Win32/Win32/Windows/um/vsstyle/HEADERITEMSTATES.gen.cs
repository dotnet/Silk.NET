// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HEADERITEMSTATES
{
    HIS_NORMAL = 1,
    HIS_HOT = 2,
    HIS_PRESSED = 3,
    HIS_SORTEDNORMAL = 4,
    HIS_SORTEDHOT = 5,
    HIS_SORTEDPRESSED = 6,
    HIS_ICONNORMAL = 7,
    HIS_ICONHOT = 8,
    HIS_ICONPRESSED = 9,
    HIS_ICONSORTEDNORMAL = 10,
    HIS_ICONSORTEDHOT = 11,
    HIS_ICONSORTEDPRESSED = 12,
}
