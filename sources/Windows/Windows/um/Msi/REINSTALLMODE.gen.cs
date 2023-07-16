// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE"]/*'/>
public enum REINSTALLMODE
{
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_REPAIR"]/*'/>
    REINSTALLMODE_REPAIR = 0x00000001,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEMISSING"]/*'/>
    REINSTALLMODE_FILEMISSING = 0x00000002,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEOLDERVERSION"]/*'/>
    REINSTALLMODE_FILEOLDERVERSION = 0x00000004,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEEQUALVERSION"]/*'/>
    REINSTALLMODE_FILEEQUALVERSION = 0x00000008,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEEXACT"]/*'/>
    REINSTALLMODE_FILEEXACT = 0x00000010,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEVERIFY"]/*'/>
    REINSTALLMODE_FILEVERIFY = 0x00000020,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_FILEREPLACE"]/*'/>
    REINSTALLMODE_FILEREPLACE = 0x00000040,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_MACHINEDATA"]/*'/>
    REINSTALLMODE_MACHINEDATA = 0x00000080,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_USERDATA"]/*'/>
    REINSTALLMODE_USERDATA = 0x00000100,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_SHORTCUT"]/*'/>
    REINSTALLMODE_SHORTCUT = 0x00000200,
    /// <include file='REINSTALLMODE.xml' path='doc/member[@name="REINSTALLMODE.REINSTALLMODE_PACKAGE"]/*'/>
    REINSTALLMODE_PACKAGE = 0x00000400,
}