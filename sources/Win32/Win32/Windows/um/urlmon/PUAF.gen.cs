// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PUAF
{
    PUAF_DEFAULT = 0,
    PUAF_NOUI = 0x1,
    PUAF_ISFILE = 0x2,
    PUAF_WARN_IF_DENIED = 0x4,
    PUAF_FORCEUI_FOREGROUND = 0x8,
    PUAF_CHECK_TIFS = 0x10,
    PUAF_DONTCHECKBOXINDIALOG = 0x20,
    PUAF_TRUSTED = 0x40,
    PUAF_ACCEPT_WILDCARD_SCHEME = 0x80,
    PUAF_ENFORCERESTRICTED = 0x100,
    PUAF_NOSAVEDFILECHECK = 0x200,
    PUAF_REQUIRESAVEDFILECHECK = 0x400,
    PUAF_DONT_USE_CACHE = 0x1000,
    PUAF_RESERVED1 = 0x2000,
    PUAF_RESERVED2 = 0x4000,
    PUAF_LMZ_UNLOCKED = 0x10000,
    PUAF_LMZ_LOCKED = 0x20000,
    PUAF_DEFAULTZONEPOL = 0x40000,
    PUAF_NPL_USE_LOCKED_IF_RESTRICTED = 0x80000,
    PUAF_NOUIIFLOCKED = 0x100000,
    PUAF_DRAGPROTOCOLCHECK = 0x200000,
}
