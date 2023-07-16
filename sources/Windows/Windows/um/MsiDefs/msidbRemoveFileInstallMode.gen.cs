// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbRemoveFileInstallMode.xml' path='doc/member[@name="msidbRemoveFileInstallMode"]/*'/>
public enum msidbRemoveFileInstallMode
{
    /// <include file='msidbRemoveFileInstallMode.xml' path='doc/member[@name="msidbRemoveFileInstallMode.msidbRemoveFileInstallModeOnInstall"]/*'/>
    msidbRemoveFileInstallModeOnInstall = 0x00000001,
    /// <include file='msidbRemoveFileInstallMode.xml' path='doc/member[@name="msidbRemoveFileInstallMode.msidbRemoveFileInstallModeOnRemove"]/*'/>
    msidbRemoveFileInstallModeOnRemove = 0x00000002,
    /// <include file='msidbRemoveFileInstallMode.xml' path='doc/member[@name="msidbRemoveFileInstallMode.msidbRemoveFileInstallModeOnBoth"]/*'/>
    msidbRemoveFileInstallModeOnBoth = 0x00000003,
}