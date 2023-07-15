// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbServiceConfigEvent.xml' path='doc/member[@name="msidbServiceConfigEvent"]/*'/>
public enum msidbServiceConfigEvent
{
    /// <include file='msidbServiceConfigEvent.xml' path='doc/member[@name="msidbServiceConfigEvent.msidbServiceConfigEventInstall"]/*'/>
    msidbServiceConfigEventInstall = 0x00000001,
    /// <include file='msidbServiceConfigEvent.xml' path='doc/member[@name="msidbServiceConfigEvent.msidbServiceConfigEventUninstall"]/*'/>
    msidbServiceConfigEventUninstall = 0x00000002,
    /// <include file='msidbServiceConfigEvent.xml' path='doc/member[@name="msidbServiceConfigEvent.msidbServiceConfigEventReinstall"]/*'/>
    msidbServiceConfigEventReinstall = 0x00000004,
}