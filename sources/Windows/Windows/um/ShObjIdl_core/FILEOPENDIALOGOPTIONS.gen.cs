// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS"]/*' />
[Flags]
public enum FILEOPENDIALOGOPTIONS
{
    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_OVERWRITEPROMPT"]/*' />
    FOS_OVERWRITEPROMPT = 0x2,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_STRICTFILETYPES"]/*' />
    FOS_STRICTFILETYPES = 0x4,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_NOCHANGEDIR"]/*' />
    FOS_NOCHANGEDIR = 0x8,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_PICKFOLDERS"]/*' />
    FOS_PICKFOLDERS = 0x20,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_FORCEFILESYSTEM"]/*' />
    FOS_FORCEFILESYSTEM = 0x40,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_ALLNONSTORAGEITEMS"]/*' />
    FOS_ALLNONSTORAGEITEMS = 0x80,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_NOVALIDATE"]/*' />
    FOS_NOVALIDATE = 0x100,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_ALLOWMULTISELECT"]/*' />
    FOS_ALLOWMULTISELECT = 0x200,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_PATHMUSTEXIST"]/*' />
    FOS_PATHMUSTEXIST = 0x800,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_FILEMUSTEXIST"]/*' />
    FOS_FILEMUSTEXIST = 0x1000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_CREATEPROMPT"]/*' />
    FOS_CREATEPROMPT = 0x2000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_SHAREAWARE"]/*' />
    FOS_SHAREAWARE = 0x4000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_NOREADONLYRETURN"]/*' />
    FOS_NOREADONLYRETURN = 0x8000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_NOTESTFILECREATE"]/*' />
    FOS_NOTESTFILECREATE = 0x10000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_HIDEMRUPLACES"]/*' />
    FOS_HIDEMRUPLACES = 0x20000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_HIDEPINNEDPLACES"]/*' />
    FOS_HIDEPINNEDPLACES = 0x40000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_NODEREFERENCELINKS"]/*' />
    FOS_NODEREFERENCELINKS = 0x100000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_OKBUTTONNEEDSINTERACTION"]/*' />
    FOS_OKBUTTONNEEDSINTERACTION = 0x200000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_DONTADDTORECENT"]/*' />
    FOS_DONTADDTORECENT = 0x2000000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_FORCESHOWHIDDEN"]/*' />
    FOS_FORCESHOWHIDDEN = 0x10000000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_DEFAULTNOMINIMODE"]/*' />
    FOS_DEFAULTNOMINIMODE = 0x20000000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_FORCEPREVIEWPANEON"]/*' />
    FOS_FORCEPREVIEWPANEON = 0x40000000,

    /// <include file='FILEOPENDIALOGOPTIONS.xml' path='doc/member[@name="FILEOPENDIALOGOPTIONS.FOS_SUPPORTSTREAMABLEITEMS"]/*' />
    FOS_SUPPORTSTREAMABLEITEMS = unchecked((int)(0x80000000)),
}
