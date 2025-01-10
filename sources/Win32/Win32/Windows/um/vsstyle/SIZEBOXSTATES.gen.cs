// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SIZEBOXSTATES
{
    SZB_RIGHTALIGN = 1,
    SZB_LEFTALIGN = 2,
    SZB_TOPRIGHTALIGN = 3,
    SZB_TOPLEFTALIGN = 4,
    SZB_HALFBOTTOMRIGHTALIGN = 5,
    SZB_HALFBOTTOMLEFTALIGN = 6,
    SZB_HALFTOPRIGHTALIGN = 7,
    SZB_HALFTOPLEFTALIGN = 8,
}
