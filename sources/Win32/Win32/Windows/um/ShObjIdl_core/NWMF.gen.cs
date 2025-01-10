// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum NWMF
{
    NWMF_UNLOADING = 0x1,
    NWMF_USERINITED = 0x2,
    NWMF_FIRST = 0x4,
    NWMF_OVERRIDEKEY = 0x8,
    NWMF_SHOWHELP = 0x10,
    NWMF_HTMLDIALOG = 0x20,
    NWMF_FROMDIALOGCHILD = 0x40,
    NWMF_USERREQUESTED = 0x80,
    NWMF_USERALLOWED = 0x100,
    NWMF_FORCEWINDOW = 0x10000,
    NWMF_FORCETAB = 0x20000,
    NWMF_SUGGESTWINDOW = 0x40000,
    NWMF_SUGGESTTAB = 0x80000,
    NWMF_INACTIVETAB = 0x100000,
}
