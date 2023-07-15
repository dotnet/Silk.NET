// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS"]/*'/>
[Flags]
public enum FOLDERFLAGS
{
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NONE"]/*'/>
    FWF_NONE = 0,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_AUTOARRANGE"]/*'/>
    FWF_AUTOARRANGE = 0x1,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_ABBREVIATEDNAMES"]/*'/>
    FWF_ABBREVIATEDNAMES = 0x2,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_SNAPTOGRID"]/*'/>
    FWF_SNAPTOGRID = 0x4,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_OWNERDATA"]/*'/>
    FWF_OWNERDATA = 0x8,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_BESTFITWINDOW"]/*'/>
    FWF_BESTFITWINDOW = 0x10,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_DESKTOP"]/*'/>
    FWF_DESKTOP = 0x20,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_SINGLESEL"]/*'/>
    FWF_SINGLESEL = 0x40,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOSUBFOLDERS"]/*'/>
    FWF_NOSUBFOLDERS = 0x80,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_TRANSPARENT"]/*'/>
    FWF_TRANSPARENT = 0x100,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOCLIENTEDGE"]/*'/>
    FWF_NOCLIENTEDGE = 0x200,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOSCROLL"]/*'/>
    FWF_NOSCROLL = 0x400,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_ALIGNLEFT"]/*'/>
    FWF_ALIGNLEFT = 0x800,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOICONS"]/*'/>
    FWF_NOICONS = 0x1000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_SHOWSELALWAYS"]/*'/>
    FWF_SHOWSELALWAYS = 0x2000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOVISIBLE"]/*'/>
    FWF_NOVISIBLE = 0x4000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_SINGLECLICKACTIVATE"]/*'/>
    FWF_SINGLECLICKACTIVATE = 0x8000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOWEBVIEW"]/*'/>
    FWF_NOWEBVIEW = 0x10000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_HIDEFILENAMES"]/*'/>
    FWF_HIDEFILENAMES = 0x20000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_CHECKSELECT"]/*'/>
    FWF_CHECKSELECT = 0x40000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOENUMREFRESH"]/*'/>
    FWF_NOENUMREFRESH = 0x80000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOGROUPING"]/*'/>
    FWF_NOGROUPING = 0x100000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_FULLROWSELECT"]/*'/>
    FWF_FULLROWSELECT = 0x200000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOFILTERS"]/*'/>
    FWF_NOFILTERS = 0x400000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOCOLUMNHEADER"]/*'/>
    FWF_NOCOLUMNHEADER = 0x800000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOHEADERINALLVIEWS"]/*'/>
    FWF_NOHEADERINALLVIEWS = 0x1000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_EXTENDEDTILES"]/*'/>
    FWF_EXTENDEDTILES = 0x2000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_TRICHECKSELECT"]/*'/>
    FWF_TRICHECKSELECT = 0x4000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_AUTOCHECKSELECT"]/*'/>
    FWF_AUTOCHECKSELECT = 0x8000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_NOBROWSERVIEWSTATE"]/*'/>
    FWF_NOBROWSERVIEWSTATE = 0x10000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_SUBSETGROUPS"]/*'/>
    FWF_SUBSETGROUPS = 0x20000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_USESEARCHFOLDER"]/*'/>
    FWF_USESEARCHFOLDER = 0x40000000,
    /// <include file='FOLDERFLAGS.xml' path='doc/member[@name="FOLDERFLAGS.FWF_ALLOWRTLREADING"]/*'/>
    FWF_ALLOWRTLREADING = unchecked((int)(0x80000000)),
}