// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE"]/*'/>
public enum NSTCSTYLE
{
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_HASEXPANDOS"]/*'/>
    NSTCS_HASEXPANDOS = 0x1,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_HASLINES"]/*'/>
    NSTCS_HASLINES = 0x2,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SINGLECLICKEXPAND"]/*'/>
    NSTCS_SINGLECLICKEXPAND = 0x4,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_FULLROWSELECT"]/*'/>
    NSTCS_FULLROWSELECT = 0x8,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SPRINGEXPAND"]/*'/>
    NSTCS_SPRINGEXPAND = 0x10,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_HORIZONTALSCROLL"]/*'/>
    NSTCS_HORIZONTALSCROLL = 0x20,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_ROOTHASEXPANDO"]/*'/>
    NSTCS_ROOTHASEXPANDO = 0x40,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SHOWSELECTIONALWAYS"]/*'/>
    NSTCS_SHOWSELECTIONALWAYS = 0x80,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_NOINFOTIP"]/*'/>
    NSTCS_NOINFOTIP = 0x200,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_EVENHEIGHT"]/*'/>
    NSTCS_EVENHEIGHT = 0x400,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_NOREPLACEOPEN"]/*'/>
    NSTCS_NOREPLACEOPEN = 0x800,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_DISABLEDRAGDROP"]/*'/>
    NSTCS_DISABLEDRAGDROP = 0x1000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_NOORDERSTREAM"]/*'/>
    NSTCS_NOORDERSTREAM = 0x2000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_RICHTOOLTIP"]/*'/>
    NSTCS_RICHTOOLTIP = 0x4000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_BORDER"]/*'/>
    NSTCS_BORDER = 0x8000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_NOEDITLABELS"]/*'/>
    NSTCS_NOEDITLABELS = 0x10000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_TABSTOP"]/*'/>
    NSTCS_TABSTOP = 0x20000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_FAVORITESMODE"]/*'/>
    NSTCS_FAVORITESMODE = 0x80000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_AUTOHSCROLL"]/*'/>
    NSTCS_AUTOHSCROLL = 0x100000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_FADEINOUTEXPANDOS"]/*'/>
    NSTCS_FADEINOUTEXPANDOS = 0x200000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_EMPTYTEXT"]/*'/>
    NSTCS_EMPTYTEXT = 0x400000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_CHECKBOXES"]/*'/>
    NSTCS_CHECKBOXES = 0x800000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_PARTIALCHECKBOXES"]/*'/>
    NSTCS_PARTIALCHECKBOXES = 0x1000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_EXCLUSIONCHECKBOXES"]/*'/>
    NSTCS_EXCLUSIONCHECKBOXES = 0x2000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_DIMMEDCHECKBOXES"]/*'/>
    NSTCS_DIMMEDCHECKBOXES = 0x4000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_NOINDENTCHECKS"]/*'/>
    NSTCS_NOINDENTCHECKS = 0x8000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_ALLOWJUNCTIONS"]/*'/>
    NSTCS_ALLOWJUNCTIONS = 0x10000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SHOWTABSBUTTON"]/*'/>
    NSTCS_SHOWTABSBUTTON = 0x20000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SHOWDELETEBUTTON"]/*'/>
    NSTCS_SHOWDELETEBUTTON = 0x40000000,
    /// <include file='NSTCSTYLE.xml' path='doc/member[@name="NSTCSTYLE.NSTCS_SHOWREFRESHBUTTON"]/*'/>
    NSTCS_SHOWREFRESHBUTTON = unchecked((int)(0x80000000)),
}