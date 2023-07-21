// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS"]/*' />
public enum AUTOCOMPLETELISTOPTIONS
{
    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_NONE"]/*' />
    ACLO_NONE = 0,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_CURRENTDIR"]/*' />
    ACLO_CURRENTDIR = 1,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_MYCOMPUTER"]/*' />
    ACLO_MYCOMPUTER = 2,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_DESKTOP"]/*' />
    ACLO_DESKTOP = 4,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_FAVORITES"]/*' />
    ACLO_FAVORITES = 8,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_FILESYSONLY"]/*' />
    ACLO_FILESYSONLY = 16,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_FILESYSDIRS"]/*' />
    ACLO_FILESYSDIRS = 32,

    /// <include file='AUTOCOMPLETELISTOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETELISTOPTIONS.ACLO_VIRTUALNAMESPACE"]/*' />
    ACLO_VIRTUALNAMESPACE = 64,
}
