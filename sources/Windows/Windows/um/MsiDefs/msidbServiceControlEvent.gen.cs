// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent"]/*'/>
public enum msidbServiceControlEvent
{
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventStart"]/*'/>
    msidbServiceControlEventStart = 0x00000001,
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventStop"]/*'/>
    msidbServiceControlEventStop = 0x00000002,
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventDelete"]/*'/>
    msidbServiceControlEventDelete = 0x00000008,
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventUninstallStart"]/*'/>
    msidbServiceControlEventUninstallStart = 0x00000010,
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventUninstallStop"]/*'/>
    msidbServiceControlEventUninstallStop = 0x00000020,
    /// <include file='msidbServiceControlEvent.xml' path='doc/member[@name="msidbServiceControlEvent.msidbServiceControlEventUninstallDelete"]/*'/>
    msidbServiceControlEventUninstallDelete = 0x00000080,
}