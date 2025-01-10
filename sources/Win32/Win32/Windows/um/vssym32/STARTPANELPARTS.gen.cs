// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum STARTPANELPARTS
{
    SPP_USERPANE = 1,
    SPP_MOREPROGRAMS = 2,
    SPP_MOREPROGRAMSARROW = 3,
    SPP_PROGLIST = 4,
    SPP_PROGLISTSEPARATOR = 5,
    SPP_PLACESLIST = 6,
    SPP_PLACESLISTSEPARATOR = 7,
    SPP_LOGOFF = 8,
    SPP_LOGOFFBUTTONS = 9,
    SPP_USERPICTURE = 10,
    SPP_PREVIEW = 11,
    SPP_MOREPROGRAMSTAB = 12,
    SPP_NSCHOST = 13,
    SPP_SOFTWAREEXPLORER = 14,
    SPP_OPENBOX = 15,
    SPP_SEARCHVIEW = 16,
    SPP_MOREPROGRAMSARROWBACK = 17,
    SPP_TOPMATCH = 18,
    SPP_LOGOFFSPLITBUTTONDROPDOWN = 19,
}
