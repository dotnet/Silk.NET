// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION"]/*'/>
public enum CIMTYPE_ENUMERATION
{
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_ILLEGAL"]/*'/>
    CIM_ILLEGAL = 0xfff,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_EMPTY"]/*'/>
    CIM_EMPTY = 0,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_SINT8"]/*'/>
    CIM_SINT8 = 16,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_UINT8"]/*'/>
    CIM_UINT8 = 17,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_SINT16"]/*'/>
    CIM_SINT16 = 2,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_UINT16"]/*'/>
    CIM_UINT16 = 18,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_SINT32"]/*'/>
    CIM_SINT32 = 3,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_UINT32"]/*'/>
    CIM_UINT32 = 19,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_SINT64"]/*'/>
    CIM_SINT64 = 20,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_UINT64"]/*'/>
    CIM_UINT64 = 21,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_REAL32"]/*'/>
    CIM_REAL32 = 4,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_REAL64"]/*'/>
    CIM_REAL64 = 5,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_BOOLEAN"]/*'/>
    CIM_BOOLEAN = 11,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_STRING"]/*'/>
    CIM_STRING = 8,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_DATETIME"]/*'/>
    CIM_DATETIME = 101,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_REFERENCE"]/*'/>
    CIM_REFERENCE = 102,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_CHAR16"]/*'/>
    CIM_CHAR16 = 103,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_OBJECT"]/*'/>
    CIM_OBJECT = 13,
    /// <include file='CIMTYPE_ENUMERATION.xml' path='doc/member[@name="CIMTYPE_ENUMERATION.CIM_FLAG_ARRAY"]/*'/>
    CIM_FLAG_ARRAY = 0x2000,
}