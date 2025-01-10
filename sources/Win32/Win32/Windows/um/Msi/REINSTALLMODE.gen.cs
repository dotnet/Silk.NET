// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum REINSTALLMODE
{
    REINSTALLMODE_REPAIR = 0x00000001,
    REINSTALLMODE_FILEMISSING = 0x00000002,
    REINSTALLMODE_FILEOLDERVERSION = 0x00000004,
    REINSTALLMODE_FILEEQUALVERSION = 0x00000008,
    REINSTALLMODE_FILEEXACT = 0x00000010,
    REINSTALLMODE_FILEVERIFY = 0x00000020,
    REINSTALLMODE_FILEREPLACE = 0x00000040,
    REINSTALLMODE_MACHINEDATA = 0x00000080,
    REINSTALLMODE_USERDATA = 0x00000100,
    REINSTALLMODE_SHORTCUT = 0x00000200,
    REINSTALLMODE_PACKAGE = 0x00000400,
}
