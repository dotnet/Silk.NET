// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SIGDN
{
    SIGDN_NORMALDISPLAY = 0,
    SIGDN_PARENTRELATIVEPARSING = unchecked((int)(0x80018001)),
    SIGDN_DESKTOPABSOLUTEPARSING = unchecked((int)(0x80028000)),
    SIGDN_PARENTRELATIVEEDITING = unchecked((int)(0x80031001)),
    SIGDN_DESKTOPABSOLUTEEDITING = unchecked((int)(0x8004c000)),
    SIGDN_FILESYSPATH = unchecked((int)(0x80058000)),
    SIGDN_URL = unchecked((int)(0x80068000)),
    SIGDN_PARENTRELATIVEFORADDRESSBAR = unchecked((int)(0x8007c001)),
    SIGDN_PARENTRELATIVE = unchecked((int)(0x80080001)),
    SIGDN_PARENTRELATIVEFORUI = unchecked((int)(0x80094001)),
}
