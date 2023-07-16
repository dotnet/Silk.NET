// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER"]/*'/>
public enum PROPDESC_ENUMFILTER
{
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_ALL"]/*'/>
    PDEF_ALL = 0,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_SYSTEM"]/*'/>
    PDEF_SYSTEM = 1,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_NONSYSTEM"]/*'/>
    PDEF_NONSYSTEM = 2,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_VIEWABLE"]/*'/>
    PDEF_VIEWABLE = 3,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_QUERYABLE"]/*'/>
    PDEF_QUERYABLE = 4,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_INFULLTEXTQUERY"]/*'/>
    PDEF_INFULLTEXTQUERY = 5,
    /// <include file='PROPDESC_ENUMFILTER.xml' path='doc/member[@name="PROPDESC_ENUMFILTER.PDEF_COLUMN"]/*'/>
    PDEF_COLUMN = 6,
}