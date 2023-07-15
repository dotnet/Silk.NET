// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NWMF.xml' path='doc/member[@name="NWMF"]/*'/>
public enum NWMF
{
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_UNLOADING"]/*'/>
    NWMF_UNLOADING = 0x1,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_USERINITED"]/*'/>
    NWMF_USERINITED = 0x2,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_FIRST"]/*'/>
    NWMF_FIRST = 0x4,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_OVERRIDEKEY"]/*'/>
    NWMF_OVERRIDEKEY = 0x8,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_SHOWHELP"]/*'/>
    NWMF_SHOWHELP = 0x10,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_HTMLDIALOG"]/*'/>
    NWMF_HTMLDIALOG = 0x20,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_FROMDIALOGCHILD"]/*'/>
    NWMF_FROMDIALOGCHILD = 0x40,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_USERREQUESTED"]/*'/>
    NWMF_USERREQUESTED = 0x80,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_USERALLOWED"]/*'/>
    NWMF_USERALLOWED = 0x100,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_FORCEWINDOW"]/*'/>
    NWMF_FORCEWINDOW = 0x10000,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_FORCETAB"]/*'/>
    NWMF_FORCETAB = 0x20000,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_SUGGESTWINDOW"]/*'/>
    NWMF_SUGGESTWINDOW = 0x40000,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_SUGGESTTAB"]/*'/>
    NWMF_SUGGESTTAB = 0x80000,
    /// <include file='NWMF.xml' path='doc/member[@name="NWMF.NWMF_INACTIVETAB"]/*'/>
    NWMF_INACTIVETAB = 0x100000,
}