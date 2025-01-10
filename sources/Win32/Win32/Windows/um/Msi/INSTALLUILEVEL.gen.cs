// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum INSTALLUILEVEL
{
    INSTALLUILEVEL_NOCHANGE = 0,
    INSTALLUILEVEL_DEFAULT = 1,
    INSTALLUILEVEL_NONE = 2,
    INSTALLUILEVEL_BASIC = 3,
    INSTALLUILEVEL_REDUCED = 4,
    INSTALLUILEVEL_FULL = 5,
    INSTALLUILEVEL_ENDDIALOG = 0x80,
    INSTALLUILEVEL_PROGRESSONLY = 0x40,
    INSTALLUILEVEL_HIDECANCEL = 0x20,
    INSTALLUILEVEL_SOURCERESONLY = 0x100,
    INSTALLUILEVEL_UACONLY = 0x200,
}
