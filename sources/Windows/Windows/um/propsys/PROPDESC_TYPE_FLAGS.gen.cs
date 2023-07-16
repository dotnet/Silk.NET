// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS"]/*'/>
[Flags]
public enum PROPDESC_TYPE_FLAGS
{
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_DEFAULT"]/*'/>
    PDTF_DEFAULT = 0,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_MULTIPLEVALUES"]/*'/>
    PDTF_MULTIPLEVALUES = 0x1,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISINNATE"]/*'/>
    PDTF_ISINNATE = 0x2,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISGROUP"]/*'/>
    PDTF_ISGROUP = 0x4,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_CANGROUPBY"]/*'/>
    PDTF_CANGROUPBY = 0x8,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_CANSTACKBY"]/*'/>
    PDTF_CANSTACKBY = 0x10,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISTREEPROPERTY"]/*'/>
    PDTF_ISTREEPROPERTY = 0x20,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_INCLUDEINFULLTEXTQUERY"]/*'/>
    PDTF_INCLUDEINFULLTEXTQUERY = 0x40,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISVIEWABLE"]/*'/>
    PDTF_ISVIEWABLE = 0x80,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISQUERYABLE"]/*'/>
    PDTF_ISQUERYABLE = 0x100,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_CANBEPURGED"]/*'/>
    PDTF_CANBEPURGED = 0x200,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_SEARCHRAWVALUE"]/*'/>
    PDTF_SEARCHRAWVALUE = 0x400,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_DONTCOERCEEMPTYSTRINGS"]/*'/>
    PDTF_DONTCOERCEEMPTYSTRINGS = 0x800,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ALWAYSINSUPPLEMENTALSTORE"]/*'/>
    PDTF_ALWAYSINSUPPLEMENTALSTORE = 0x1000,
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_ISSYSTEMPROPERTY"]/*'/>
    PDTF_ISSYSTEMPROPERTY = unchecked((int)(0x80000000)),
    /// <include file='PROPDESC_TYPE_FLAGS.xml' path='doc/member[@name="PROPDESC_TYPE_FLAGS.PDTF_MASK_ALL"]/*'/>
    PDTF_MASK_ALL = unchecked((int)(0x80001fff)),
}