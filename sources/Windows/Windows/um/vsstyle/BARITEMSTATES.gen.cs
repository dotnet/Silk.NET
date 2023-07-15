// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES"]/*'/>
public enum BARITEMSTATES
{
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_NORMAL"]/*'/>
    MBI_NORMAL = 1,
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_HOT"]/*'/>
    MBI_HOT = 2,
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_PUSHED"]/*'/>
    MBI_PUSHED = 3,
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_DISABLED"]/*'/>
    MBI_DISABLED = 4,
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_DISABLEDHOT"]/*'/>
    MBI_DISABLEDHOT = 5,
    /// <include file='BARITEMSTATES.xml' path='doc/member[@name="BARITEMSTATES.MBI_DISABLEDPUSHED"]/*'/>
    MBI_DISABLEDPUSHED = 6,
}