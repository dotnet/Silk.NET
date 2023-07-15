// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS"]/*'/>
public enum SPADAPTATIONSETTINGS
{
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_Default"]/*'/>
    SPADS_Default = 0,
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_CurrentRecognizer"]/*'/>
    SPADS_CurrentRecognizer = 0x1,
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_RecoProfile"]/*'/>
    SPADS_RecoProfile = 0x2,
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_Immediate"]/*'/>
    SPADS_Immediate = 0x4,
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_Reset"]/*'/>
    SPADS_Reset = 0x8,
    /// <include file='SPADAPTATIONSETTINGS.xml' path='doc/member[@name="SPADAPTATIONSETTINGS.SPADS_HighVolumeDataSource"]/*'/>
    SPADS_HighVolumeDataSource = 0x10,
}