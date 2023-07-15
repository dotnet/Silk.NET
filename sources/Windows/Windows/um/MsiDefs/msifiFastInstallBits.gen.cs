// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msifiFastInstallBits.xml' path='doc/member[@name="msifiFastInstallBits"]/*'/>
public enum msifiFastInstallBits
{
    /// <include file='msifiFastInstallBits.xml' path='doc/member[@name="msifiFastInstallBits.msifiFastInstallNoSR"]/*'/>
    msifiFastInstallNoSR = 0x00000001,
    /// <include file='msifiFastInstallBits.xml' path='doc/member[@name="msifiFastInstallBits.msifiFastInstallQuickCosting"]/*'/>
    msifiFastInstallQuickCosting = 0x00000002,
    /// <include file='msifiFastInstallBits.xml' path='doc/member[@name="msifiFastInstallBits.msifiFastInstallLessPrgMsg"]/*'/>
    msifiFastInstallLessPrgMsg = 0x00000004,
}