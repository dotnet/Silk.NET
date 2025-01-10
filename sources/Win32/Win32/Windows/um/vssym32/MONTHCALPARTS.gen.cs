// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MONTHCALPARTS
{
    MC_BACKGROUND = 1,
    MC_BORDERS = 2,
    MC_GRIDBACKGROUND = 3,
    MC_COLHEADERSPLITTER = 4,
    MC_GRIDCELLBACKGROUND = 5,
    MC_GRIDCELL = 6,
    MC_GRIDCELLUPPER = 7,
    MC_TRAILINGGRIDCELL = 8,
    MC_TRAILINGGRIDCELLUPPER = 9,
    MC_NAVNEXT = 10,
    MC_NAVPREV = 11,
}
