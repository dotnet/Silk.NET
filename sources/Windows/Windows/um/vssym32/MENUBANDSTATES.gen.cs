// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES"]/*'/>
public enum MENUBANDSTATES
{
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_NORMAL"]/*'/>
    MDS_NORMAL = 1,
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_HOT"]/*'/>
    MDS_HOT = 2,
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_PRESSED"]/*'/>
    MDS_PRESSED = 3,
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_DISABLED"]/*'/>
    MDS_DISABLED = 4,
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_CHECKED"]/*'/>
    MDS_CHECKED = 5,
    /// <include file='MENUBANDSTATES.xml' path='doc/member[@name="MENUBANDSTATES.MDS_HOTCHECKED"]/*'/>
    MDS_HOTCHECKED = 6,
}