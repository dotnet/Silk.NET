// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS"]/*' />
public enum DEFAULT_FOLDER_MENU_RESTRICTIONS
{
    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_DEFAULT"]/*' />
    DFMR_DEFAULT = 0,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_NO_STATIC_VERBS"]/*' />
    DFMR_NO_STATIC_VERBS = 0x8,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_STATIC_VERBS_ONLY"]/*' />
    DFMR_STATIC_VERBS_ONLY = 0x10,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_NO_RESOURCE_VERBS"]/*' />
    DFMR_NO_RESOURCE_VERBS = 0x20,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_OPTIN_HANDLERS_ONLY"]/*' />
    DFMR_OPTIN_HANDLERS_ONLY = 0x40,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_RESOURCE_AND_FOLDER_VERBS_ONLY"]/*' />
    DFMR_RESOURCE_AND_FOLDER_VERBS_ONLY = 0x80,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_USE_SPECIFIED_HANDLERS"]/*' />
    DFMR_USE_SPECIFIED_HANDLERS = 0x100,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_USE_SPECIFIED_VERBS"]/*' />
    DFMR_USE_SPECIFIED_VERBS = 0x200,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_NO_ASYNC_VERBS"]/*' />
    DFMR_NO_ASYNC_VERBS = 0x400,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_NO_NATIVECPU_VERBS"]/*' />
    DFMR_NO_NATIVECPU_VERBS = 0x800,

    /// <include file='DEFAULT_FOLDER_MENU_RESTRICTIONS.xml' path='doc/member[@name="DEFAULT_FOLDER_MENU_RESTRICTIONS.DFMR_NO_NONWOW_VERBS"]/*' />
    DFMR_NO_NONWOW_VERBS = 0x1000,
}
