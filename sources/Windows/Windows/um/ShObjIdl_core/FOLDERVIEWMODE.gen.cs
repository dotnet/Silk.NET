// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE"]/*' />
public enum FOLDERVIEWMODE
{
    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_AUTO"]/*' />
    FVM_AUTO = -1,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_FIRST"]/*' />
    FVM_FIRST = 1,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_ICON"]/*' />
    FVM_ICON = 1,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_SMALLICON"]/*' />
    FVM_SMALLICON = 2,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_LIST"]/*' />
    FVM_LIST = 3,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_DETAILS"]/*' />
    FVM_DETAILS = 4,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_THUMBNAIL"]/*' />
    FVM_THUMBNAIL = 5,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_TILE"]/*' />
    FVM_TILE = 6,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_THUMBSTRIP"]/*' />
    FVM_THUMBSTRIP = 7,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_CONTENT"]/*' />
    FVM_CONTENT = 8,

    /// <include file='FOLDERVIEWMODE.xml' path='doc/member[@name="FOLDERVIEWMODE.FVM_LAST"]/*' />
    FVM_LAST = 8,
}
