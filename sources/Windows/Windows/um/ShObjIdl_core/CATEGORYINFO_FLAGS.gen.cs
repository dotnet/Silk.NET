// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS"]/*'/>
[Flags]
public enum CATEGORYINFO_FLAGS
{
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_NORMAL"]/*'/>
    CATINFO_NORMAL = 0,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_COLLAPSED"]/*'/>
    CATINFO_COLLAPSED = 0x1,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_HIDDEN"]/*'/>
    CATINFO_HIDDEN = 0x2,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_EXPANDED"]/*'/>
    CATINFO_EXPANDED = 0x4,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_NOHEADER"]/*'/>
    CATINFO_NOHEADER = 0x8,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_NOTCOLLAPSIBLE"]/*'/>
    CATINFO_NOTCOLLAPSIBLE = 0x10,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_NOHEADERCOUNT"]/*'/>
    CATINFO_NOHEADERCOUNT = 0x20,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_SUBSETTED"]/*'/>
    CATINFO_SUBSETTED = 0x40,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_SEPARATE_IMAGES"]/*'/>
    CATINFO_SEPARATE_IMAGES = 0x80,
    /// <include file='CATEGORYINFO_FLAGS.xml' path='doc/member[@name="CATEGORYINFO_FLAGS.CATINFO_SHOWEMPTY"]/*'/>
    CATINFO_SHOWEMPTY = 0x100,
}