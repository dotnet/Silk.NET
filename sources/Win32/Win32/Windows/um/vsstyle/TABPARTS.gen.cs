// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TABPARTS
{
    TABP_TABITEM = 1,
    TABP_TABITEMLEFTEDGE = 2,
    TABP_TABITEMRIGHTEDGE = 3,
    TABP_TABITEMBOTHEDGE = 4,
    TABP_TOPTABITEM = 5,
    TABP_TOPTABITEMLEFTEDGE = 6,
    TABP_TOPTABITEMRIGHTEDGE = 7,
    TABP_TOPTABITEMBOTHEDGE = 8,
    TABP_PANE = 9,
    TABP_BODY = 10,
    TABP_AEROWIZARDBODY = 11,
}
