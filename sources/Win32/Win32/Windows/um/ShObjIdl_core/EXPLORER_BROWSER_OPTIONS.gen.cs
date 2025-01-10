// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum EXPLORER_BROWSER_OPTIONS
{
    EBO_NONE = 0,
    EBO_NAVIGATEONCE = 0x1,
    EBO_SHOWFRAMES = 0x2,
    EBO_ALWAYSNAVIGATE = 0x4,
    EBO_NOTRAVELLOG = 0x8,
    EBO_NOWRAPPERWINDOW = 0x10,
    EBO_HTMLSHAREPOINTVIEW = 0x20,
    EBO_NOBORDER = 0x40,
    EBO_NOPERSISTVIEWSTATE = 0x80,
}
