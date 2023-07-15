// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS"]/*'/>
[Flags]
public enum PROPDESC_FORMAT_FLAGS
{
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_DEFAULT"]/*'/>
    PDFF_DEFAULT = 0,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_PREFIXNAME"]/*'/>
    PDFF_PREFIXNAME = 0x1,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_FILENAME"]/*'/>
    PDFF_FILENAME = 0x2,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_ALWAYSKB"]/*'/>
    PDFF_ALWAYSKB = 0x4,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_RESERVED_RIGHTTOLEFT"]/*'/>
    PDFF_RESERVED_RIGHTTOLEFT = 0x8,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_SHORTTIME"]/*'/>
    PDFF_SHORTTIME = 0x10,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_LONGTIME"]/*'/>
    PDFF_LONGTIME = 0x20,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_HIDETIME"]/*'/>
    PDFF_HIDETIME = 0x40,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_SHORTDATE"]/*'/>
    PDFF_SHORTDATE = 0x80,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_LONGDATE"]/*'/>
    PDFF_LONGDATE = 0x100,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_HIDEDATE"]/*'/>
    PDFF_HIDEDATE = 0x200,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_RELATIVEDATE"]/*'/>
    PDFF_RELATIVEDATE = 0x400,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_USEEDITINVITATION"]/*'/>
    PDFF_USEEDITINVITATION = 0x800,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_READONLY"]/*'/>
    PDFF_READONLY = 0x1000,
    /// <include file='PROPDESC_FORMAT_FLAGS.xml' path='doc/member[@name="PROPDESC_FORMAT_FLAGS.PDFF_NOAUTOREADINGORDER"]/*'/>
    PDFF_NOAUTOREADINGORDER = 0x2000,
}