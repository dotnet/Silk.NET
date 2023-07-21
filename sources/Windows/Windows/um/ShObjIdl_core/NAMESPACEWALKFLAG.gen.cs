// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG"]/*' />
[Flags]
public enum NAMESPACEWALKFLAG
{
    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DEFAULT"]/*' />
    NSWF_DEFAULT = 0,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_NONE_IMPLIES_ALL"]/*' />
    NSWF_NONE_IMPLIES_ALL = 0x1,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_ONE_IMPLIES_ALL"]/*' />
    NSWF_ONE_IMPLIES_ALL = 0x2,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DONT_TRAVERSE_LINKS"]/*' />
    NSWF_DONT_TRAVERSE_LINKS = 0x4,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DONT_ACCUMULATE_RESULT"]/*' />
    NSWF_DONT_ACCUMULATE_RESULT = 0x8,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_TRAVERSE_STREAM_JUNCTIONS"]/*' />
    NSWF_TRAVERSE_STREAM_JUNCTIONS = 0x10,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_FILESYSTEM_ONLY"]/*' />
    NSWF_FILESYSTEM_ONLY = 0x20,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_SHOW_PROGRESS"]/*' />
    NSWF_SHOW_PROGRESS = 0x40,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_FLAG_VIEWORDER"]/*' />
    NSWF_FLAG_VIEWORDER = 0x80,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_IGNORE_AUTOPLAY_HIDA"]/*' />
    NSWF_IGNORE_AUTOPLAY_HIDA = 0x100,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_ASYNC"]/*' />
    NSWF_ASYNC = 0x200,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DONT_RESOLVE_LINKS"]/*' />
    NSWF_DONT_RESOLVE_LINKS = 0x400,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_ACCUMULATE_FOLDERS"]/*' />
    NSWF_ACCUMULATE_FOLDERS = 0x800,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DONT_SORT"]/*' />
    NSWF_DONT_SORT = 0x1000,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_USE_TRANSFER_MEDIUM"]/*' />
    NSWF_USE_TRANSFER_MEDIUM = 0x2000,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_DONT_TRAVERSE_STREAM_JUNCTIONS"]/*' />
    NSWF_DONT_TRAVERSE_STREAM_JUNCTIONS = 0x4000,

    /// <include file='NAMESPACEWALKFLAG.xml' path='doc/member[@name="NAMESPACEWALKFLAG.NSWF_ANY_IMPLIES_ALL"]/*' />
    NSWF_ANY_IMPLIES_ALL = 0x8000,
}
