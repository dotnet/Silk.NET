// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE"]/*'/>
[Flags]
public enum SHCOLSTATE
{
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_DEFAULT"]/*'/>
    SHCOLSTATE_DEFAULT = 0,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_TYPE_STR"]/*'/>
    SHCOLSTATE_TYPE_STR = 0x1,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_TYPE_INT"]/*'/>
    SHCOLSTATE_TYPE_INT = 0x2,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_TYPE_DATE"]/*'/>
    SHCOLSTATE_TYPE_DATE = 0x3,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_TYPEMASK"]/*'/>
    SHCOLSTATE_TYPEMASK = 0xf,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_ONBYDEFAULT"]/*'/>
    SHCOLSTATE_ONBYDEFAULT = 0x10,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_SLOW"]/*'/>
    SHCOLSTATE_SLOW = 0x20,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_EXTENDED"]/*'/>
    SHCOLSTATE_EXTENDED = 0x40,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_SECONDARYUI"]/*'/>
    SHCOLSTATE_SECONDARYUI = 0x80,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_HIDDEN"]/*'/>
    SHCOLSTATE_HIDDEN = 0x100,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_PREFER_VARCMP"]/*'/>
    SHCOLSTATE_PREFER_VARCMP = 0x200,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_PREFER_FMTCMP"]/*'/>
    SHCOLSTATE_PREFER_FMTCMP = 0x400,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_NOSORTBYFOLDERNESS"]/*'/>
    SHCOLSTATE_NOSORTBYFOLDERNESS = 0x800,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_VIEWONLY"]/*'/>
    SHCOLSTATE_VIEWONLY = 0x10000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_BATCHREAD"]/*'/>
    SHCOLSTATE_BATCHREAD = 0x20000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_NO_GROUPBY"]/*'/>
    SHCOLSTATE_NO_GROUPBY = 0x40000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_FIXED_WIDTH"]/*'/>
    SHCOLSTATE_FIXED_WIDTH = 0x1000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_NODPISCALE"]/*'/>
    SHCOLSTATE_NODPISCALE = 0x2000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_FIXED_RATIO"]/*'/>
    SHCOLSTATE_FIXED_RATIO = 0x4000,
    /// <include file='SHCOLSTATE.xml' path='doc/member[@name="SHCOLSTATE.SHCOLSTATE_DISPLAYMASK"]/*'/>
    SHCOLSTATE_DISPLAYMASK = 0xf000,
}